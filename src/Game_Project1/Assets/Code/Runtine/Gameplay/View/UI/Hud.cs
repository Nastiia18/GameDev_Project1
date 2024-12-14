using Code.Runtine.Gameplay.Logic;
using UnityEngine;

namespace Code.Runtine.Gameplay.View.UI
{
    public class Hud: MonoBehaviour
    {
        [SerializeField]
        private CointView _coinView;
        
        [SerializeField]
        private HealthyBar _healthBar;
        
        public void SetUp(Wallet  wallet, Health health)
        {
            _coinView.SetUp(wallet);
            _healthBar.SetUp(health);
        }
    }               
}