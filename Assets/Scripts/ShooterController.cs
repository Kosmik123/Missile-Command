using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MissileCommand
{
    public class ShooterController : MonoBehaviour
    {
        private Transform target;
        public Transform Target { get => target; set => target = value; }

        [Header("Settings")]
        [SerializeField] private Transform cannonModel;
        [SerializeField] private bool canRotate3D;
        [SerializeField] private float rocketSpeed;
        [SerializeField] private InputAction shootAction;



        [Header("States")]
        [SerializeField] private int ammunition;

  
        private void OnEnable()
        {
            shootAction.Enable();
            shootAction.performed += DoShoot;           
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

            ammunition -= 1;
            ProjectileInstantiator.InstantiateRocket(cannonModel.position, cannonModel.rotation, rocketSpeed, target.position);
        }

        private void OnDisable()
        {
            shootAction.Disable();
            shootAction.performed -= DoShoot;
        }
    }
}