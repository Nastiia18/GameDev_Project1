using System.Collections;
using Code.Extensions;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay.Logic
{
    internal sealed class ColectableSpawner : MonoBehaviour
    {
        [SerializeField]
        private int _spawnInterval =2;
        
        [SerializeField]
        private GameObject _collectable;

        [SerializeField] 
        private int _randomDeltaX = 2;
        
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