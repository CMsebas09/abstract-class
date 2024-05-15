using System;  // Importa el espacio de nombres System que contiene las clases fundamentales de C#

namespace Animales  // Define un espacio de nombres llamado Animales
{
    abstract class Animal  // Define una clase abstracta llamada Animal
    {
        public abstract void animalSound();  // Declara un método abstracto para el sonido del animal
        public abstract void typeanimal();  // Declara un método abstracto para el tipo de animal
        public void sleep()  // Define un método concreto para que el animal duerma
        {
            Console.WriteLine("Zzz");  // Imprime un mensaje indicando que el animal está durmiendo
        }
    }

    class Leon : Animal  // Define una clase llamada Leon que hereda de Animal
    {
        public override void animalSound()  // Implementa el método animalSound de la clase base
        {
            Console.WriteLine("Rugido");  // Imprime el sonido característico del león
        }

        public override void typeanimal()  // Implementa el método typeanimal de la clase base
        {
            Console.WriteLine("mamifero");  // Imprime el tipo de animal (mamífero)
        }
    }

    class Sapo : Animal  // Define una clase llamada Sapo que hereda de Animal
    {
        public override void animalSound()  // Implementa el método animalSound de la clase base
        {
            Console.WriteLine("croac, croac");  // Imprime el sonido característico del sapo
        }

        public override void typeanimal()  // Implementa el método typeanimal de la clase base
        {
            Console.WriteLine("anfibio");  // Imprime el tipo de animal (anfibio)
        }
    }

    class Cocodrilo : Animal  // Define una clase llamada Cocodrilo que hereda de Animal
    {
        public override void animalSound()  // Implementa el método animalSound de la clase base
        {
            Console.WriteLine("gruñido gutural");  // Imprime el sonido característico del cocodrilo
        }

        public override void typeanimal()  // Implementa el método typeanimal de la clase base
        {
            Console.WriteLine("reptil");  // Imprime el tipo de animal (reptil)
        }
    }

    class Program  // Define la clase principal Program
    {
        static void Main(string[] args)  // Método principal de la aplicación
        {
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Leon leon = new Leon();  // Crea una instancia de la clase Leon
            Console.WriteLine("LEON");  // Imprime un título indicando el tipo de animal
            leon.animalSound();  // Llama al método para reproducir el sonido del león
            leon.typeanimal();  // Llama al método para obtener el tipo de animal
            leon.sleep();  // Llama al método para hacer que el león duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Sapo sapo = new Sapo();  // Crea una instancia de la clase Sapo
            Console.WriteLine("SAPO");  // Imprime un título indicando el tipo de animal
            sapo.animalSound();  // Llama al método para reproducir el sonido del sapo
            sapo.typeanimal();  // Llama al método para obtener el tipo de animal
            sapo.sleep();  // Llama al método para hacer que el sapo duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Cocodrilo cocodrilo = new Cocodrilo();  // Crea una instancia de la clase Cocodrilo
            Console.WriteLine("COCODRILO");  // Imprime un título indicando el tipo de animal
            cocodrilo.animalSound();  // Llama al método para reproducir el sonido del cocodrilo
            cocodrilo.typeanimal();  // Llama al método para obtener el tipo de animal
            cocodrilo.sleep();  // Llama al método para hacer que el cocodrilo duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
        }
    }
}
