using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        [SerializeField] private DestructionType destructionType;


        private void OnTriggerEnter2D(Collider2D other)
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

            ProjectileInstantiator.InstantiateExplosion(transform.position, gameObject.tag);
        }
    }
}
