using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MissileCommand {

    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }

        [Header("Settings")]
        [SerializeField] private new Camera camera;
        [SerializeField] private CrosshairController crosshair;
        [SerializeField] private ShooterController[] cannons;

        [Header("States")]
        [SerializeField] private float points;

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
            crosshair.rectProvider = camera.GetComponent<CameraRectProvider>();

            foreach (var cannon in cannons)
            {
                cannon.Target = crosshair.transform;
            }
        }


    } 
}
