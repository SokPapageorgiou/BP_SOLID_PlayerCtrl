using UnityEngine;

namespace SOLIDSolution.Scripts.PlayerController
{
    public interface IMovable
    {
        public void Move(Vector2 direction);
    }
}