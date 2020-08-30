using UnityEngine;
using UnityEngine.SceneManagement;

namespace Level.Menu
{
    public class GamePauseController : MonoBehaviour
    {
        public GameObject UIGamePaused;
        private AudioSource _audioSource;

        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }
        
        public void SwitchPauseMenu()
        {
            if (UIGamePaused.active)
            {
                _audioSource.Play();
                UIGamePaused.SetActive(false);
                Time.timeScale = 1f; // this pauses the game action
            }
            else
            {
                _audioSource.Pause();
                UIGamePaused.SetActive(true);
                Time.timeScale = 0f; // this unpauses the game action (ie. back to normal)
            } 
        }

        public void GoToLevel(int levelNumber)
        {
            SceneManager.LoadScene("Level" + levelNumber);
        }

        public void GoToMainMenu()
        {
            SceneManager.LoadScene("Menu");
        }
        
    }
}