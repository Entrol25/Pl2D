using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public sealed class Coroutines : MonoBehaviour// sealed - запрещает наследование
    {
        private static Coroutines m_instance;
        private static Coroutines instance // синглтон
        {
            get
            {
                if (m_instance == null)
                {
                    var go = new GameObject("[COROUTINE MANAGER]");
                    m_instance = go.AddComponent<Coroutines>();
                    DontDestroyOnLoad(go);
                }
                return m_instance;
            }
        }
        public static Coroutine StartRoutine(IEnumerator enumerator)
        {
            return instance.StartCoroutine(enumerator);
        }
        public static void StopRoutine(Coroutine routine)
        {
            if(routine != null)
            { instance.StopCoroutine(routine); }
        }
    }
}
