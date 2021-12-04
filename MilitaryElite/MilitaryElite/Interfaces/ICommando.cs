using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ICommando : ISpecializedSoldier
    {
        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName);
    }
}
