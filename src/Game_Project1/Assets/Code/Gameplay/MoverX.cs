using UnityEngine;

namespace Code.Gameplay
{
    internal class MoverX : MonoBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody;
        [SerializeField] 
        private float _speed;

        public float Speed => _rigidbody.velocity.x;

        public void Move(float input)
        {
            _rigidbody.velocity = new Vector2(input * _speed, _rigidbody.velocity.y);
        }
    }
}