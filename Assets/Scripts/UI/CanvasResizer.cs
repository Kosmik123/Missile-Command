using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand.UI
{
    [RequireComponent(typeof(Canvas))]
    public class CanvasResizer : MonoBehaviour
    {
        private void Start()
        {
            var rectProvider = GetComponent<Canvas>().worldCamera.GetComponent<CameraRectProvider>();
            Rect rect = rectProvider.GetRect();
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.position = rect.center;
            rectTransform.sizeDelta = rect.size;
        }

    }
}
