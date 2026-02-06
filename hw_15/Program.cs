namespace hw_15
{
    using System;
    using System.Collections.Generic;

    abstract class Continent
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class Africa : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class NorthAmerica : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    abstract class Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; } = true;
        public abstract void EatGrass();
    }

    class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            Weight = 100;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }

    class Bison : Herbivore
    {
        public Bison()
        {
            Weight = 120;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }

    abstract class Carnivore
    {
        public int Power { get; set; }
        public abstract void Eat(Herbivore herbivore);
    }

    class Lion : Carnivore
    {
        public Lion()
        {
            Power = 110;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life) return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
            }
            else
            {
                Power -= 10;
            }
        }
    }

    class Wolf : Carnivore
    {
        public Wolf()
        {
            Power = 105;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life) return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
            }
            else
            {
                Power -= 10;
            }
        }
    }

    class AnimalWorld
    {
        private List<Herbivore> herbivores = new List<Herbivore>();
        private List<Carnivore> carnivores = new List<Carnivore>();

        public AnimalWorld(Continent continent, int count)
        {
            for (int i = 0; i < count; i++)
            {
                herbivores.Add(continent.CreateHerbivore());
                carnivores.Add(continent.CreateCarnivore());
            }
        }

        public void MealsHerbivores()
        {
            foreach (var h in herbivores)
            {
                if (h.Life)
                    h.EatGrass();
            }
        }

        public void NutritionCarnivores()
        {
            for (int i = 0; i < carnivores.Count; i++)
            {
                carnivores[i].Eat(herbivores[i]);
            }
        }

        public void ShowState()
        {
            for (int i = 0; i < herbivores.Count; i++)
            {
                Console.WriteLine($"Herbivore {i}: Weight={herbivores[i].Weight}, Life={herbivores[i].Life}");
            }

            for (int i = 0; i < carnivores.Count; i++)
            {
                Console.WriteLine($"Carnivore {i}: Power={carnivores[i].Power}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld africa = new AnimalWorld(new Africa(), 3);
            africa.MealsHerbivores();
            africa.NutritionCarnivores();
            africa.ShowState();

            Console.WriteLine();

            AnimalWorld america = new AnimalWorld(new NorthAmerica(), 3);
            america.MealsHerbivores();
            america.NutritionCarnivores();
            america.ShowState();
        }
    }
}
