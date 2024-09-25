using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class ElvenArcher : CharacterCard, IEffect
{
    // Start is called before the first frame update
    void Start()
    {
        AssignUI();
    }
    public void Effect() { }
    public void Effect(Fighter target) { }
    public void Effect(Fighter[] targets) { }
}
