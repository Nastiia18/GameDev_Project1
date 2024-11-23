using System;
using UnityEngine;

namespace Code.Gameplay.Logic
{
    public sealed class Collector: MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.TryGetComponent(out ICollectable collectable))
                collectable.Collect(this);
        }
    }
}