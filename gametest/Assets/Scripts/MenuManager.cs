using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace tristan
{
    /// <summary>
    /// mainmenu manager
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        ///<summary>
        /// start game
        /// </summary>
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("StartGame").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        ///<summary>
        ///start game
        /// </summary>
        private void StartGame()
        {
            SceneManager.LoadScene("Game Scene");
        }
    }
}
