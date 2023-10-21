namespace Res
{
    internal class ICat : Animal, IAnimal
    {
        public int Height { get; set; }
        public ICat(string name, string color, int age, int height) : base(name, color, age) 
        {
            Height = height;
            Console.WriteLine($"Cat named {Name} has color in {Colour} ,aged {Convert.ToString(Age)} and height {Convert.ToString(Age)}");
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public string Cry() 
        {
            return "Meow!";
        }

    }
}
