﻿using System.Runtime.CompilerServices;
using UnityEngine;

namespace MissileCommand
{
    public class ExplodeAtPosition : MonoBehaviour
    {
        public void Explode()
        {
            ProjectileSpawner.InstantiateExplosion(transform.position, gameObject.tag);
        }
    }
}
