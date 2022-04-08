using System;//
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Save_Load
{
    [Serializable]
    public class GameData
    {
        public string voidDataTest;
        public string langUI;
        //------------------------------------------------------//
        public int speed;
        public Vector3 position;// структура - не сериализуема
        public Quaternion rotation;// структура - не сериализуема
        public GameData()// конструктор
        {
            langUI = "EN";
            voidDataTest = "En";
            //-------------------------------//
            speed = 10;
            position = Vector3.up;
            rotation = Quaternion.identity;
        }
    }
}
