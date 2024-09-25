using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Token : Fighter
    {
        public int Position;
        public int CurrentDamage;
        public int CurrentHP;
        public CharacterSO Character;
        public void AssignUI()
        {
            GameManager.gameManager.TokenHP.text = HP.ToString();
            GameManager.gameManager.TokenDmg.text = Damage.ToString();
            GameManager.gameManager.TokenDesign.sprite = Character.Design;
        }
    }
}
