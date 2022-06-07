using System;
using UnityEngine;

namespace FlappyBirdGame
{
    public class PilotCreator : MonoBehaviour,IBuilder
    {
        private Pilot _pilot;
        private PilotView _pilotView;
        private float _speed;
        private GameObject _prefab;
        private GameObject _scenePrefab;
        private Rigidbody _physics;
        public void Reset(PilotScriptableObject pilotSO)
        {
            (_speed, _prefab, _physics) = pilotSO;
        }
        public void Init()
        {
            _scenePrefab = Instantiate(_prefab);
        }
        public void CreatePilot()
        {
            _pilot = new Pilot(_speed);
        }

        public void CreatePilotView()
        {
            _pilotView = new PilotView(_scenePrefab, _physics); 
        }

        public void Deconstruct(out IFlyable pilot, out PilotView pilotView)
        {
            pilot = _pilot;
            pilotView = _pilotView;
        }
        private void OnEnable()
        {
            _pilot.TakeOffEvent += _pilotView.TakeOff;
        }
        private void OnDisable()
        {
            _pilot.TakeOffEvent -= _pilotView.TakeOff;
        }

        public IFlyable Result()
        {
            return _pilot;
        }
    }
}
