using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObjects/Entity", order = 1)]
    public class EntitySO : ScriptableObject
    {
        public string Name;
        public Sprite Design;
        public string Description;
    }
}
