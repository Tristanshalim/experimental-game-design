using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// player end management: death or clearance
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // executed once when deleted
        private void OnDestroy()
        {
            //died
            FinalManager.instance.GameOver("Game Over!");
        }

        // executed once when the endpoint is trigger
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Clear
            FinalManager.instance.GameOver("Round Clear");
        }
    }
}
