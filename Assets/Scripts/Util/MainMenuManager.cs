using UnityEngine;
using UnityEngine.SceneManagement;

namespace Util
{
    public class MainMenuManager : MonoBehaviour
    {
        void Awake() {
            if (PlayerPrefs.GetInt("Level") == 0)
            {
                PlayerPrefs.SetInt("Level", 1);
            }
        }
        
        public void LoadLevel(int levelToLoad)
        {

            if (IsLevelAvailable(levelToLoad))
            {
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
            
            if (PlayerPrefs.GetInt("Level") >= levelToLoad)
            {
                Debug.Log("Current min level: " + levelToLoad);
                return true;
            }

            return false;
        }
    }
}