// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}