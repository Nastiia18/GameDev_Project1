using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    public class Mace : MonoBehaviour, ICollectable
    {
        [SerializeField] 
        private float _healthToSubstract =10;

        public void Collect(Collector collector)
        {
           collector.GetComponent<Health>().Substract(_healthToSubstract);
        }
    }
}