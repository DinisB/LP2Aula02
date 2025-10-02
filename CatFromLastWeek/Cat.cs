using System;

namespace CatFromLastWeek
{
    public class Cat // classe
    {
        public static int MaxEnergy { get; set; } = 100; // propriedade e variável de classe
        public static int EnergyGainAfterSleep { get; set; } = 20; // propriedade e variável de classe
        public static int EnergyLossAfterPlay { get; set; } = 15; // propriedade e variável de classe
        public static int EnergyLossAfterMeow { get; set; } = 5; // propriedade e variável de classe

        private int energy; // variável de instância e de suporte
        private Feed feedStatus; // variável de instância e de suporte
        private Random random; // variável de instância
        private Feed[] possibleFeedStatus; // variável de instância
        private Mood[] possibleMoods; // variável de instância

        public string Name { get; } // propriedade de instância

        public int Energy // propriedade de instância
        {
            get => energy;
            private set
            {
                energy = value;
                if (energy < 0) energy = 0;
                else if (energy > MaxEnergy) energy = MaxEnergy;
            }
        }

        public Feed FeedStatus // propriedade de instância
        {
            get => feedStatus;
            private set
            {
                feedStatus = value;
                if (feedStatus < Feed.Starving)
                    feedStatus = Feed.Starving;
                else if (feedStatus > Feed.AboutToExplode)
                    feedStatus = Feed.AboutToExplode;
            }
        }

        public Mood MoodStatus  { get; private set; } // propriedade de instância

        private Cat() // construtor
        {
            random = new Random();
            possibleFeedStatus = (Feed[])Enum.GetValues(typeof(Feed));
            possibleMoods = (Mood[])Enum.GetValues(typeof(Mood));
        }

        public Cat(string name, int energy, Feed feedStatus, Mood moodStatus)
            : this() // construtor e exemplo de overloading
        {
            Name = name;
            Energy = energy;
            FeedStatus = feedStatus;
            MoodStatus = moodStatus;
        }

        public Cat(string name) : this() // construtor
        {
            Name = name;
            energy = random.Next(MaxEnergy + 1);
            FeedStatus =
                possibleFeedStatus[random.Next(possibleFeedStatus.Length)];
            MoodStatus = RandomMoods();
        }

        private Mood RandomMoods() // método
        {
            Mood moods = 0;
            int numMoods = random.Next(possibleMoods.Length) + 1;
            for (int i = 0; i < numMoods; i++)
            {
                moods |= possibleMoods[random.Next(possibleMoods.Length)];
            }
            return moods;
        }

        public void Eat() // método
        {
            FeedStatus++;
        }

        public void Sleep() // método
        {
            Energy += EnergyGainAfterSleep;
            FeedStatus--;
            MoodStatus = RandomMoods();
        }

        public void Play() // método
        {
            Energy -= EnergyLossAfterPlay;
            MoodStatus = Mood.Happy;
        }

        public void Meow() // método
        {
            Console.WriteLine($"{Name} says \"Meow\"!");
            Energy -= EnergyLossAfterMeow;
        }
    }
}
