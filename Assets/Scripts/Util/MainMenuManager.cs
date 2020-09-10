using System.Collections.Generic;
using Level.LevelInstantiations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Util
{
    public class MainMenuManager : MonoBehaviour
    {
        public Text UIScore;
        public int currentLevelBunch = 1;
        private Dictionary<int, GameObject> _levelBunches;

        private GameObject _forward;
        private GameObject _backward;

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
            InitializeBunchOfLevels();
            mainMenuManager = this;
            
            SetTotalScoreUI();

            _forward = GameObject.Find("Forward");
            _backward = GameObject.Find("Backward");
        }

        void Update()
        {
            UpdateBunchOfLevels();
            UpdateLevelBunchNavigationButtons();
        }
        

        private void InitializeBunchOfLevels()
        {
            _levelBunches = new Dictionary<int, GameObject>
            {
                {1, GameObject.Find("FirstBunch")},
                {2, GameObject.Find("SecondBunch")},
                {3, GameObject.Find("ThirdBunch")}
            };
        }

        private void UpdateBunchOfLevels()
        {
            foreach(var levelBunch in _levelBunches)
            {
                GameObject levelBunchObj = levelBunch.Value;
                levelBunchObj.SetActive(levelBunch.Key == currentLevelBunch);
            }
        }

        private void UpdateLevelBunchNavigationButtons()
        {
            _backward.SetActive(currentLevelBunch != 1);
            _forward.SetActive(currentLevelBunch != 3);
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

        public void ChangeLevelsBunch(string direction)
        {
            switch (direction)
            {
                case "forward":
                    Debug.Log("Going forward");
                    currentLevelBunch++;
                    break;
                case "backward":
                    Debug.Log("Going backward");
                    currentLevelBunch--;
                    break;
            }
        }
    }
}