using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// Damage system
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("Target that will cause damage")]
        private string nameTarget;
        [SerializeField, Header("Exploding Prefab")]
        private GameObject prefabExplosion;
        [Header("hit and explosion sound effect")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //collision start event once
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("collision:" + collision.gameObject);

            // if the name of the object contain enemy plane then explode
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                //destroy delete
                //gameobject object
                Destroy(gameObject);
            }
        }

        //collision exit event once
        private void OnCollisionExit(Collision collision)
        {
            
        }

        //collision continuation event
        private void OnCollisionStay(Collision collision)
        {
            
        }
    }
}
