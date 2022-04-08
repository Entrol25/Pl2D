//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button
using UIS_Scripts_Settings;//

namespace UIMenuFXOverPopup
{
    public class SceneList : MonoBehaviour// Menu-Start/Button
    {
        [SerializeField] private Button button = null;

        [SerializeField] public GameObject gO_MenuStart = null;
        [SerializeField] public GameObject gO_SceneList = null;
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
            MySceneList();
        }
        private void MySceneList()
        {
            this.gO_MenuStart.SetActive(false);
            this.gO_SceneList.SetActive(true);
        }
    }
}
