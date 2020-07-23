using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Level
{
    public class CountdownController : MonoBehaviour
    {
        public int countdownTime;
        public Text countdownDisplay;
        private AudioSource _audioSource;

        private void Start()
        {
            // TODO: Transfer to more suitable place
            _audioSource = GetComponent<AudioSource>();
            StartCoroutine(CountdownToStart());
        }

        private IEnumerator CountdownToStart()
        {
            while (countdownTime > 0)
            {
                countdownDisplay.text = countdownTime.ToString();

                yield return new WaitForSeconds(1f);

                countdownTime--;
            }

            countdownDisplay.text = "GO!";
            
            LevelController.BeginGame();
            _audioSource.Play();
            
            yield return new WaitForSeconds(1f);
            
            countdownDisplay.gameObject.SetActive(false);
            
        }
    }
}