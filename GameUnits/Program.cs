using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit militar = new MilitaryUnit(2, 10, 50);
            Unit settler = new SettlerUnit(4, 8);

            militar.Move(new Vector2(2, -3));
            settler.Move(new Vector2(-1, 4));

            Console.WriteLine(militar);
            Console.WriteLine(settler);
        }
    }
}
