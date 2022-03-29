using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand
{
    public class CannonsManager : MonoBehaviour
    {
        [Header("Properties")]
        [SerializeField] private ShooterController[] cannons;

        private void Awake()
        {
            cannons = GetComponentsInChildren<ShooterController>();   
        }


        private void Start()
        {
            foreach(var shooter in cannons)
            {
                UI.UIController.Instance.InstantiateCannonAmmoIndicator(shooter);
                shooter.Init();
            }
        }
    }
}