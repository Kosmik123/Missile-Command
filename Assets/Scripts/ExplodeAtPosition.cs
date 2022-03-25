using UnityEngine;

namespace MissileCommand
{
    public class ExplodeAtPosition : MonoBehaviour
    {
        private float delta = 0.1f;

        [SerializeField] private Vector3 explodePosition;
        public Vector3 ExplodePosition { get => explodePosition; set => explodePosition = value; }

        public void Explode()
        {
            ProjectileInstantiator.InstantiateExplosion(transform.position);
            Destroy(gameObject);
        }
    }

}