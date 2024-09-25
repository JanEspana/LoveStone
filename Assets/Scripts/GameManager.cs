using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Text CharacterMana, CharacterDmg, CharacterHP, CharacterDesc, TokenDmg, TokenHP,
        PowerMana, SpellCardMana, SpellCardDesc;
    public Image CharacterDesign, AvatarDesign, TokenDesign, PowerDesign, SpellCardDesign;
    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else if (gameManager != this)
        {
            Destroy(gameObject);
        }
    }
}
