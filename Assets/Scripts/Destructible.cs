using UnityEngine;
using UnityEngine.Events;

namespace MissileCommand
{
    [RequireComponent(typeof(Collider2D))]
    public class Destructible : MonoBehaviour
    {
        public enum DestructionType
        {
            DisableObject,
            DestroyObject
        }

        [SerializeField]
        private DestructionType destructionType;

        [Header("Events")]
        [SerializeField]
        private UnityEvent onBeingDestroyed;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Building"))
                return;

            switch (destructionType)
            {
                case DestructionType.DisableObject:
                    gameObject.SetActive(false);
                    break;
                case DestructionType.DestroyObject:
                    Destroy(gameObject);
                    break;
            }

            onBeingDestroyed?.Invoke();
        }
    }
}
