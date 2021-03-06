﻿using Picker;
using UnityEngine;
using Util;

namespace Level
{
    public class Finish : MonoBehaviour
    {
        public bool isFinished = false;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                WinLevel(other);
            }
        }

        private void WinLevel(Collider2D other)
        {
            GameManager.gm.AudioSource.Stop();
            other.gameObject.GetComponent<PickerController>().FreezeMotion();
            GameManager.gm.LevelCompete(PlayerPrefs.GetInt("CurrentLevel"), true);
        }
    }
}