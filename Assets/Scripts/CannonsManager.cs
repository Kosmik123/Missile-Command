using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand
{
    public class CannonsManager : MonoBehaviour
    {
        [Header("Properties")]
        [SerializeField] 
        private ShooterController[] cannons;
        public IReadOnlyList<ShooterController> Cannons => cannons;

        [ContextMenu("Gather Cannons")]
        private void GatherCannons()
        {
            cannons = GetComponentsInChildren<ShooterController>(); 
        }

        private void Start()
        {
            foreach(var shooter in cannons)
            {
                shooter.RefillAmmo();
            }
        }
    }
}