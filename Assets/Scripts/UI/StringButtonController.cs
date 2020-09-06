using Level.MusicalStrings;
using UnityEngine;

namespace UI
{
    public class StringButtonController : MonoBehaviour
    {
        public GameObject picker;

        public void ChangeStringForPicker(int posNumber)
        {
            picker = GameObject.FindGameObjectWithTag("Player");

            IMusicString musicString = MusicStringResolver.ResolveMusicString(posNumber);
            float pickerYCoord = musicString.YCoord + 0.6f;
            picker.transform.position = new Vector2(picker.transform.position.x, pickerYCoord);
            
            // Change object transparency value
            for (int i = 1; i < 6; i++)
            {
                IMusicString musicStringForColorChange = MusicStringResolver.ResolveMusicString(i);
                GameObject musicStringObjTransparent = GameObject.Find(musicStringForColorChange.StringName);
                Debug.Log("Current string name " + musicStringObjTransparent.name);
                musicStringObjTransparent.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, (float) 0.5);
            }
            
            GameObject musicStringObj = GameObject.Find(musicString.StringName);
            musicStringObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 100);
        }
    }
}
