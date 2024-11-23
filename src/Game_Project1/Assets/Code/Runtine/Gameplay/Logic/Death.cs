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
       
        [SerializeField]
        private Rigidbody2D _rigidbady;
        
        [SerializeField] 
        private Collider2D _collider;
        
        [SerializeField]
        private float _forceOnDeath;
        
        private IInputService _InputService;
        


        [Inject]
        private void Construct(IInputService inputService)
        {
            _InputService = inputService;
        }

        private void OnValidate()
        {
            _health ??= GetComponent<Health>();
            _rigidbady ??= GetComponent<Rigidbody2D>();
            _collider ??= GetComponent<Collider2D>();
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
            _rigidbady.AddForce(Vector2.up * _forceOnDeath, ForceMode2D.Impulse);
            _collider.enabled = false; 
        }
    }
}