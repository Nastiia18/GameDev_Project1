using System;
using Code.Runtine.infrastructure.Services.Input;
using UnityEngine;
using Zenject;

namespace Code.Runtine.Gameplay.Logic
{
    public class Death:MonoBehaviour
    {
        [SerializeField]
        private Health _health;

        private IInputService _InputService;
        
        [Inject]
        private void Construct(IInputService inputService)
        {
            _InputService = inputService;
        }

        private void Awake()
        {
            _health.Death += OnDeath;
        }

        private void OnDestroy()
        {
            _health.Death -= OnDeath;
        }

        private void OnDeath()
        {
            _InputService.Disable();
        }
    }
}