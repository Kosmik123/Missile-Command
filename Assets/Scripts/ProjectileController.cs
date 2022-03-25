using System;
using UnityEngine;
using UnityEngine.Events;


namespace MissileCommand
{

    public class ProjectileController : MonoBehaviour
    {
        private float delta = 0.01f;

        [Header("Settings")]
        [SerializeField] private float speed;
        public float Speed { get => speed; set => speed = value; }

        [SerializeField] private Vector3 targetPosition;
        public Vector3 TargetPosition { get => targetPosition; set => targetPosition = value; }

        [Header("States")]
        [SerializeField] private Vector3 velocity;
        [SerializeField] private float progress;

        [Header("Events")]
        public UnityEvent OnTargetReach;

        



        void Update()
        {
            //transform.Translate(Speed * Time.deltaTime * Vector3.forward);

            float movement = speed * Time.deltaTime;

            Vector3 notNormalizedDirection = targetPosition - transform.position;
            if (notNormalizedDirection.magnitude < movement)
            {
                transform.position = targetPosition;
                OnTargetReach?.Invoke();
            }
            else
                transform.position += movement * notNormalizedDirection.normalized;
        
        }




    }

}