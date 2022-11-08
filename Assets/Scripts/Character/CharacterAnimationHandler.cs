using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterAnimationHandler : MonoBehaviour
    {
        [SerializeField]
        private Character _character;
        
        [SerializeField]
        private Animator _animator;

        private void Update()
        {
            int horizontal = Mathf.RoundToInt(_character.Direction.x);
            int vertical = Mathf.RoundToInt(_character.Direction.y);
            _animator.SetBool("Walking Up", horizontal == 0 && vertical > 0);
            _animator.SetBool("Walking Right Up", horizontal > 0 && vertical > 0);
            _animator.SetBool("Walking Right", horizontal > 0 && vertical == 0);
            _animator.SetBool("Walking Right Down", horizontal > 0 && vertical < 0);
            _animator.SetBool("Walking Down", horizontal == 0 && vertical < 0);
            _animator.SetBool("Walking Left Down", horizontal < 0 && vertical < 0);
            _animator.SetBool("Walking Left", horizontal < 0 && vertical == 0);
            _animator.SetBool("Walking Left Up", horizontal < 0 && vertical > 0);
        }
    }
}