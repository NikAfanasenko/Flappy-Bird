using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBirdGame
{
    sealed public class Wallet : IRaisable
    {
        private const int INCREASE = 1;
        private int _quantityOfCoins;
        public int QuantityOfCoins => _quantityOfCoins;

        public event Action RaiseCoinsEvent;
        public Wallet(int quantityOfCoins)
        {
            _quantityOfCoins = quantityOfCoins;
        }

        public void Increment()
        {
            if (_quantityOfCoins < 0)
                throw new ArgumentException();
            _quantityOfCoins += INCREASE;
            RaiseCoinsEvent?.Invoke();
        }
    }
}

