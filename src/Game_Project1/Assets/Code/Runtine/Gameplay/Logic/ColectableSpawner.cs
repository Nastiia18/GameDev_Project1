using System.Collections;
using Code.Runtine.Extensions;
using UnityEngine;

namespace Code.Runtine.Gameplay.Logic
{
    public sealed class ColectableSpawner : MonoBehaviour
    {
        [SerializeField]
        private int _spawnInterval =2;
        
        [SerializeField]
        private GameObject _collectable;

        [SerializeField] 
        private float _randomDeltaX = 2;
        
        public float RandomDeltaX => _randomDeltaX;
        
        private  IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnInterval);
                SpawnEnemy();
            }
        }

        
        private void SpawnEnemy() => 
            Instantiate(_collectable, transform.position.SetX(GetRandonX()) , Quaternion.identity, gameObject.transform);

        private float GetRandonX() => 
            Random.Range(-_randomDeltaX , _randomDeltaX );
    }
}