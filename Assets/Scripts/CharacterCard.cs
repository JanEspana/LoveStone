using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CharacterCard : Card
    {
        public CharacterSO Character;
        public void Invoke(Token token)
        {
        }
        public void AssignUI()
        {
            GameManager.gameManager.CharacterDesign.sprite = Character.Design;
            GameManager.gameManager.CharacterMana.text = Mana.ToString();
            GameManager.gameManager.CharacterHP.text = Character.HP.ToString();
            GameManager.gameManager.CharacterDmg.text = Character.Damage.ToString();
            GameManager.gameManager.CharacterDesc.text = Character.Description;
        }
    }
}
