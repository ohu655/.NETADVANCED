using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) 
            : base(name)
        {
        }

        public override int Power => base.Power = 80;

        public override string CastAbility()
        {
            return base.CastAbility() + " " + $"hit for {Power} damage";
        }
    }
}
