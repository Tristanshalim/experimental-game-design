using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace tristan
{
    public class LearnField : MonoBehaviour
    {
        private int lv;

        public int enemy = 5;

        public float speed = 3.5f;
        public float jump = 7.5f;

        public string namePlayer = "Little Knight";

        public bool isPass = false;
        public bool hasWeapon = true;

        [Header("Blood Volume")]
        public int hp = 999;
        [Tooltip("The time elapsed by the player")]
        public float time = 10.5f;

        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float walkSpeed = 3.5f;
        [Range(1, 100)]
        public bool isOpen;

        [SerializeField]
        private int countBomb = 7;
    }

}