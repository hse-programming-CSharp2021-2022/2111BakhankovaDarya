using System;

namespace _01_b_6
{
    class Plant
    {
        public double growth { get; private set; }
        public double photosensitivity { get; private set; }
        public double frostresistance { get; private set; }
        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            this.growth = growth;
            if (photosensitivity >= 0 && photosensitivity <= 100)
                this.photosensitivity = photosensitivity;
            else
                throw new ArgumentException("Incorrect input");

            if (frostresistance >= 0 && frostresistance <= 100)
                this.frostresistance = frostresistance;
            else
                throw new ArgumentException("Incorrect input");
        }

        public override string ToString()
        { 
            return $"{growth} {photosensitivity} {frostresistance}";
        }
    }
    
    class Program
    {
        // здесь надо отсортировать по четности светочувствительности. 
        // проблема в том, что значения вещественные. Поэтому я сравниваю четность  
        // округленных значений, чтобы был виден результат.
        static int EvenFotosensivitySort(Plant x, Plant y)
        {
            if (Math.Round(x.photosensitivity) % 2 == 0 
                && Math.Round(y.photosensitivity) % 2 != 0)
                return 1;
            else if (x.frostresistance == y.frostresistance)
                return 0;
            else return -1;
        }
        static void Main(string[] args)
        {
            // получаем кол-во цветочков
            Console.WriteLine("number of plants: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            { 
                Console.Write("number of plants: ");
            }

            //создание и заполнение массива растеньицев
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                double growth = rnd.Next(25, 100) + Math.Round(rnd.NextDouble(), 3);
                double photosensitivity = rnd.Next(0, 100) + Math.Round(rnd.NextDouble(), 3);
                double frostresistance = rnd.Next(0, 80) + Math.Round(rnd.NextDouble(), 3);
                plants[i] = new Plant(growth, photosensitivity, frostresistance);
            }
            foreach (var plant in plants)
            {
                Console.WriteLine(plant);
            }

            // сортировка анонимным методом
            // по убыванию роста 
            Array.Sort(plants, delegate (Plant x, Plant y)
            {
                if (x.growth < y.growth)
                    return 1;
                else if (x.growth == y.growth)
                    return 0;
                else return -1;
            });
            Console.WriteLine();
            foreach (var plant in plants)
            {
                Console.WriteLine(plant);
            }

            // с помощью лямбды по возрастанию морозоустойчивости
            Array.Sort(plants, (x, y) => {
                if (x.frostresistance >= y.frostresistance)
                    return 1;
                else if (x.frostresistance == y.frostresistance)
                    return 0;
                else return -1;
                });
            Console.WriteLine();
            foreach (var plant in plants)
            {
                Console.WriteLine(plant);
            }

            // сортировка методом  
            Array.Sort(plants, (x, y) => EvenFotosensivitySort(x, y));
            Console.WriteLine();
            foreach (var plant in plants)
            {
                Console.WriteLine(plant);
            }
        }
    }
}
