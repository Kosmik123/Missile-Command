using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MissileCommand
{
    public class ShooterController : MonoBehaviour
    {
        public event Action<int> OnAmmunitionChanged;

        private Transform target;
        public Transform Target { get => target; set => target = value; }

        [Header("Settings")]
        [SerializeField] private Transform cannonModel;
        [SerializeField] private bool canRotate3D;
        [SerializeField] private float rocketSpeed;
        [SerializeField] private InputAction shootAction;
        [SerializeField] private int initialAmmunition;
        
        [Header("States")]
        [SerializeField] private int ammunition;
  
        private void OnEnable()
        {
            shootAction.Enable();
            shootAction.performed += DoShoot;  
            
        }

        private void Start()
        {
            SetAmmunition(initialAmmunition);
        }

        private void DoShoot(InputAction.CallbackContext context)
        {
            Shoot();
        }

        private void Update()
        {
            Aim(target.position);
        }

        public void Aim(Vector3 targetPosition)
        {
            if (canRotate3D == false)
                targetPosition.z = transform.position.z;

            cannonModel.LookAt(targetPosition);
        }

        public void Shoot()
        {
            if (ammunition <= 0)
                return;

            SetAmmunition(ammunition - 1);
            ProjectileInstantiator.InstantiatePlayersRocket(cannonModel.position, cannonModel.rotation, rocketSpeed, target.position);
        }

        private void SetAmmunition(int newValue)
        {
            ammunition = newValue;
            OnAmmunitionChanged?.Invoke(ammunition);
        }

        private void OnDisable()
        {
            shootAction.Disable();
            shootAction.performed -= DoShoot;
        }
    }
}