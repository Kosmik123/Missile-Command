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
        [SerializeField] private Transform citiesContainer;
        [SerializeField] private Transform cannonsContainer;

        [Header("Settings")]
        [SerializeField] private int baseRocketCount;

        [Header("Properties")]
        [SerializeField] private int difficulty;

        [Header("States")]
        [SerializeField] private int points;

        private ShooterController[] cannons;
        private Destructible[] cities;

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
            DontDestroyOnLoad(this);
            difficulty = 1;
            
            crosshair.rectProvider = enemyManager.rectProvider = camera.GetComponent<CameraRectProvider>();

            cannons = cannonsContainer.GetComponentsInChildren<ShooterController>();
            cities = citiesContainer.GetComponentsInChildren<Destructible>();

            foreach (var cannon in cannons)
                cannon.Target = crosshair.transform;
        }

        private void Start()
        {
            RestartGame();
        }

        private void RestartGame()
        {
            enemyManager.SetDifficulty(difficulty);
            enemyManager.Restart();

            foreach (var cannon in cannons)
                cannon.gameObject.SetActive(true);

            foreach (var city in cities)
                city.gameObject.SetActive(true);
        }

        public void AddPoints(int pointsBase)
        {
            if (pointsBase < 0)
                return;

            points += difficulty * pointsBase;
            OnPointsChanged?.Invoke(points);
        }


    } 
}
