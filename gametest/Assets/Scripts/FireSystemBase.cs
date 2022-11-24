using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// Launch System Substrate Category
    /// Generate Bullets
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("Bullet Prefab")]
        private GameObject prefabBullet;
        [SerializeField, Header("Bullet Spawn Point")]
        private Transform pointSpawn;
        [SerializeField, Header("Sound effect")]
        private AudioClip soundFire;

        //own method
        //generate bullets
        // protected protection level: allow subclass access
        protected void SpawnBullet()
        {
            //instantiate(objext,coordinates,angle)
            //generate a bullet prefab, the angle and coordinates are the same as the bullet spawn point
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}