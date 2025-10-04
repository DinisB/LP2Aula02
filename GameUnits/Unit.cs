using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public int Health { get; set; }
        public abstract float Value { get; }
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move(Vector2 v)
        {
            int d = Math.Abs(v.X) + Math.Abs(v.Y);
            Console.WriteLine($"{this.GetType().Name} has moved {d} positions");
        }
    }
}