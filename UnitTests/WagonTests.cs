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

            bool output = newWagon.CheckIfRoomForAnimal(newAnimal);

            Assert.AreEqual(output, true);
        }

        [TestMethod]
        public void CheckIfRoomForAnimal_ReturnsFalse_IfNoRoom()
        {
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            int size = 4;
            var newWagon = new Wagon(size);

            bool output = newWagon.CheckIfRoomForAnimal(newAnimal);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsFalse_IfNotCompatible()
        {
            Animal newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            Wagon newWagon = new Wagon();
            Animal animalInWagon = new Animal(Animal.Diet.Herbivore, Animal.Size.Small, "baa");
            newWagon.PutAnimalInWagon(animalInWagon);

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsTrue_IfCompatible()
        {
            Animal newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Small, "foo");
            Wagon newWagon = new Wagon();
            Animal animalInWagon = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa");
            newWagon.PutAnimalInWagon(animalInWagon);

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, true);
        }

        [TestMethod]
        public void CheckIfAnimalsAreCompatible_ReturnsFalse_IfNotCompatible2()
        {
            Animal newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Small, "foo");
            Wagon newWagon = new Wagon();
            Animal animalInWagon = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "baa");
            newWagon.PutAnimalInWagon(animalInWagon);

            bool output = newWagon.CheckIfAnimalsAreCompatible(newAnimal, newWagon);

            Assert.AreEqual(output, false);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_DividesAnimals()
        {
            
            List<Animal> animalList = MakeSixAnimals();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var firstWagon = new Wagon();

            wagonList.Add(firstWagon);
            Train train = new Train(wagonList);
            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.Wagons.Count, 5);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_DividesAnimalsOverWagons()
        {

            List<Animal> animalList = new List<Animal>();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "foo");
            var newAnimal2 = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa");
            var firstWagon = new Wagon();

            animalList.Add(newAnimal);
            animalList.Add(newAnimal2);

            wagonList.Add(firstWagon);
            Train train = new Train(wagonList);
            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.Wagons.Count, 1);
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_MakesNewWagon()
        {

            List<Animal> animalList = new List<Animal>();
            List<Wagon> wagonList = new List<Wagon>();
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            var newAnimal2 = new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "baa");
            var firstWagon = new Wagon();

            animalList.Add(newAnimal);
            animalList.Add(newAnimal2);

            wagonList.Add(firstWagon);
            Train train = new Train(wagonList);
            train.DivideAnimalsOverWagons(animalList);

            Assert.AreEqual(train.Wagons.Count, 2);
        }

        public List<Animal> MakeSixAnimals()
        {
            List<Animal> animalList = new List<Animal>();
            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "foo");
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            animalList.Add(newAnimal);
            return animalList;
        }
    }
}
