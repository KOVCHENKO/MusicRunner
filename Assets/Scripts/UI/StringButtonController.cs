using Level.MusicalStrings;
using UnityEngine;

namespace UI
{
    public class StringButtonController : MonoBehaviour
    {
        public GameObject picker;

        // public void ChangeStringForPicker(int posNumber)
        public void ChangeStringForPicker(int posNumber)
        {
            picker = GameObject.FindGameObjectWithTag("Player");

            IMusicString musicString = MusicStringResolver.ResolveMusicString(posNumber);
            float pickerYCoord = musicString.YCoord + 0.6f;
            
            Debug.Log("IT IS A BUTTON COORDINATE:" + pickerYCoord);
            
            picker.transform.position = new Vector2(picker.transform.position.x, pickerYCoord);

            // switch (posNumber)
            // {
            //     // TODO: remake into object
            //     case 1:
            //         pickerYCoord = 4.2f;
            //         break;
            //     case 2:
            //         pickerYCoord = 3.2f;
            //         break;
            //     case 3:
            //         pickerYCoord = 2.2f;
            //         break;
            //     case 4:
            //         pickerYCoord = 1.2f;
            //         break;
            //     case 5:
            //         pickerYCoord = 0.2f;
            //         break;
            // }

            // picker.transform.position = new Vector2(picker.transform.position.x, pickerYCoord);
        }
    }
}
