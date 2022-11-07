using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// movesystem
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("Move Speed"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            //transform object, Transform element
            //Translate(x,y,z) displacement
            //Time.deltaTime the number time spent per frame
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
