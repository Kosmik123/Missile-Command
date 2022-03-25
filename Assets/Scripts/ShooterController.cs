using UnityEngine;
namespace MissileCommand
{
    public interface IProjectileIntantiator
    {
        
    }


    public class ShooterController : MonoBehaviour
    {
        private Transform target;
        public Transform Target { get => target; set => target = value; }

        [Header("Settings")]
        [SerializeField] private Transform cannon;
        [SerializeField] private GameObject rocketPrefab;
        [SerializeField] private bool canRotate3D;

        [Header("States")]
        [SerializeField] private int ammunition;
 
        private void Update()
        {
            Aim(target.position);
        }

        public void Aim(Vector3 targetPosition)
        {
            if (canRotate3D == false)
                targetPosition.z = transform.position.z;
            cannon.LookAt(targetPosition);
        }

        public void Shoot()
        {
            if (ammunition <= 0)
                return;

            ammunition -= 1;
        }

    }
}