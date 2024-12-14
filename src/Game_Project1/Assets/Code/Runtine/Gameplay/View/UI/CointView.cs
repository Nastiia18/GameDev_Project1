using System;
using Code.Runtine.Gameplay.Logic;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Runtine.Gameplay.View.UI
{
    public class CointView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinText;

        
        private Wallet _wallet;

        
        private void Update()
        {
           
            _coinText.text = _wallet.Balance.ToString();
        }

        public void SetUp(Wallet wallet)
        {
             _wallet = wallet;
        }
    }
}