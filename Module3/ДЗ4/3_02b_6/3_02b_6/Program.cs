using System;

namespace _3_02b_6
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s)
        {
            Message = s;
        }
        public string Message { get; set; }
    }
    public class Creature
    {
        public string Name { get; private set; }
        public string Location { get; set; }
        public Creature(string name) => Name = name;
        public Creature() { }
        public virtual void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) { }
    }
    public class Wizard : Creature
    {
        public Wizard(string name) : base(name) { }
        public Wizard() : base() { }

        public new delegate void RingIsFoundEventHandler(object sender,
            RingIsFoundEventArgs a);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо!" +
                $"Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }
    public class Hobbit : Creature
    {
        public Hobbit(string name) : base(name) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }
    public class Human : Creature
    {
        public Human(string name) : base(name) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} " +
                $"позвал. Моя цель {e.Message}");
        }
    }
    public class Elf : Creature
    {
        public Elf(string name) : base(name) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звезды светят не так ярко как обычно." +
                $"Цветы увядают. Листья предсказывают идти в {e.Message}");
        }
    }
    public class Dwarf : Creature
    {
        public Dwarf(string name) : base(name) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы!" +
                $"Выдвигаемся в {e.Message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");
            Hobbit[] hobbits = new Hobbit[4];
            // TODO1
            string[] names = {"Фродо", "Сэм", "Пипин", "Мэрри"};
            for (int i = 0; i < 4; i++)
            {
                hobbits[i] = new Hobbit(names[i]);
                wizard.RaiseRingIsFoundEvent += hobbits[i].RingIsFoundEventHandler;
            }
            //
            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            Dwarf dwarf = new Dwarf("Гимли");
            Elf elf = new Elf("Леголас");
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human human in humans)
                wizard.RaiseRingIsFoundEvent += human.RingIsFoundEventHandler;

            wizard.SomeThisIsChangedInTheAir();
        }
    }
}
