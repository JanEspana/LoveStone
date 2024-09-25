using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Card : Invocable
    {
        public int Rarity;
        public Avatar Property;
        public override void Play()
        {
            if (CurrentMana >= Mana)
            {
                CurrentMana -= Mana;
                Debug.Log("Card played");
            }
            else
            {
                Debug.Log("Not enough mana");
            }
        }
    }
}
