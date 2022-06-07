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
        public void Reset(PilotScriptableObject pilotSO)
        {
            (_speed, _prefab) = pilotSO;
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
            _pilotView = new PilotView(_scenePrefab); 
        }

        public void Deconstruct(out IFlyable pilot, out PilotView pilotView)
        {
            pilot = _pilot;
            pilotView = _pilotView;
        }
        private void OnDisable()
        {
            _pilot.TakeOffEvent -= _pilotView.TakeOff;
        }

        public IFlyable Result()
        {
            _pilot.TakeOffEvent += _pilotView.TakeOff;
            return _pilot;
        }
    }
}
