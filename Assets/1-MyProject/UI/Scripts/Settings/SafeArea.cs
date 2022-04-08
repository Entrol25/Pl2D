//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
// Чёлка. лежит на UI.

namespace UIS_Scripts_Settings
{
    public class SafeArea : MonoBehaviour
    {
        private void Awake()
        {
            UpdateSafeArea();
        }
        private void UpdateSafeArea()
        {
            // вытащить данные безопасного прямоугольника для SafeArea-obj RectTransform
            var safeArea = Screen.safeArea;
            var myRectTransform = GetComponent<RectTransform>();
            //
            var anchorMin = safeArea.position;// нижний левый угол
            var anchorMax = safeArea.position + safeArea.size;// верхний правый угол
                                                              // нормализуем (в от 0 до 1) координаты из пикселей
            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
            myRectTransform.anchorMin = anchorMin;
            myRectTransform.anchorMax = anchorMax;
        }
    }
}
