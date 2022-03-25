using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand {

    public class GameController : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private new Camera camera;
        [SerializeField] private CrosshairController crosshair;
        [SerializeField] private ShooterController[] cannons;

        private void Awake()
        {
            crosshair.rectProvider = camera.GetComponent<CameraRectProvider>();

            foreach (var cannon in cannons)
            {
                cannon.Target = crosshair.transform;
            }

        }


    } 
}
