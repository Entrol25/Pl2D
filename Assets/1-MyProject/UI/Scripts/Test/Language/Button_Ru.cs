//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button

namespace Test
{
    public class Button_Ru : MonoBehaviour
    {
        [SerializeField] private Button buttonExit;
        //string lang = "RU";
        public Button button;
        private GameLanguage gameLanguage;//
        private Button_Exit button_exit;//
        private void Awake()
        {
            this.gameLanguage = new GameLanguage();
            //this.button_exit = new Button_Exit(this.gameLanguage);
        }
        //void Start()
        //{

        //}
        //void Update()
        //{

        //}
        private void OnEnable()
        {
            button.AddListener(this.OnClick); //Debug.Log("4");
        }
        private void OnDisable()
        {
            button.RemoveListener(this.OnClick); //Debug.Log("5");
        }
        static private void LanguageMessage()// обработчик события
        {
            Debug.Log("+++ LanguageMessage() +++"); //return "RU";
        }
        static private void LanguageMessage2()// обработчик события
        {
            Debug.Log("+++ LanguageMessage2() +++");
        }
        private void OnClick()
        {
            gameLanguage.LanguageEvent += LanguageMessage;
            gameLanguage.LanguageEvent += LanguageMessage2;
            gameLanguage.InvokeNewLanguageEvent();
            Debug.Log("+++ ------------------- +++");
            gameLanguage.LanguageEvent -= LanguageMessage;
            gameLanguage.LanguageEvent -= LanguageMessage2;
            Debug.Log("+++=====================+++");
        }
    }
}
