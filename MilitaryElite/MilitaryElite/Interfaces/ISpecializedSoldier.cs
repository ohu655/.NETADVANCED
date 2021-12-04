using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ISpecializedSoldier : IPrivate
    {
        public Corps Corps { get; set; }
    }
}
