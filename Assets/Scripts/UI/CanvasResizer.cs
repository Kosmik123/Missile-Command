using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand.UI
{
    [RequireComponent(typeof(RectTransform))]
    public class CanvasResizer : MonoBehaviour
    {
        public IRectProvider rectProvider;

        private void Awake()
        {

        }

        private void Start()
        {
            Rect rect = rectProvider.GetRect();
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.position = rect.center;
            rectTransform.sizeDelta = rect.size;
        }

    }
}
