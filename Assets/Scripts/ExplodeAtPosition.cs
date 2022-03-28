using UnityEngine;

namespace MissileCommand
{
    public class ExplodeAtPosition : MonoBehaviour
    {
        public void Explode()
        {
            ProjectileInstantiator.InstantiateExplosion(transform.position, gameObject.tag);
            Destroy(gameObject);
        }
    }

}