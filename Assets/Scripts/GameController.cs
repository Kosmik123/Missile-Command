using System;

using UnityEngine;


namespace MissileCommand
{


    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }

        public static event Action<int> OnPointsChanged;

        [Header("Settings")]
        [SerializeField] private new Camera camera;
        [SerializeField] private CrosshairController crosshair;
        [SerializeField] private ShooterController[] cannons;

        [Header("States")]
        [SerializeField] private float points;
        public float Points { get => points; private set => points = value; }

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
            crosshair.rectProvider = camera.GetComponent<CameraRectProvider>();

            foreach (var cannon in cannons)
            {
                cannon.Target = crosshair.transform;
            }
        }

        public void AddPoints(int points)
        {
            if (points < 0)
                return;

            this.points += points;
            OnPointsChanged?.Invoke(points);
        }


    } 
}
