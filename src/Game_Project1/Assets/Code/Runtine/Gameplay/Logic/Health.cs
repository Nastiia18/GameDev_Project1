using System;
using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    internal sealed class Health : MonoBehaviour
    {
        [SerializeField]
        private float _currentHealth;

        public float CurrentHealth => _currentHealth;
        public float MaxHealth { get; private set; }

        public event Action Changed;
        public event Action Death;
        private void Start()
        {
            MaxHealth = _currentHealth;
        }

        public void Substract(float healthToSubtract)
        {
           
            if(healthToSubtract <0)
                throw new InvalidOperationException($"Health to subtract must be positive but was {healthToSubtract}");
            _currentHealth -= healthToSubtract;
            Changed?.Invoke();

            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                Death?.Invoke();
            }
              
        }
    }
}