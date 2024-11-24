using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    public class Coin:MonoBehaviour, ICollectable
    {
        public bool IsCollected { get; private set; }
        public void Collect(Collector collector)
        {
            collector.GetComponent<Wallet>().AddCoint();
            Destroy(gameObject);
        }
    }
}