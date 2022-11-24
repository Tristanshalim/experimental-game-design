using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// sound manager
    /// </summary>
    /// execute when applying the program: request element(type(element))- 
    /// the first time the script is applied to the object, the element will be added
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            // this such a kind of
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        ///<summary>
        ///play sound effect
        /// </summary>
        /// <param name="sound"> sound effect </param>
        /// <param name="rangeVolume">range volume</param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}
