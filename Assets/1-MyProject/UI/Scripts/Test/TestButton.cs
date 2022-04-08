//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button

namespace Test
{
    public class TestButton : MonoBehaviour
    {
        [SerializeField] private TestText testText = null;
        public Button button;
        private void OnEnable()
        {
            button.AddListener(this.OnClick);
            //Debug.Log("4");
        }
        private void OnDisable()
        {
            button.RemoveListener(this.OnClick);
            //Debug.Log("5");
        }
        private void OnClick()
        {
            testText.Vork();
            //Debug.Log("On Button clicked-1");
        }
        //---------------------------------------------------------
        //void Update()// FixedUpdate()
        //{
        //    button.onClick.AddListener(OnClicked);// подписка на событие button.onClick

        //}
        //private void OnClicked()// подписка на событие button.onClick
        //{
        //    Debug.Log("OnClicked()");
        //}
    }
}
