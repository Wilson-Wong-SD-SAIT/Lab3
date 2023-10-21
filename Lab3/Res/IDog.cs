namespace Res
{
    internal class IDog : Animal, IAnimal
    {
        public int Height { get; set; }
        public IDog(string name, string color, int age, int height) : base(name, color, age)
        {
            Height = height;
            Console.WriteLine($"Dog named {Name} has color in {Colour} ,aged {Convert.ToString(Age)} and height {Convert.ToString(Age)}");
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public string Cry()
        {
            return "Woof!";
        }

    }
}
