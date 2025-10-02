namespace ClassVsStruct
{
    public struct Player
    {
        public const int MaxHealth = 100;
        public const int MaxArmor = 100;
        public int Health { get; set; }
        public int Armor { get; set; }
        public Player(int health, int armor)
        {
            Health = health <= MaxHealth ? health : MaxHealth;
            Armor = armor <= MaxArmor ? armor : MaxArmor;
        }
    }
}