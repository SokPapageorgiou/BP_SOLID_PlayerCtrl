using UnityEngine;
using UnityEngine.Events;

namespace SOLIDSolution.Scripts.PlayerInput
{
    public class PlayerMovInput : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Vector2> onMovInputUpdates;

        private Vector2 _inputRecord;
        private Vector2 _currentInput;
        private void Update()
        {
            _currentInput.x = UpdateHorizontal(); 
            _currentInput.y = UpdateVertical();

            if (_currentInput != _inputRecord)
            {
                onMovInputUpdates.Invoke(_currentInput);
                _inputRecord = _currentInput;
            }
        }

        private sbyte UpdateHorizontal()
        {
            if (Input.GetKey(KeyCode.A)) return -1;
            if (Input.GetKey(KeyCode.D)) return 1;
            return 0;
        }

        private sbyte UpdateVertical()
        {
            if (Input.GetKey(KeyCode.W)) return 1;
            if (Input.GetKey(KeyCode.S)) return -1;
            return 0;
        }
    }
}
