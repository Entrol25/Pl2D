//using System;// Action
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    // 1 - событие-event через именованный delegate
    public delegate void LanguageHandler();//(string lang);
    public class GameLanguage// : MonoBehaviour
    {
        public event LanguageHandler LanguageEvent = null;
        public string lang;
        public string _lang { get; set; }// свойство
        public void InvokeNewLanguageEvent()// AddCoins
        {// крикнуть всем
            Debug.Log("+++ InvokeNewLanguageEvent() +++");
            LanguageEvent.Invoke();//(this.lang);
        }
    }
}
