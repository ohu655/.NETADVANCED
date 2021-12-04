using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer : ISpecializedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}
