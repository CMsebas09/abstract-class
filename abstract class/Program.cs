using System;

namespace Animales
{
    abstract class Animal
    {
        public abstract void animalSound();
        public abstract void typeanimal();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Leon : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Rugido");
        }
        public override void typeanimal() 

        {
            Console.WriteLine("mamifero");
        }
    }

    class Sapo : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("croac, croac");
        }
        public override void typeanimal()

        {
            Console.WriteLine("anfibio");
        }
    }

    class Cocodrilo : Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("gruñido gutural");
        }
        public override void typeanimal()

        {
            Console.WriteLine("reptil");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Leon leon = new Leon();
            Console.WriteLine("LEON");
            leon.animalSound();
            leon.typeanimal();
            leon.sleep();
            Console.WriteLine("---------------------------");
            Sapo sapo = new Sapo();
            Console.WriteLine("SAPO");
            sapo.animalSound();
            sapo.typeanimal();  
            sapo.sleep();
            Console.WriteLine("---------------------------");
            Cocodrilo cocodrilo = new Cocodrilo();
            Console.WriteLine("COCODRILO");
            cocodrilo.animalSound();
            cocodrilo.typeanimal(); 
            cocodrilo.sleep();
            Console.WriteLine("---------------------------");
        }
    }
}
