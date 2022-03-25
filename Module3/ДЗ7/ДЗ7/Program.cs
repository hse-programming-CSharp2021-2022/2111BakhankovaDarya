using System;

namespace ДЗ7
{
    struct Person : IComparable
    {
        string name;
        string lastname;
        int age;
        public Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            if (age < 0)
                throw new ArgumentOutOfRangeException();
            else
                this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person person)
            {
                if (this.age > person.age)
                    return 1;
                else if (this.age == person.age)
                    return 0;
                else return -1;
            }
            else
                throw new Exception();
        }
        public override string ToString()
        {
            return $"{name} {lastname} : {age}y.o.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kol-vo elementov: ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            Person[] characters = new Person[n];
            Random rnd = new Random();
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = new Person(((char)rnd.Next(14, 256)).ToString(), 
                    ((char)rnd.Next(14, 256)).ToString(), rnd.Next(100));
                Console.WriteLine(characters[i]);
            }
            Console.WriteLine(new string('-', 20));
            Array.Sort(characters);
            foreach (var person in characters)
                Console.WriteLine(person);
        }
    }
}


