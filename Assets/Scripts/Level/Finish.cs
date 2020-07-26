using Picker;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Level
{
    public class Finish : MonoBehaviour
    {
        public bool isFinished = false;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Object.Destroy(this.gameObject);
                WinLevel(other);
            }
        }

        private void WinLevel(Collider2D other)
        {
            other.gameObject.GetComponent<PickerController>().FreezeMotion();
        }
    }
}