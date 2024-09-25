using UnityEngine;

namespace Assets.Scripts
{
    public class Fighter : MonoBehaviour
    {
        public int Damage;
        public int HP;
        public int Team;

        public void Attack(Fighter target)
        {
            target.HP -= Damage;
        }
    }
}
