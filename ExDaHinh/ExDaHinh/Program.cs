using Microsoft.VisualBasic;
using System;
namespace DaHinh
{
    class Animal
    {
        public virtual  void Speak()
        {
            Console.WriteLine("Animal is speak!");
        }
    }
    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speak gau gau");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speak meo meo!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Speak();
            myCat.Speak();
            Console.ReadKey();
        }
    }
}