using System.Drawing;

namespace Res
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public Animal(string name, string color, int age) 
        {
            Name = name;
            Colour = color;
            Age = age;
            Console.WriteLine("Hello, Animal, World!");
        }

        public abstract void Eat();
        public override string ToString() 
        {
            return $"Dog named {Name} has color in {Colour} and aged {Convert.ToString(Age)}";
        }
    }
}
