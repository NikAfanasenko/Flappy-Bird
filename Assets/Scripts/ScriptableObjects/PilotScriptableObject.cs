using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBirdGame
{
    [CreateAssetMenu(fileName = "Pilot", menuName = "Players/Pilot", order = 1)]
    public class PilotScriptableObject : ScriptableObject
    {
        [SerializeField] private float _speed;
        [SerializeField] private GameObject _prefab;
        public float Speed => _speed;
        public GameObject Prefab => _prefab;
        public void Deconstruct(out float speed,out GameObject prefab)
        {
            speed = _speed;
            prefab = _prefab;
        }
    }
}

