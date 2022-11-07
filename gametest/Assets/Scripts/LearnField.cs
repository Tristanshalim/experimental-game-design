using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace tristan
{
    public class LearnField : MonoBehaviour
    {
        //Field: store data
        //grammar:
        //Modifier Data Type Field Name;
        //Private, only accessible within this category, not displated
        private int lv;

        //Equal to the specified symbol: assign the result on the ritght side of the equal sign in the left
        //Public, All categories can access, display

        //integer int

        public int enemy = 5;

        //float
        public float speed = 3.5f;
        public float jump = 7.5f;

        //string
        public string namePlayer = "Little Knight";

        //boolean value bool
        public bool isPass = false;
        public bool hasWeapon = true;

       //Header
        [Header("Blood Volume")]
        public int hp = 999;

        //Hint
        [Tooltip("The time elapsed by the player")]
        public float time = 10.5f;

        //Value-specific range (min,max)
        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float walkSpeed = 3.5f;
        //Data types other than int and float are not supported
        [Range(1, 100)]
        public bool isOpen;

        //serialize fields : show private fields
        [SerializeField]
        private int countBomb = 7;
    }

}