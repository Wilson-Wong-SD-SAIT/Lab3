namespace Res
{
    internal class Cat : Animal
    {
        public Cat(string name, string color, int age) : base(name, color, age)
        {
            Console.WriteLine($"Cat named {Name} has color in {Colour} and aged {Convert.ToString(Age)}");
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
