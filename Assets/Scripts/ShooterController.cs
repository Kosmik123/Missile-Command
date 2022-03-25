using UnityEngine;
namespace MissileCommand
{

    public class ShooterController : MonoBehaviour
    {
        private Transform target;
        public Transform Target { get => target; set => target = value; }

        [SerializeField] private Transform cannon;
        [SerializeField] private GameObject rocketPrefab;
 

        private void Update()
        {
            Aim(target.position);
        }


        public void Aim(Vector3 targetPosition)
        {
            cannon.LookAt(targetPosition);
        }


        public void Shoot()
        {

        }







    }
}