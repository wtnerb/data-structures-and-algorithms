using System;

namespace fifo_animal_shelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AnimalShelter pawsome = new AnimalShelter();
            Enqueue(pawsome, new Cat("Smoky"));
            Console.WriteLine(pawsome.Cats.Peek().Value.Name);

            Console.ReadKey();
        }

        /// <summary>
        /// Adds a Dog to the Dog's queue
        /// </summary>
        /// <param name="AS">the animal shelter in question.</param>
        /// <param name="animal">The animal to be added</param>
        public static void Enqueue (AnimalShelter AS, Dog animal)
        {
            AS.Dogs.Enqueue(new Node(animal));
        }

        /// <summary>
        /// Overload of Enqueue method. Adds a Cat to the Cats queue
        /// </summary>
        /// <param name="AS">Shelter in question</param>
        /// <param name="animal">Animal to be enqueued</param>
        public static void Enqueue (AnimalShelter AS, Cat animal)
        {
            AS.Cats.Enqueue(new Node(animal));
        }

        /// <summary>
        /// This removes an animal from the shelter. If a dog is requested, a dog is removed (or nothing,
        /// if no dogs are in the shelter). If a cat is requested, a cat is removed (or nothing, if no
        /// cats are in the shelter). Otherwise, if both queues contain animals, dog or cat will be randomly
        /// selected for dequeing.
        /// </summary>
        /// <param name="AS">The shelter in question</param>
        /// <param name="pref">a case independent string stating animal preference. cat or dog.</param>
        /// <returns>Animal removed or an exception.</returns>
        public static Animal Dequeue (AnimalShelter AS, string pref)
        {
            if (pref.ToLower() == "dog")
            {
                return AS.Dogs.Dequeue();
            }
            else if (pref.ToLower() == "cat")
            {
                return AS.Cats.Dequeue();
            }
            else if (AS.Cats.Peek() != null && AS.Dogs.Peek() != null)
            {
                Random rand = new Random();
                if (rand.Next(0,2) == 1)
                {
                    return AS.Cats.Dequeue();
                }
                else
                {
                    return AS.Dogs.Dequeue();
                }
            }
            else if (AS.Dogs.Peek() == null && AS.Cats.Peek() != null)
            {
                return AS.Cats.Dequeue();
            }
            else if (AS.Dogs.Peek() != null && AS.Cats.Peek() == null)
            {
                return AS.Dogs.Dequeue();
            }
            else
            {
                throw new Exception("This shelter has no cats or dogs anymore. Want some mystery meat soup?");
                // this line is slightly unprofessional. I probably should choose something else.
            }
        }

        // The overload allows the user to simply leave out the pref string
        // When there is no preference
        public static Animal Dequeue (AnimalShelter AS)
        {
            return Dequeue(AS, "anything");
        }
    }
}
