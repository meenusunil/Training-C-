using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound() // 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            Pig pig = new Pig();
            Dog dog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Console.WriteLine(" ");
            pig.animalSound();
            dog.animalSound();


            
        }
    }
}
