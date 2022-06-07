using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBirdGame
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private List<PilotScriptableObject> _pilots;
        [SerializeField] private PilotCreator _pilotCreator;
        private KindOfPilot _kindOfPilot;
        private IFlyable _pilot;
        private void Awake()
        {
            _kindOfPilot = KindOfPilot.Bird;
            _pilotCreator.Reset(_pilots[(int)_kindOfPilot]);
            _pilotCreator.Init();
            _pilotCreator.CreatePilot();
            _pilotCreator.CreatePilotView();
            _pilot = _pilotCreator.Result();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
                _pilot.Fly();
        }
    }
}

