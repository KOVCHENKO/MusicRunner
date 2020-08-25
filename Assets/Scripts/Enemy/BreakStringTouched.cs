using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Enemy
{
    public class BreakStringTouched : MonoBehaviour
    {
        Animator _animator;
        bool _isTouched = false;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            if (_animator == null)
            {
                Debug.LogError("Animator component missing in this GameObject");
            }

        }

        void Update()
        {
            _animator.SetBool("isTouched", _isTouched);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Player touched string break");
                _isTouched = true;
            }
        }
    }
}