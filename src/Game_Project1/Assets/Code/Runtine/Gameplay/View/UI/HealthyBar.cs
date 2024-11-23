using Code.Runtine.Gameplay.Logic;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Runtine.Gameplay.View.UI
{
    internal sealed class HealthyBar : MonoBehaviour
    {
        [SerializeField] 
        private Image _image;

        [SerializeField] 
        private Health _health;

        private void Update()
        {
            _image.fillAmount = _health.CurrentHealth / _health.MaxHealth;
        }
    }
}