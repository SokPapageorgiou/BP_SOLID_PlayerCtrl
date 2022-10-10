using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SOLIDSolution.Scripts.PlayerController
{
    public class PlayerMovInput : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Vector2> onMovInputUpdates;

        private Vector2 _inputRecord;
        private Vector2 _currentInput = new ();
        private void Update()
        {
            _currentInput.x = Input.GetAxis("Horizontal"); 
            _currentInput.y = Input.GetAxis("Vertical");

            if (_currentInput != _inputRecord)
            {
                onMovInputUpdates.Invoke(_currentInput);
                _currentInput = _inputRecord;
            }
        }
    }
}
