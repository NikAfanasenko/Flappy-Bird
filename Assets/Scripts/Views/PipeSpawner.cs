using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBirdGame
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _pipePrefab;
        [SerializeField] private int _poolCount;
        [SerializeField] private float _spawnTimeSeconds;
        private Queue<GameObject> _pipePool;

        private void Start()
        {
            for (int i = 0; i < _poolCount; i++)
            {
                var pipe = Instantiate(_pipePrefab);
                _pipePool.Enqueue(pipe);
                pipe.SetActive(false);
            }
        }
        private IEnumerator PipeSpawn()
        {
            if (_spawnTimeSeconds <= 0)
            {
                _spawnTimeSeconds = 1;
                throw new Exception("Время отрицательное!");
            }
            while (true)
            {
                yield return new WaitForSeconds(_spawnTimeSeconds);
                if (_pipePool.Count > 0)
                {
                    var pipe = _pipePool.Dequeue();
                    pipe.SetActive(true);
                   
                }

            }
        }
    }
}
