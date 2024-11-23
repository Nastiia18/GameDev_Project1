using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    public class PlayerInputX : MonoBehaviour
    {
        private const string AxisHorisontal = "Horizontal";

        [SerializeField] 
        private MoverX _mover;

        private void Update()
        {
           float input = Input.GetAxis(AxisHorisontal);
           Debug.Log(input);
           _mover.Move(input);
        }
    }
}
