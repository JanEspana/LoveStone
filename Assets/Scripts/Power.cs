using UnityEngine;

namespace Assets.Scripts
{
    public class Power : Invocable
    {
        public EntitySO Entity;
        public void HeroPower(){}
        public void AssignUI()
        {
            GameManager.gameManager.PowerMana.text = Mana.ToString();
            GameManager.gameManager.PowerDesign.sprite = Entity.Design;
        }
    }
}