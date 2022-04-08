//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//

namespace Test
{
    public class Button_Exit : MonoBehaviour
    {
        private Text text;
        private GameLanguage gameLanguage;//
        //    public Button_Exit(GameLanguage.GameLanguage gameLanguage)// конструктор
        //    {
        //        this.gameLanguage = gameLanguage;
        //        // подписка на событие - 1 вариант BankHandle
        //        this.gameLanguage.LanguageEvent += new LanguageHandler(NewLanguage);
        //    }
        private void Awake()
        {
            text = GetComponentInChildren<Text>();
        }
        public void NewLanguage()
        {
            text.text = "Выход";
        }
    }
}
