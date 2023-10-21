using Res;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("Part 1: Please give dog a name, colour and age");
            Dog a = new Dog(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            a.Eat();

            Console.WriteLine("Part 1: Please give cat a name, colour and age");
            Cat b = new Cat(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            b.Eat();

            // Part 2
            Console.WriteLine("Part 2: Please give dog a name, colour, age, and height");
            IDog c = new IDog(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            c.Eat();
            c.Cry();

            Console.WriteLine("Part 2: Please give cat a name, colour, age, and height");
            ICat d = new ICat(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            d.Eat();
            d.Cry();

            List<Animal> animalList = new List<Animal>();
            animalList.Add(a);
            animalList.Add(b);
            animalList.Add(c);
            animalList.Add(d);
            Console.WriteLine("The List of animal's name you created are:");
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}