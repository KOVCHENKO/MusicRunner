﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Level
{
    public class CountdownController : MonoBehaviour
    {
        public int countdownTime;
        public Text countdownDisplay;

        private void Start()
        {
            StartCoroutine(CountdownToStart());
        }

        IEnumerator CountdownToStart()
        {
            while (countdownTime > 0)
            {
                countdownDisplay.text = countdownTime.ToString();

                yield return new WaitForSeconds(1f);

                countdownTime--;
            }

            countdownDisplay.text = "GO!";
            
            LevelController.BeginGame();
            
            yield return new WaitForSeconds(1f);
            
            countdownDisplay.gameObject.SetActive(false);
        }
    }
}