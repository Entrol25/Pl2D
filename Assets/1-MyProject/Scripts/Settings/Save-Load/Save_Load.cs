//using System.Collections;
//using System.Collections.Generic;
//using System;
using UnityEngine;
//using UnityEngine.SceneManagement;//
//using Architecture;
/* К примеру - Отвечает за вход в игру, паузу, эвентами раскидывает контроллерам.
* Singleton - объект в 1-м экземпляре с защитой от дублирования!!! */
namespace Save_Load
{// Установлен первым на GameHelper / DontDestroyOnLoad(this.gameObject);
    public class Save_Load : MonoBehaviour
    {
        [SerializeField] private GameObject _gameHelper = null;
        //-----------------------------------------------
        public static Save_Load instance { get; private set; }// свойство
        private void Awake()
        {
            if (instance == null)// если GameManager не создан -> то создать
            {
                instance = this;
                // запрещает уничтожение объекта при смене сцены 
                DontDestroyOnLoad(this._gameHelper);
                return;
            }
            //else if (instance != null) { Destroy(this.gameObject); }// я
            Destroy(this._gameHelper);//в видео
        }
    }
}

