//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Button

namespace Test
{
    public class TestText : MonoBehaviour
    {
        public Text text { get; private set; }
        void Start()
        {
            text = GetComponent<Text>();
            Debug.Log($"My Text = {text.text}");
        }
        public void Vork()
        {
            text.text = "On Button clicked-2";
            Debug.Log("On Button clicked-2");
        }
    }
}
