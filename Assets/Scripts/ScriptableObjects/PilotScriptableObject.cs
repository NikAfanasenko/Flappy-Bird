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
        [SerializeField] private Rigidbody _physics;
        public float Speed => _speed;
        public GameObject Prefab => _prefab;
        public Rigidbody Physics => _physics;
        public void Deconstruct(out float speed,out GameObject prefab, out Rigidbody physics)
        {
            speed = _speed;
            prefab = _prefab;
            physics = _physics;
        }
    }
}

