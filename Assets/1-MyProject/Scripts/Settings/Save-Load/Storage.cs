//using System.Collections;
//using System.Collections.Generic;
using System.IO;//
using System.Runtime.Serialization;//
using System.Runtime.Serialization.Formatters.Binary;//
using UnityEngine;

namespace Save_Load
{
    public class Storage // Storage - Место хранения
    {
        private string filePath;// путь к файлу
        private BinaryFormatter formatter;
        public Storage()// конструктор
        {
            var directory = Application.persistentDataPath + "/saves";// directory
            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
            filePath = directory + "/GameSave.save";// создать папку и файл
            InitBinaryFormatter();
        }
        private void InitBinaryFormatter()
        {
            formatter = new BinaryFormatter();
            var selector = new SurrogateSelector();
            var v3Surrogte = new Vector3SerializationSurrogte();
            var qSurrogte = new QuaternionSerializationSurrogte();
            selector.AddSurrogate(typeof(Vector3),
                new StreamingContext(StreamingContextStates.All), v3Surrogte);
            selector.AddSurrogate(typeof(Quaternion),
                new StreamingContext(StreamingContextStates.All), qSurrogte);
            formatter.SurrogateSelector = selector;
        }
        public object Load(object saveDataByDefault)
        {
            if (!File.Exists(filePath))// если файл не создан
            {
                if (saveDataByDefault != null) { Save(saveDataByDefault); }// Save
                return saveDataByDefault;
            }
            // файл создан
            var file = File.Open(filePath, FileMode.Open);
            var savedData = formatter.Deserialize(file);
            file.Close();
            return savedData;
        }
        public void Save(object saveData)
        {
            var file = File.Create(filePath);
            formatter.Serialize(file, saveData);
            file.Close();
        }
    }
}
