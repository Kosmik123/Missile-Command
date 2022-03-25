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


        public static void InstantiateRocket(Vector3 position, Quaternion rotation, float speed, Vector3 finalPosition)
        {
            var obj = Instantiate(Instance.rocketPrefab, position, rotation);
            obj.GetComponent<ExplodeAtPosition>().ExplodePosition = finalPosition;
            
            var rocket = obj.GetComponent<ProjectileController>();
            rocket.Speed = speed;
            rocket.TargetPosition = finalPosition;
        }
    }
}
