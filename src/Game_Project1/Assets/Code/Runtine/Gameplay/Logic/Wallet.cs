using UnityEngine;
using Zenject;

namespace Code.Runtine.Gameplay.Logic
{
    public class Wallet:MonoBehaviour
    {
        [SerializeField]
        private int _balance;

        public void AddCoint() => _balance ++;
    }
}