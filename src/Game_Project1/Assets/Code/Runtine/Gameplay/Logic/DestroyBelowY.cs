using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    internal sealed class DestroyBelowY: MonoBehaviour
    {
        [SerializeField]
        private float _y;

        private void Update()
        {
           if( transform.position.y < _y)
               Destroy(gameObject);
        }
    }
}