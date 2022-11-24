using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// destroy object
    /// </summary>
    /// 
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("Destroyed Duration"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject the game object of this script
            //destroyed(object, destroyed duration)
            Destroy(gameObject, destroyTime);
        }

        //visible event: execute once when the rendering component appears in scene or game
        private void OnBecameVisible()
        {

        }

        //invisible event: execute once when the rendering component disappears in scene or game
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
