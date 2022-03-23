using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField] private Transform cannon;

    private CrosshairController crosshairController;

    private void Start()
    {
        crosshairController = FindObjectOfType<CrosshairController>();    
    }


    public void Aim (Vector3 targetPosition)
    {
        cannon.LookAt(targetPosition);
    }


    private void Update()
    {
        Aim(crosshairController.transform.position);
    }





}
