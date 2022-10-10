using UnityEngine;
using UnityEngine.Events;

namespace SOLIDSolution.Scripts.PlayerController
{
    public class ControlledPawnSetter : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D pawn;

        [SerializeField] public UnityEvent<Rigidbody2D> onPawnChanges;

        private void Awake() => ChangePawn(pawn);

        public void ChangePawn(Rigidbody2D newPawn) => onPawnChanges.Invoke(newPawn);
    }
}
