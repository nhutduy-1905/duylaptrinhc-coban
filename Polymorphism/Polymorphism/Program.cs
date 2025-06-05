// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig: Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog: Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
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