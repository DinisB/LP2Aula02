using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca !!
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override float Value
        {
            get => AttackPower + XP;
        }
        public void Attack(Unit u) { /* ... */ }
        public override string ToString() =>
            base.ToString() + $", AP={AttackPower}, XP={XP}";

        public MilitaryUnit(int mov, int health, int attackPower)
            : base(mov, health) // Unit(int movement, int health)
        {
            AttackPower = attackPower;
            XP = 0;
        }
    }
}