using System;
using Xunit;
using fifo_animal_shelter;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCat()
        {
            AnimalShelter pawsome = new AnimalShelter();
            Program.Enqueue(pawsome, new Cat("Smoky"));
            Assert.Equal("Smoky", pawsome.Cats.Peek().Value.Name);
        }

        [Fact]
        public void CanFifoCat()
        {
            AnimalShelter pawsome = new AnimalShelter();
            Program.Enqueue(pawsome, new Cat("Smoky"));
            Program.Enqueue(pawsome, new Cat("Smokey"));
            Assert.Equal("Smoky", Program.Dequeue(pawsome, "cat").Name);
        }

        [Fact]
        public void CanAddDog()
        {
            AnimalShelter pawsome = new AnimalShelter();
            Program.Enqueue(pawsome, new Dog("Tika"));
            Assert.Equal("Tika", pawsome.Dogs.Peek().Value.Name);
        }

        [Fact]
        public void CanFifoDog()
        {
            AnimalShelter pawsome = new AnimalShelter();
            Program.Enqueue(pawsome, new Dog("Tika"));
            Program.Enqueue(pawsome, new Dog("Rover"));
            Assert.Equal("Tika", Program.Dequeue(pawsome, "Dog").Name);
        }

        [Fact]
        public void OnlyDoesFifo()
        {
            bool passing = true;
            for (int i = 0; i < 50; i++)
            {
                AnimalShelter pawsome = new AnimalShelter();
                Program.Enqueue(pawsome, new Dog("Tika"));
                Program.Enqueue(pawsome, new Dog("Rover"));
                Program.Enqueue(pawsome, new Dog("Ranger"));
                Program.Enqueue(pawsome, new Cat("Smoky"));
                Program.Enqueue(pawsome, new Cat("Simba"));
                Program.Enqueue(pawsome, new Cat("Smokey"));
                Animal a = Program.Dequeue(pawsome, "anything");
                passing = (a.Name == "Smoky" || a.Name == "Tika") && passing; // Either dog or cat pulled by Fifo.
            }
            Assert.True(passing); //All 50 animals pulled were fifo
        }

        [Fact]
        public void CanReturnCatNoPref()
        {
            bool passing = false;
            for (int i = 0; i < 30; i++)
            {
                AnimalShelter pawsome = new AnimalShelter();
                Program.Enqueue(pawsome, new Dog("Tika"));
                Program.Enqueue(pawsome, new Dog("Rover"));
                Program.Enqueue(pawsome, new Dog("Ranger"));
                Program.Enqueue(pawsome, new Cat("Smoky"));
                Program.Enqueue(pawsome, new Cat("Simba"));
                Program.Enqueue(pawsome, new Cat("Smokey"));
                Animal a = Program.Dequeue(pawsome, "anything");
                passing = a.Name == "Smoky" || passing; // Cat pulled or has been pulled
            }
            Assert.True(passing);//Will sometimes dequeue a cat when given no preference
        }

        [Fact]
        public void CanReturnDogNoPref()
        {
            bool passing = false;
            for (int i = 0; i < 30; i++)
            {
                AnimalShelter pawsome = new AnimalShelter();
                Program.Enqueue(pawsome, new Dog("Tika"));
                Program.Enqueue(pawsome, new Dog("Rover"));
                Program.Enqueue(pawsome, new Dog("Ranger"));
                Program.Enqueue(pawsome, new Cat("Smoky"));
                Program.Enqueue(pawsome, new Cat("Simba"));
                Program.Enqueue(pawsome, new Cat("Smokey"));
                Animal a = Program.Dequeue(pawsome, "anything");
                passing = a.Name == "Tika" || passing; // Dog pulled or has been pulled
            }
            Assert.True(passing); //Will sometimes dequeue a dog when given no preference
        }
    }
}
