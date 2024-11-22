using System.Collections;
using UnityEngine;

namespace Code.Gameplay.Logic
{
    internal sealed class EnemiesSpawner : MonoBehaviour
    {
        [SerializeField]
        private int _spawnInterval =2;
        
        [SerializeField]
        private GameObject _enemy;

        
        
        private  IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnInterval);
                SpawnEnemy();
            }
        }

        
        private void SpawnEnemy()
        {
            Instantiate(_enemy, gameObject.transform);
        }
    }
}