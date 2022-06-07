using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace FlappyBirdGame
{
    public class Pipe : MonoBehaviour
    {
        private const float DELTA = 0.5f;
        private Vector3 _position;
        private void Awake()
        {
            _position = GetComponent<Transform>().position;
        }
        private void Update()
        {
            _position = new Vector3(_position.x + DELTA,_position.y,_position.z);            
        }
    }
}
