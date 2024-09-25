using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Invocable : MonoBehaviour
    {
        public int Mana;
        public int CurrentMana;
        public virtual void Play()
        {
            if (CurrentMana >= Mana)
            {
                CurrentMana -= Mana;
                Debug.Log("Invocable played");
            }
            else
            {
                Debug.Log("Not enough mana");
            }
        }
    }
}