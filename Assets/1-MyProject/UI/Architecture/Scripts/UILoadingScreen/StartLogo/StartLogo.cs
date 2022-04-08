using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace UILoadingScreen
{
    public class StartLogo : MonoBehaviour
    {
        [SerializeField] private GameObject gO_StartLogo = null;
        [SerializeField] private GameObject gO_MenuStart = null;
        [SerializeField] public GameObject gO_SceneList = null;
        private void Start()
        {
            this.gO_StartLogo.SetActive(true);
            this.gO_MenuStart.SetActive(false);
            this.gO_SceneList.SetActive(false);
            //--------------------------------
            StartCoroutine(Pause());//---   Coroutine ---
        }
        private void EndStartLogo()
        {
            this.gO_MenuStart.SetActive(true);
            this.gO_StartLogo.SetActive(false);
        }
        IEnumerator Pause()//---   Coroutine ---
        {   //               пауза
            yield return new WaitForSeconds(2.0f);
            EndStartLogo();
        }
    }
}
