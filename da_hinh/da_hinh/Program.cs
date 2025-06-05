// See https://aka.ms/new-console-template for more information
namespace oop
{
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }
}
namespace oop
{
    class Dog: Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Dog speaks go go");
        }
    }
}
namespace oop
{
    class Cat: Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Cat speaks meo meo");
        }
        
    }
}
namespace oop
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Speak();
            Animal cat = new Cat();
            cat.Speak();
            Console.ReadLine();
        }
    }
}