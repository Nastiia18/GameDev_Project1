using Code.Runtine.Gameplay.View.UI;
using Code.Runtine.infrastructure.Factories;
using UnityEngine;

namespace Code.Runtine.StaticData
{
    [CreateAssetMenu(fileName = "HudConfig", menuName = "StaticData/HudConfig")]
    public class HudConfig: ScriptableObject
    {
        public GameObject HudPrefab;
    }
}