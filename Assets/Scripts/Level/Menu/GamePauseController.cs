using UnityEngine;
using UnityEngine.SceneManagement;
using Util;

namespace Level.Menu
{
    public class GamePauseController : MonoBehaviour
    {
        public GameObject UIGamePaused;
        private AudioSource _audioSource;

        private GameObject _mainCamera;
        private GameObject _uiButtons;

        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _mainCamera = GameObject.FindWithTag("MainCamera");
            _uiButtons = GameObject.FindWithTag("Buttons");
        }
        
        public void SwitchPauseMenu()
        {
            if (UIGamePaused.active)
            {
                _audioSource.Play();
                UIGamePaused.SetActive(false);
                Time.timeScale = 1f; // this pauses the game action
                
                _mainCamera.SetActive(true);
                _uiButtons.SetActive(true);
            }
            else
            {
                _audioSource.Pause();
                UIGamePaused.SetActive(true);
                Time.timeScale = 0f; // this unpauses the game action
                
                _mainCamera.SetActive(false);
                _uiButtons.SetActive(false);
            } 
        }

        public void GoToLevel(int levelNumber)
        {
            GameManager.gm.LevelCompete(PlayerPrefs.GetInt("CurrentLevel"));
            MainMenuManager.mainMenuManager.LoadLevel(PlayerPrefs.GetInt("CurrentLevel"));
        }

        public void GoToMainMenu()
        {
            GameManager.gm.LevelCompete(PlayerPrefs.GetInt("CurrentLevel"));
            SceneManager.LoadScene("Menu");
        }
        
    }
}