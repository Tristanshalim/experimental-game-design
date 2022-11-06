using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("Bullet Prefab")]
        private GameObject prefabBullet;
        [SerializeField, Header("Bullet Spawn Point")]
        private Transform pointSpawn;
    }
}