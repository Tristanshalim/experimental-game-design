using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    ///  enemy fire system
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("Range"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //call the custom
            //SpawnBullet();

            //delay repeat call method (method name, delay time, interval)
            InvokeRepeating("SpawnBullet", 0, interval);
        }

    }
}
