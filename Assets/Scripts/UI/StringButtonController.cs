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
        }
    }
}
