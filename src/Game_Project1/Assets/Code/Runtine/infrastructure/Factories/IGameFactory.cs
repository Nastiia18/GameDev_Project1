using UnityEngine;

namespace Code.Runtine.infrastructure.Factories
{
    public interface IGameFactory
    {
        GameObject CreatePlayer(Vector3 position);
        GameObject CreateHud(GameObject player);
    }
}