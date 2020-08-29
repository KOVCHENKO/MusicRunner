using System;
using UnityEngine;
using UnityEngine.UI;

namespace Level.Menu
{
    public class MenuElementAppearance : MonoBehaviour
    {
        public Sprite levelIsBlockedSprite;
        public int levelToLoad;
        
        void Start () {
            if (PlayerPrefs.GetInt("Level") < levelToLoad)
            {
                gameObject.GetComponent<Image>().sprite = levelIsBlockedSprite;
            }
            
        }
    }
}