using UnityEngine;

namespace MissileCommand
{
    [RequireComponent(typeof(LineRenderer))]
    public class ProjectileTrailController : MonoBehaviour
    {
        private LineRenderer lineRenderer;

        private void Awake()
        {
            lineRenderer = GetComponent<LineRenderer>();
        }

        private void Start()
        {
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position);
        }

        private void Update()
        {
            lineRenderer.SetPosition(0, transform.position);
        }

    }

}