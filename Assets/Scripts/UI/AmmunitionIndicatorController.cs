using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MissileCommand.UI
{
    public class AmmunitionIndicatorController : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private GameObject ammoSymbolPrefab;
        [SerializeField] private float horizontalOffset;
        [SerializeField] private float verticalOffset;

        [Header("States")]
        [SerializeField] private List<RectTransform> symbols;
        public int ammo;

        private void Start()
        {

        }

        private void Refresh(int count)
        {
            while (symbols.Count < count)
            {
                var obj = Instantiate(ammoSymbolPrefab, transform);
                symbols.Add(obj.GetComponent<RectTransform>());
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                symbols[i].localPosition = CalculateSymbolPosition(i, horizontalOffset, verticalOffset);
                symbols[i].gameObject.SetActive(i < count);
            }
        }

        private Vector2 CalculateSymbolPosition(int index, float horizontal, float vertical)
        {
            int row = FindRow(index);
            float x = FindColumn(index, row) * horizontal;
            float y = row * vertical;
            return new Vector2(x, y);
        }

        private int FindColumn(int index, int row)
        {
            int firstIndex = row * (row + 1) / 2;
            int relativeIndex = index - firstIndex;

            return relativeIndex * 2 - row;
        }

        private static int FindRow(int index)
        {
            int n = 0;
            int sum = 0;
            while(true)
            {
                sum += n;
                if (sum > index)
                    return n - 1;
                n++;
            }
        }


        private void OnValidate()
        {
            Refresh(ammo);
        }

    }
}