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
        // public MainMenuManager mainMenuManager;
        
        void Start () {
            Debug.Log("Current score is " + PlayerPrefs.GetInt("Score"));
                
            if (PlayerPrefs.GetInt("Score") <= 
                LevelsPreferences.GetLevelScoresToLoad(levelToLoad))
            {
                gameObject.GetComponent<Image>().sprite = levelIsBlockedSprite;
            }
        }
    }
}