using UnityEngine;

namespace SOLIDSolution.Scripts.PawnController.MovCtrl
{
    public interface IMovable
    {
        public void Move(Vector2 direction);
    }
}