//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button
using UIS_Scripts_Settings;//

namespace UIMenuFXOverPopup
{
    public class BackFromSceneList : MonoBehaviour
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
            Back();
        }
        private void Back()
        {
            this.gO_MenuStart.SetActive(true);
            this.gO_SceneList.SetActive(false);
        }
    }
}
