using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Value => 5;
        public SettlerUnit(int movement, int health)
            : base(movement, health)
        {
        }

        public void Settle()
        {
            
        }
    }
}