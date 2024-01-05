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

        [SerializeField]
        private Camera _camera;
        public Camera Camera
        {
            get
            {
                if (_camera == null)
                    _camera = Camera.main;
                return _camera;
            }
        }

        private void Awake()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void OnEnable()
        {
            crosshairAimingInput.action.Enable();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void Start()
        {
            movementArea = rectProvider.GetRect();
            transform.position = Vector3.zero;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void Update()
        {
            if (Mouse.current.delta.ReadValue().sqrMagnitude > 0.01f)
                UpdatePositionWithCursorPosition();

            move = crosshairAimingInput.action.ReadValue<Vector2>();
            if (move.sqrMagnitude > 0.01f)
                UpdateFramerateDependentMovement();
        }

        private void UpdatePositionWithCursorPosition()
        {
            var mousePosition = Mouse.current.position.ReadValue();
            var position = Camera.ScreenToWorldPoint(mousePosition);
            position.z = 0;
            transform.position = position;
        }

        private void UpdateFramerateDependentMovement()
        {
            Vector3 position = transform.position;

            position += moveSpeed * Time.deltaTime * move;
            position.x = Mathf.Clamp(position.x, movementArea.xMin, movementArea.xMax);
            position.y = Mathf.Clamp(position.y, movementArea.yMin, movementArea.yMax);
            transform.position = position;
            Mouse.current.WarpCursorPosition(Camera.WorldToScreenPoint(position));
        }

        private void OnApplicationFocus(bool focus)
        {
            if (focus)
            {
                UpdatePositionWithCursorPosition();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Confined;
            }
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