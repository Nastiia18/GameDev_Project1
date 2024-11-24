using System;
using Code.Runtine.Gameplay.Logic;
using TMPro;
using UnityEngine;

namespace Code.Runtine.Gameplay.View.UI
{
    public class CointView:MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _coinText;
        [SerializeField]
        private Wallet _walle;


        private void Update()
        {
            _coinText.text = _walle.Balance.ToString();
        }
    }
}