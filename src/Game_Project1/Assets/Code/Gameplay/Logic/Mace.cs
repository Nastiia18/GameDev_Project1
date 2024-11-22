using UnityEngine;

namespace Code.Gameplay.Logic
{
    public class Mace : MonoBehaviour, ICollectable
    {
        public void Collect()
        {
            Debug.Log("Mace collected");
        }
    }
}