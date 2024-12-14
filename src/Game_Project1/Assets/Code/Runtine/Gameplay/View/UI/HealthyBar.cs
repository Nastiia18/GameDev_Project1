using Code.Runtine.Gameplay.Logic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Runtine.Gameplay.View.UI
{
    internal sealed class HealthyBar : MonoBehaviour
    {
        [SerializeField] 
        private Image _image;

        private Health _health;

        public void SetUp(Health health)
        {
            _health = health;
            _health.Changed += OnChanged;
        }
        

        private void OnDestroy()
        {
            _health.Changed -= OnChanged;
        }

        
        private void OnChanged()
        {
            _image.fillAmount = _health.CurrentHealth / _health.MaxHealth;
        }

      
    }
}