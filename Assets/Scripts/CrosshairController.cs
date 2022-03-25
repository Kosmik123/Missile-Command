using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MissileCommand
{

    public class CrosshairController : MonoBehaviour
    {
        private Controls input;

        public IRectProvider rectProvider;

        [Header("Settings")]
        [SerializeField] private float moveSpeed;
        [SerializeField] private Rect movementArea;


        //[Header("States")]
        private Vector3 move;


        private void Awake()
        {
            input = new Controls();
        }

        private void OnEnable()
        {
            input.Crosshair.Enable();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Start()
        {
            movementArea = rectProvider.GetRect();
        }

        private void Update()
        {
            move = input.Crosshair.Aiming.ReadValue<Vector2>();

            UpdateMovement();
        }

        private void UpdateMovement()
        {
            Vector3 position = transform.position;
            position += moveSpeed * Time.deltaTime * move;
            position.x = Mathf.Clamp(position.x, movementArea.xMin, movementArea.xMax);
            position.y = Mathf.Clamp(position.y, movementArea.yMin, movementArea.yMax);
            transform.position = position;
        }

        private void OnDisable()
        {
            input.Crosshair.Disable();
        }

#if UNITY_EDITOR
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(movementArea.center, movementArea.size);
        }


#endif
    }
}