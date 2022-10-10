using System;
using UnityEngine;

namespace SOLIDSolution.Scripts.PlayerController
{
    public class PawnMover : MonoBehaviour
    {
        private Rigidbody2D _pawn;
        private IMovable _movable;
        private Vector2 _direction;

        private void FixedUpdate()
        {
            throw new NotImplementedException();
        }

        public void UpdatePawn(Rigidbody2D newPawn)
        {
            _pawn = newPawn;
            _movable = _pawn.GetComponent(typeof(IMovable)) as IMovable;
        }

        public void UpdateDirection(Vector2 newDirection) => _direction = newDirection;

    }
}
