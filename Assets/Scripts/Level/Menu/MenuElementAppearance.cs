using Level.LevelInstantiations;
using UnityEngine;
using UnityEngine.UI;
using Util;

namespace Level.Menu
{
    public class MenuElementAppearance : MonoBehaviour
    {
        public Sprite levelIsBlockedSprite;
        public int levelToLoad;
        
        void Start () {
            Debug.Log("Current score is " + PlayerPrefs.GetInt("Score"));
            
            IsBlocked();
            IsleftToOpen();
        }

        private void IsleftToOpen()
        {
            // Object name: ScoreLeft
            GameObject ChildGameObject = transform.GetChild(0).gameObject;
            Text thisIsText = ChildGameObject.GetComponent<Text>();

            int necessaryScore = (LevelsPreferences.GetEarnedLevelScores() -
                                  LevelsPreferences.GetLevelScoresToLoad(levelToLoad)) * -1;

            if (LevelsPreferences.GetEarnedLevelScores() <= 
                LevelsPreferences.GetLevelScoresToLoad(levelToLoad))
            {
                thisIsText.text = necessaryScore.ToString() + " more";
            }
            else
            {
                thisIsText.text = PlayerPrefManager.GetScore(levelToLoad).ToString() + " earned";
            }
        }

        private void IsBlocked() {
            if (LevelsPreferences.GetEarnedLevelScores() <= 
                LevelsPreferences.GetLevelScoresToLoad(levelToLoad))
            {
                gameObject.GetComponent<Image>().sprite = levelIsBlockedSprite;
                // Object name: LevelNumber
                transform.GetChild(1).gameObject.GetComponent<Text>().text = "";
            }
        }
    }
    
  
}