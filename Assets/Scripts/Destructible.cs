using UnityEngine;
using UnityEngine.Events;

namespace MissileCommand
{
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

        public void Destroy()
        {
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
