using UnityEngine;

namespace MissileCommand
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class ExplosionController : MonoBehaviour
    {
        private new CircleCollider2D collider;

        [Header("Settings")]
        [SerializeField] private AnimationCurve sizeChangeCurve;
        [SerializeField] private float maxRadius;
        [SerializeField] private float speed;

        private float progress = 0;
        private float radius;


        private void Awake()
        {
            collider = GetComponent<CircleCollider2D>();
        }

        private void Update()
        {
            progress += speed * Time.deltaTime;
            radius = maxRadius * sizeChangeCurve.Evaluate(progress);

            collider.radius = radius;

            if (progress > 1)
                Destroy(gameObject);
        }

    }
}