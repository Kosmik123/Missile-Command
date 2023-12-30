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
        public float Speed { get => speed; set => speed = value; }

        [SerializeField]
        private Vector3 targetPosition;
        public Vector3 TargetPosition
        { 
            get => targetPosition; 
            set => targetPosition = value;
        }

        [Header("Events")]
        [SerializeField]
        private UnityEvent OnTargetReach;

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
