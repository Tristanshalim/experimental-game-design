using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// player fire system
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        // detect player input behavior: keyboard, mouse, touch, joystick
        private void Update()
        {
            // generate bullet if player press space key
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    } 
}
