using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace MissileCommand.UI
{
    public class AmmoIndicatorController : MonoBehaviour
    {
        private ShooterController shooter;
        public ShooterController Shooter { get => shooter; set => shooter = value; }

        [Header("Prefabs")]
        [SerializeField] private GameObject ammoSymbolPrefab;

        [Header("To link")]
        [SerializeField] private TMP_Text infoLabel;
        [SerializeField] private RectTransform symbolsContainer;

        [Header("Settings")]
        [SerializeField] private float horizontalOffset;
        [SerializeField] private float verticalOffset;
        
        [SerializeField] private string lowAmmoText;
        [SerializeField] private string outOfAmmoText;

        [SerializeField] private int lowAmmunition;

        [Header("States")]
        [SerializeField] private List<RectTransform> symbols = new List<RectTransform>();

        private void OnEnable()
        {
            if (shooter != null)
                Init();
        }

        public void Init()
        {
            shooter.OnAmmunitionChanged += Refresh;
        }

        public void Refresh(int count)
        {
            RefreshSymbols(count);
            RefreshInfoLabel(count);
        }

        private void RefreshSymbols(int count)
        {
            while (symbols.Count < count)
            {
                var obj = Instantiate(ammoSymbolPrefab, symbolsContainer);
                symbols.Add(obj.GetComponent<RectTransform>());
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                symbols[i].localPosition = CalculateSymbolPosition(i, horizontalOffset, verticalOffset);
                symbols[i].gameObject.SetActive(i < count);
            }
        }

        private void RefreshInfoLabel(int count)
        {
            if (count == 0)
                infoLabel.text = outOfAmmoText;
            else if (count <= lowAmmunition)
                infoLabel.text = lowAmmoText;
            else
                infoLabel.text = string.Empty;
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

        private void OnDisable()
        {
            shooter.OnAmmunitionChanged -= Refresh;
        }

    }
}