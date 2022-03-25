using UnityEngine;
namespace MissileCommand
{
    public class ExplodeAtPosition : MonoBehaviour
    {
        private float delta = 0.05f;

        [SerializeField] private Vector3 explodePosition;



        private void Update()
        {
            if((transform.position - explodePosition).magnitude < delta)
            {
                Explode();
            }
        }

        private void Explode()
        {
            // Instantiate Explosion Object


            Destroy(gameObject);
        }
    }

}