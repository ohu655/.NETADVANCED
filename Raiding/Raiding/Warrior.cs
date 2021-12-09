﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {

        public Warrior(string name) 
            : base(name)
        {
        }

        public override int Power => base.Power = 100;

        public override string CastAbility()
        {
            return base.CastAbility() +" " + $"hit for {Power} damage";
        }
    }
}
