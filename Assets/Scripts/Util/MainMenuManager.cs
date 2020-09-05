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

        public static MainMenuManager mainMenuManager
        {
            get;
            set;
        }

        public int currentLevel
        {
            get;
            set;
        } = 0;

        void Awake()
        {
            mainMenuManager = this;
            
            SetTotalScoreUI();
        }
        
        public void LoadLevel(int levelToLoad)
        {
            currentLevel = levelToLoad;
            
            if (IsLevelAvailable(levelToLoad))
            {
                PlayerPrefs.SetInt("l" + levelToLoad, 0);
                PlayerPrefs.SetInt("CurrentLevel", levelToLoad);
                SceneManager.LoadScene("Level1");
            }
            else
            {
                Debug.Log("Level has not been passed yet");
            }
        }

        private bool IsLevelAvailable(int levelToLoad)
        {
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