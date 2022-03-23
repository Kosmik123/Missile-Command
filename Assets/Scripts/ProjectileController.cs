using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float speed;




    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.up);
    }
}
