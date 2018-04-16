using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class AnimalShelter
    {
        public Queue Dogs { get; set; }
        public Queue Cats { get; set; }

        public AnimalShelter()
        {
            Dogs = new Queue();
            Cats = new Queue();
        }

        /// <summary>
        /// Prints to the console the contents of the shelter
        /// </summary>
        public void Render()
        {
            Console.WriteLine("This is the shelter of (p)awesomeness!");
            Console.Write("Dogs: ");
            while (Dogs.Peek() != null)
            {
                Dog dog = (Dog)Dogs.Dequeue();
                Console.Write($"{dog.Name} --> ");
            }
            Console.Write("\nCats: ");
            while (Cats.Peek() != null)
            {
                Cat cat = (Cat)Cats.Dequeue();
                Console.Write($"{cat.Name} --> ");
            }
        }
    }
}
