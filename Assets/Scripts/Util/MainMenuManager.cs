using System.Collections.Generic;
using Level.LevelInstantiations;
using Level.MusicalStrings;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Util
{
    public class MainMenuManager : MonoBehaviour
    {
        public Text UIScore;
        public static MainMenuManager mainMenuManager;

        
        void Awake()
        {
            SetTotalScoreUI();
            
            if (PlayerPrefs.GetInt("Level") == 0)
            {
                PlayerPrefs.SetInt("Level", 1);
            }
        }
        
        public void LoadLevel(int levelToLoad)
        {
            if (IsLevelAvailable(levelToLoad))
            {
                PlayerPrefs.SetInt("l" + levelToLoad, 0);
                PlayerPrefs.SetInt("CurrentLevel", levelToLoad);
                SceneManager.LoadScene("Level" + levelToLoad);
            }
            else
            {
                Debug.Log("Level has not been passed yet");
            }
        }

        private bool IsLevelAvailable(int levelToLoad)
        {
            Debug.Log("Max level in prefs: " + PlayerPrefs.GetInt("Level"));

            if (PlayerPrefs.GetInt("Score") >= LevelsPreferences.GetLevelScoresToLoad(levelToLoad))
            {
                Debug.Log("Current min level: " + levelToLoad);
                return true;
            }

            return false;
        }

        private void SetTotalScoreUI()
        {
            UIScore.text = "Total score: " + LevelsPreferences.GetEarnedLevelScores();
        }
    }
}