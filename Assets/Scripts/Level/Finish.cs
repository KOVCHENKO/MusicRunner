using Picker;
using UnityEngine;

namespace Level
{
    public class Finish : MonoBehaviour
    {
        public bool isFinished = false;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                WinLevel(other);
            }
        }

        private void WinLevel(Collider2D other)
        {
            other.gameObject.GetComponent<PickerController>().FreezeMotion();
        }
    }
}