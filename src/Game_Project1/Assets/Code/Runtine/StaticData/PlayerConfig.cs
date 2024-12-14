using UnityEngine;
namespace Code.Runtine.StaticData
{
    [CreateAssetMenu(fileName ="PlayerConfig", menuName ="Runtine/StaticData/PlayerConfig")]
    public class PlayerConfig: ScriptableObject
    {
        public GameObject PlayerPrefab;
        public float Starthealth;
    }
}