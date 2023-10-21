namespace Res
{
    internal class Dog : Animal
    {
        public Dog(string name, string color, int age) : base ( name,  color,  age)
        {
            Console.WriteLine($"Dog named {Name} has color in {Colour} and aged {Convert.ToString(Age)}");
        }

        public override void Eat() 
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
