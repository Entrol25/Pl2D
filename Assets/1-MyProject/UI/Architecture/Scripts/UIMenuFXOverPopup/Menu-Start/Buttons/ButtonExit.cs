//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button
using UIS_Scripts_Settings;//

namespace UIMenuFXOverPopup
{
    public class ButtonExit : MonoBehaviour
    {
        [SerializeField] private Button button = null;
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
            Exit();
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
        private void Exit()
        {
            // запись
            //myCameraSettings.MyButtonSave();/// static
            //Debug.Log("---   Exit()   ---");
            Application.Quit();
        }
    }
}
