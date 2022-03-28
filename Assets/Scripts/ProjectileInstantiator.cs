using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MissileCommand {

    public class ProjectileInstantiator : MonoBehaviour
    {
        public static ProjectileInstantiator Instance { get; private set; }

        [Header("Prefabs")]
        [SerializeField] private GameObject rocketPrefab;
        [SerializeField] private GameObject explosionPrefab;

        private void Awake()
        {
            Instance = Singleton.MakeInstance(this, Instance);
        }

        public static void InstantiateExplosion(Vector3 position)
        {
            var obj = Instantiate(Instance.explosionPrefab);
            obj.transform.position = position;
        }

        public static void InstantiatePlayersRocket(Vector3 position, float speed, Vector3 finalPosition)
        {
            float angle = CalculateAngle(position, finalPosition);
            var obj = Instantiate(Instance.rocketPrefab, position, Quaternion.AngleAxis(angle, Vector3.forward));
            obj.GetComponent<ExplodeAtPosition>().ExplodePosition = finalPosition;
            
            var rocket = obj.GetComponent<ProjectileController>();
            rocket.Speed = speed;
            rocket.TargetPosition = finalPosition;
        }

        public static void InstantiateEnemyMissile(Vector3 position, float speed, Vector3 finalPosition)
        {
            var obj = Instantiate(Instance.rocketPrefab, position, Quaternion.identity);
            obj.GetComponent<ExplodeAtPosition>().ExplodePosition = finalPosition;

            var rocket = obj.GetComponent<ProjectileController>();
            rocket.Speed = speed;
            rocket.TargetPosition = finalPosition;
        }
        private static float CalculateAngle(Vector3 startPosition, Vector3 endPosition)
        {
            Vector3 direction = endPosition - startPosition;
            float angle = Vector3.SignedAngle(Vector3.up, direction, Vector3.forward);
            return angle;
        }

    }
}
