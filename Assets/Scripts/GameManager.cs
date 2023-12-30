using UnityEngine;


namespace MissileCommand
{
    public class GameManager : MonoBehaviour
    {
        public static string enemyTag = "Enemy";
        public static string playerTag = "Player";

        [Header("To Link")]
        [SerializeField] 
        private new Camera camera;
        [SerializeField]
        private CrosshairController crosshair;
        [SerializeField]
        private EnemyManager enemyManager;
        [SerializeField] 
        private Transform citiesContainer;
        [SerializeField] 
        private Transform cannonsContainer;
        [SerializeField]
        private PointsData pointsData;

        [Header("Settings")]
        [SerializeField]
        private int baseRocketCount;
        [SerializeField]
        private Material[] allSkyboxes;
        
        [Header("Properties")]
        [SerializeField]
        private int difficulty;

        [Header("States")]
        [SerializeField] 
        private int points;

        private ShooterController[] cannons;
        private Destructible[] cities;

        private void Awake()
        {
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
            RandomizeSkybox();

            enemyManager.SetDifficulty(difficulty);
            enemyManager.Restart();

            foreach (var cannon in cannons)
                cannon.gameObject.SetActive(true);

            foreach (var city in cities)
                city.gameObject.SetActive(true);
        }

        private void RandomizeSkybox()
        {
            int randomIndex = Random.Range(0, allSkyboxes.Length);
            RenderSettings.skybox = allSkyboxes[randomIndex];
            DynamicGI.UpdateEnvironment();
        }
    } 
}
