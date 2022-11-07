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
        #region annotation region
        //indent shortcut key: Tab
        //format file shortcut key: Ctrl + K D
        //single line comment

        /* Multi-line comment
         * Multi-line comment
         */

        // A a is not the same word
        #endregion

        #region event region
        // wakeup event: execute once when
        private void Awake()
        {
            //output(message)
            print("hai");
        }
        
        //Start event : execute after wakeup event
        private void Start()
        {
            print("<color=yellow>this is main menu</color>");
        }

        // special event: executed after start, the number of executions is 60fps
        private void Update()
        {
            print("<color=red>Update Event!</color>");
        }

        #endregion
    }

}