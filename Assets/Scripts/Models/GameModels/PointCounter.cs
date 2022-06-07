
using System;

namespace FlappyBirdGame
{
    public class PointCounter : IRaisable
    {
        private const int INCREASE = 1;
        private int _currentScore;
        private int _maxScore;
        public int CurrentScore => _currentScore;
        public int MaxScore => _maxScore;
        public event Action RaiseScoreEvent;
        public PointCounter(int currentScore, int maxScore)
        {
            _currentScore = currentScore;
            _maxScore = maxScore;
        }

        public void Increment()
        {
            if (_currentScore < 0)
                throw new ArgumentException();
            _currentScore += INCREASE;
            if (_maxScore < _currentScore)
                _maxScore = _currentScore;
            RaiseScoreEvent?.Invoke();
        }
    }
}
