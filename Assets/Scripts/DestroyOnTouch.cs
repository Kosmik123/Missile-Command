using UnityEngine;

namespace MissileCommand
{
    [RequireComponent(typeof(Collider2D), typeof(Destructible))]
    public class DestroyOnTouch : MonoBehaviour
    {
        private Destructible _destructible;
        public Destructible Destructible
        {
            get
            {
                if (_destructible == null)
                    _destructible = GetComponent<Destructible>();
                return _destructible;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Building"))
                return;

            Destructible.Destroy();
        }
    }
}
