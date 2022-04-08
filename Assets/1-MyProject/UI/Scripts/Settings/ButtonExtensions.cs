//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
using UnityEngine.UI;// Button
using UnityEngine.Events;// UnityAction

namespace UIS_Scripts_Settings
{
    public static class ButtonExtensions
    {
        public static void AddListener(this Button button, UnityAction callback)
        {
            button.onClick.AddListener(callback); //Debug.Log("1");
        }
        public static void RemoveListener(this Button button, UnityAction callback)
        {
            button.onClick.RemoveListener(callback); //Debug.Log("2");
        }
        public static void RemoveAllListeners(this Button button)
        {
            button.onClick.RemoveAllListeners(); //Debug.Log("3");
        }
    }
}

