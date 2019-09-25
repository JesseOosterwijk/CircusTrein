using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void CheckIfRoomForAnimal_ReturnsTrue_IfRoom()
        {
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var newWagon = new Wagon();

            bool output = newWagon.CheckIfRoomForAnimal(newAnimal, newWagon);

            Assert.AreEqual(output, true);
        }

        [TestMethod]
        public void CheckIfRoomForAnimal_ReturnsFalse_IfNoRoom()
        {
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var newWagon = new Wagon
            {
                WagonSize = 4
            };

            bool output = newWagon.CheckIfRoomForAnimal(newAnimal, newWagon);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsFalse_IfNotCompatible()
        {
            Animal newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            Wagon newWagon = new Wagon();
            List<Animal> animalInWagon = new List<Animal>
            {
                new Animal(Animal.Diet.Herbivore, Animal.Size.Small, "baa")
            };
            newWagon.AnimalsInWagon = animalInWagon;

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsTrue_IfCompatible()
        {
            Animal newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Small, "foo");
            Wagon newWagon = new Wagon();
            List<Animal> animalInWagon = new List<Animal>
            {
                new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa")
            };
            newWagon.AnimalsInWagon = animalInWagon;

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, true);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsFalse_IfNotCompatible2()
        {
            Animal newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Small, "foo");
            Wagon newWagon = new Wagon();
            List<Animal> animalInWagon = new List<Animal>
            {
                new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "baa")
            };
            newWagon.AnimalsInWagon = animalInWagon;

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_DividesAnimals()
        {
            Train train = new Train();
            List<Animal> animalList = new List<Animal>();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var firstWagon = new Wagon();

            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);

            wagonList.Add(firstWagon);

            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.wagons.Count, 5);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_DividesAnimalsOverWagon()
        {
            Train train = new Train();
            List<Animal> animalList = new List<Animal>();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "foo");
            var newAnimal2 = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa");
            var firstWagon = new Wagon();

            animalList.Add(newAnimal);
            animalList.Add(newAnimal2);

            wagonList.Add(firstWagon);

            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.wagons.Count, 1);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_MakesNewWagon()
        {
            Train train = new Train();
            List<Animal> animalList = new List<Animal>();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var newAnimal2 = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa");
            var firstWagon = new Wagon();

            animalList.Add(newAnimal);
            animalList.Add(newAnimal2);

            wagonList.Add(firstWagon);

            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.wagons.Count, 2);
        }
    }
}
