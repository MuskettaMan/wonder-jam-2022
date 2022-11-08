using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterController : MonoBehaviour
    {
        private IControllable _controllable;

        private void Awake()
        {
            _controllable = GetComponent<IControllable>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            _controllable.Move(new Vector2Int(Mathf.RoundToInt(horizontal), Mathf.RoundToInt(vertical)));
        }
    }
}