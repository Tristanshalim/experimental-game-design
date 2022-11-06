using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Tristan
{
    /// <summary>
    /// first program
    /// </summary>

    public class FirstScript : MonoBehaviour
    {
        #region
        private void Awake()
        {
            print("hai");
        }

        private void Start()
        {
            print("<color=yellow>this is main menu</color>");
        }
        private void Update()
        {
            print("<color=red>Update Event!</color>");
        }

        #endregion
    }

}