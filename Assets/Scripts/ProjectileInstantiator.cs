using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
