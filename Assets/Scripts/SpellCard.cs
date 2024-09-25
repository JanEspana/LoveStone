using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class SpellCard : Card
    {
        public EntitySO Entity;
        public override void Play()
        {
            base.Play();
        }
        public void AssignUI()
        {
            GameManager.gameManager.SpellCardMana.text = Mana.ToString();
            GameManager.gameManager.SpellCardDesc.text = Entity.Description;
            GameManager.gameManager.SpellCardDesign.sprite = Entity.Design;
        }
    }
}
