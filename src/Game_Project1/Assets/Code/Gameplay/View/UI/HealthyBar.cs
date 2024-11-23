using System;
using UnityEngine;
using UnityEngine.UI;
using Code.Gameplay.Logic;
using UnityEngine.Serialization;

namespace Code.Gameplay.View.UI
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