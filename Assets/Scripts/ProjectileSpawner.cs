using UnityEngine;

namespace MissileCommand 
{
    public class ProjectileSpawner : MonoBehaviour
    {
        public static ProjectileSpawner Instance { get; private set; }

        [Header("Prefabs")]
        [SerializeField] 
        private GameObject playerRocketPrefab;
        [SerializeField]
        private GameObject enemyRocketPrefab;
        [SerializeField]
        private GameObject explosionPrefab;

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
        }

        public static void InstantiateExplosion(Vector3 position, string tag = "Default")
        {
            var obj = Instantiate(Instance.explosionPrefab);
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

        private static GameObject InstantiateMissile(GameObject prefab, Vector3 position, float angle,
            float speed, Vector3 finalPosition, string tag, Transform parent)
        {
            var obj = Instantiate(prefab, position, Quaternion.AngleAxis(angle, Vector3.forward), parent);
            obj.tag = tag;

            var rocket = obj.GetComponent<ProjectileController>();
            rocket.Speed = speed;
            rocket.TargetPosition = finalPosition;

            return obj;
        }

        private static float CalculateAngle(Vector3 startPosition, Vector3 endPosition)
        {
            Vector3 direction = endPosition - startPosition;
            float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);
            return angle;
        }

    }
}
