using UnityEngine;
using UnityEngine.Events;

namespace MissileCommand
{
    public class ProjectileController : MonoBehaviour
    {
        public event System.Action OnTargetReached;

        [Header("Settings")]
        [SerializeField] 
        private float speed;
        public float Speed => speed; 

        [SerializeField]
        private Vector3 targetPosition;
        public Vector3 TargetPosition => targetPosition;

        [Header("Events")]
        [SerializeField]
        private UnityEvent OnTargetReach;

        public void Init(float speed, Vector3 target)
        {
            this.speed = speed; 
            targetPosition = target;
        }

        void Update()
        {
            float movement = speed * Time.deltaTime;

            Vector3 notNormalizedDirection = targetPosition - transform.position;
            if (notNormalizedDirection.sqrMagnitude < movement * movement)
            {
                transform.position = targetPosition;
                OnTargetReach.Invoke();
                OnTargetReached?.Invoke();
            }
            else
            {
                transform.position += movement * notNormalizedDirection.normalized;
            }
        }
    }
}
