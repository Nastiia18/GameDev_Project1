using UnityEngine;

namespace Code.Gameplay.Logic
{
    internal sealed class EnemiesSpawner : MonoBehaviour
    {
        [SerializeField]
        private int _spawnInterval =2;
        
        [SerializeField]
        private GameObject _enemy;

        private float _timer;
        
        private void Start()
        {
            _timer = _spawnInterval;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;

            if (_timer <= 0)
            {
                SpawnEnemy();
                _timer = _spawnInterval;
            }
               
        }

        private void SpawnEnemy()
        {
            Instantiate(_enemy, gameObject.transform);
        }
    }
}