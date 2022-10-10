using SOLIDSolution.Scripts.PawnController.MovCtrl;
using UnityEngine;

namespace SOLIDSolution.Scripts.PawnController.PawnComponents
{
    public class Movement : MonoBehaviour, IMovable
    {
        [SerializeField] private float speed;

        private Rigidbody2D _rigidbody2D;

        private void Awake() => _rigidbody2D = GetComponent<Rigidbody2D>();

        public void Move(Vector2 direction) => _rigidbody2D.velocity = direction.normalized * speed;
    }
}
