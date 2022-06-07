using System;

namespace FlappyBirdGame
{
    public class Pilot : IFlyable
    {
        private float _speed;
        public float Speed => _speed;
        public event Action TakeOffEvent;
        public Pilot(float speed)
        {
            _speed = speed;
        }

        public void Fly()
        {
            TakeOffEvent?.Invoke();
        }
    }
}
