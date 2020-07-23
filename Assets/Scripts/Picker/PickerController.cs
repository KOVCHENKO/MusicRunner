using UnityEngine;

namespace Picker
{
    public class PickerController : MonoBehaviour
    {
        [Range(0.0f, 10.0f)]
        public float moveSpeed = 7f;

        public bool constantMoving = false;
    
        // Preferences to components of gameObject
        private Transform _transform;
        private Rigidbody2D _rigidbody2D;
        private Animator _animator;
    
        // Player position
        private float _vx;
        private float _vy;
    
        bool _isMoving = false;
    
        private void Awake()
        {
            // get a reference to the components we are going to be changing and store a reference for efficiency purposes
            _transform = GetComponent<Transform> ();
		
            _rigidbody2D = GetComponent<Rigidbody2D> ();

            if (_rigidbody2D == null)
            {
                Debug.LogError("RigidBody2D component missing from this GameObject");
            }
        }

        void Update()
        {
            // determine horizontal velocity change based on the horizontal input
            _vx = Input.GetAxisRaw ("Horizontal");
        
            // get the current vertical velocity from the rigidbody component
            _vy = _rigidbody2D.velocity.y;
        
            // Change the actual velocity on the rigidbody
            _rigidbody2D.velocity = new Vector2(_vx * moveSpeed, _vy);
        
            if (constantMoving)
            {
                _rigidbody2D.velocity = new Vector2(moveSpeed, 0);
            }
        }
    }
}
