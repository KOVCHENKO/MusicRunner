using UnityEngine;
using UnityEngine.SceneManagement;

namespace Util
{
    public class MainMenuManager : MonoBehaviour
    {
        public void LoadLevel(string levelToLoad)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}