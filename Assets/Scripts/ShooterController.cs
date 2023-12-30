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
        [SerializeField] 
        private Transform cannonModel;
        [SerializeField] 
        private bool canRotate3D;
        [SerializeField] 
        private float rocketSpeed;
        [SerializeField]
        private InputActionReference shootInput;
        [SerializeField] 
        private int initialAmmunition;
        
        [Header("States")]
        [SerializeField] private int ammunition;

        private void OnEnable()
        {
            shootInput.action.Enable();
            shootInput.action.performed += DoShoot;
            SetAmmunition(initialAmmunition);
        }

        public void Init()
        {
            Debug.Log($"Shooter start. New ammo = {initialAmmunition}");
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

            ProjectileSpawner.InstantiatePlayersRocket(cannonModel.position, rocketSpeed, target.position);
        }


        private void SetAmmunition(int newValue)
        {
            ammunition = newValue;
            OnAmmunitionChanged?.Invoke(ammunition);
        }

        private void OnDisable()
        {
            SetAmmunition(0); 
            shootInput.action.performed -= DoShoot;
            shootInput.action.Disable();
        }
    }
}