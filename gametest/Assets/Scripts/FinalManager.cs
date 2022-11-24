using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace tristan
{
    /// <summary>
    /// final manager
    /// </summary>

    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// GameOverMenu
        /// </summary>
        private CanvasGroup groupfinal;
        /// <summary>
        /// gameover
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// RestartBTN
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupfinal = GameObject.Find("GameOverMenu").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("gameover").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("RestartBTN").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// gameover
        /// </summary>
        /// <param name="title">game over</param>
        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// Fadein
        /// </summary>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupfinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupfinal.interactable = true;
            groupfinal.blocksRaycasts = true;
        }


        ///<summary>
        ///new game
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

}
