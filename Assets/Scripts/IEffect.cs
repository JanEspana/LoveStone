using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IEffect
    {
        public void Effect();
        public void Effect(Fighter target);
        public void Effect(Fighter[] targets);
    }
}
