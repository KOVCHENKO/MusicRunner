using UnityEngine;

namespace Util
{
    public class TimedObjectDestructor : MonoBehaviour
    {
        public float timeOut = 1.0f;
        public bool detachChildren = false;

        void Awake () {
            Invoke (nameof(DestroyNow), timeOut);
        }

        void DestroyNow ()
        {
            if (detachChildren) {
                transform.DetachChildren ();
            }

            Destroy(gameObject);
        }
    }
}