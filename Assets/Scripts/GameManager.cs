using System;

using UnityEngine;


namespace MissileCommand
{

    public class GameManager : MonoBehaviour
    {
        public static string enemyTag = "Enemy";
        public static string playerTag = "Player";
        
        public static GameManager Instance { get; private set; }

        public static event Action<int> OnPointsChanged;

        [Header("To Link")]
        [SerializeField] private new Camera camera;
        [SerializeField] private CrosshairController crosshair;
        [SerializeField] private EnemyManager enemyManager;
        [SerializeField] private ShooterController[] cannons;

        [Header("Settings")]
        [SerializeField] private int baseRocketCount;

        [Header("Properties")]
        [SerializeField] private int difficulty;

        [Header("States")]
        [SerializeField] private int points;
        public int Points { get => points; private set => points = value; }

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
            DontDestroyOnLoad(this);
            
            crosshair.rectProvider = enemyManager.rectProvider = camera.GetComponent<CameraRectProvider>();
            enemyManager.SetDifficulty(difficulty);

            foreach (var cannon in cannons)
                cannon.Target = crosshair.transform;

            difficulty = 1;
        
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
