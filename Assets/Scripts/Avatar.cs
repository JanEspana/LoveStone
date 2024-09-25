using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Avatar : Fighter
    {
        public EntitySO Entity;
        public Power Power;
        public int Armor;

        public void Interact(){}
        public void AssignUI()
        {
            GameManager.gameManager.AvatarDesign.sprite = Entity.Design;
        }
    }
}