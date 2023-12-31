using UnityEngine;

namespace MissileCommand 
{
    public class ProjectileSpawner : MonoBehaviour
    {
        public static ProjectileSpawner Instance { get; private set; }

        [Header("Prefabs")]
        [SerializeField] 
        private ProjectileController playerRocketPrefab;
        [SerializeField]
        private ProjectileController enemyRocketPrefab;
        [SerializeField]
        private ExplosionController explosionPrefab;
        [SerializeField]
        private Transform explosionsContainer;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }


        public static void InstantiateExplosion(Vector3 position, string tag = "Default")
        {
            var obj = Instantiate(Instance.explosionPrefab, Instance.explosionsContainer);
            obj.transform.position = position;
            obj.tag = tag;
        }

        public static void InstantiatePlayersRocket(Vector3 position, float speed, Vector3 finalPosition, Transform parent = null)
        {
            float angle = CalculateAngle(position, finalPosition);
            InstantiateMissile(Instance.playerRocketPrefab, position, angle, speed, finalPosition, GameManager.playerTag, parent);
        }

        public static void InstantiateEnemyMissile(Vector3 position, float speed, Vector3 finalPosition, Transform parent = null)
        {
            float angle = CalculateAngle(position, finalPosition);
            InstantiateMissile(Instance.enemyRocketPrefab, position, angle, speed, finalPosition, GameManager.enemyTag, parent);
        }

        private static ProjectileController InstantiateMissile(ProjectileController prefab, Vector3 position, float angle,
            float speed, Vector3 finalPosition, string tag, Transform parent)
        {
            var rocket = Instantiate(prefab, position, Quaternion.AngleAxis(angle, Vector3.forward), parent);
            rocket.tag = tag;
            rocket.Init(speed, finalPosition);
            return rocket;
        }

        private static float CalculateAngle(Vector3 startPosition, Vector3 endPosition)
        {
            Vector3 direction = endPosition - startPosition;
            float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);
            return angle;
        }

        private void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }
}
