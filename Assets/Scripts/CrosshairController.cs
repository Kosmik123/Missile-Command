using UnityEngine;
using UnityEngine.InputSystem;

namespace MissileCommand
{
    public class CrosshairController : MonoBehaviour
    {
        public IRectProvider rectProvider;

        [Header("Settings")]
        [SerializeField]
        private InputActionReference crosshairAimingInput;
        [SerializeField]
        private float moveSpeed;
        private Rect movementArea;

        //[Header("States")]
        private Vector3 move;

        private void OnEnable()
        {
            crosshairAimingInput.action.Enable();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Start()
        {
            movementArea = rectProvider.GetRect();
        }

        private void Update()
        {
            move = crosshairAimingInput.action.ReadValue<Vector2>();
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
            crosshairAimingInput.action.Disable();
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