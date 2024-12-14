using System;
using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    public sealed class Health : MonoBehaviour
    {

        public float CurrentHealth;
        public float MaxHealth { get; private set; }

        public event Action Changed;
        public event Action Death;
        private void Start()
        {
            MaxHealth = CurrentHealth;
        }

        public void Substract(float healthToSubtract)
        {
           
            if(healthToSubtract <0)
                throw new InvalidOperationException($"Health to subtract must be positive but was {healthToSubtract}");
            CurrentHealth -= healthToSubtract;
            Changed?.Invoke();

            if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                Death?.Invoke();
            }
              
        }
    }
}