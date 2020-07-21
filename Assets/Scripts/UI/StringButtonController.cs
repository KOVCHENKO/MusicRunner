using UnityEngine;

namespace UI
{
    public class StringButtonController : MonoBehaviour
    {
        public GameObject picker;

        public void changeStringForPicker(int posNumber)
        {
            picker = GameObject.FindGameObjectWithTag("Player");
        
            float pickerYCoord = 0f;
            switch (posNumber)
            {
                case 1:
                    pickerYCoord = 4.2f;
                    break;
                case 2:
                    pickerYCoord = 3.2f;
                    break;
                case 3:
                    pickerYCoord = 2.2f;
                    break;
                case 4:
                    pickerYCoord = 1.2f;
                    break;
                case 5:
                    pickerYCoord = 0.2f;
                    break;
            }
        
            picker.transform.position = new Vector2(picker.transform.position.x, pickerYCoord);
        }
    }
}
