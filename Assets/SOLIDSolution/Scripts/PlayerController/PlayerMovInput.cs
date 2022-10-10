using UnityEngine;
using UnityEngine.Events;

namespace SOLIDSolution.Scripts.PlayerController
{
    public class PlayerMovInput : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Vector2> onMovInputUpdates;

        private Vector2 _inputRecord;
        private Vector2 _currentInput;
        private void Update()
        {
            _currentInput.x = Input.GetAxis("Horizontal"); 
            _currentInput.y = Input.GetAxis("Vertical");

            if (_currentInput != _inputRecord)
            {
                onMovInputUpdates.Invoke(_currentInput);
                _inputRecord = _currentInput;
            }
        }
    }
}
