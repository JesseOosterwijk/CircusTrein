using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace UnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void IsThereRoomForAnimal_ReturnsFalse_IfNoRoom()
        {
            Wagon wagon = GenerateFullWagon();
            Animal animal = GenerateLargeHerbivore();

            var result = wagon.IsThereRoomForAnimal(animal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsThereRoomForAnimal_ReturnsTrue_IfRoom_EmptyWagon()
        {
            Wagon wagon = new Wagon();
            Animal animal = GenerateLargeCarnivore();

            var result = wagon.IsThereRoomForAnimal(animal);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThereRoomForAnimal_ReturnsTrue_IfRoom_HalfFullWagon()
        {
            Wagon wagon = new Wagon();
            Animal animal = GenerateLargeCarnivore();
            wagon.AddAnimal(animal);

            var result = wagon.IsThereRoomForAnimal(animal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_IfNoOtherAnimalInWagon()
        {
            Wagon wagon = new Wagon();
            Animal newAnimal = GenerateLargeHerbivore();

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_IfNoRoomForAnimal()
        {
            Wagon wagon = GenerateFullWagon();
            Animal newAnimal = GenerateMediumCarnivore();

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_LargeCarnivoreGetsAdded_ToSmallHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallHerbivore();
            Animal newAnimal = GenerateLargeCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
            
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_LargeCarnivoreGetsAdded_ToMediumHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumHerbivore();
            Animal newAnimal = GenerateLargeCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_LargeCarnivoreGetsAdded_ToLargeHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeHerbivore();
            Animal newAnimal = GenerateLargeCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_MediumCarnivoreGetsAdded_ToLargeHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeHerbivore();
            Animal newAnimal = GenerateMediumCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_MediumCarnivoreGetsAdded_ToMediumHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumHerbivore();
            Animal newAnimal = GenerateMediumCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_MediumCarnivoreGetsAdded_ToSmallHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallHerbivore();
            Animal newAnimal = GenerateMediumCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_SmallCarnivoreGetsAdded_ToLargeHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeHerbivore();
            Animal newAnimal = GenerateSmallCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_SmallCarnivoreGetsAdded_ToMediumHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumHerbivore();
            Animal newAnimal = GenerateSmallCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFlase_SmallCarnivoreGetsAdded_ToSmallHerbivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallHerbivore();
            Animal newAnimal = GenerateSmallCarnivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_LargeHerbivoreGetsAdded_ToLargeCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeCarnivore();
            Animal newAnimal = GenerateLargeHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_LargeHerbivoreGetsAdded_ToMediumCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumCarnivore();
            Animal newAnimal = GenerateLargeHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_LargeHerbivoreGetsAdded_ToSmallCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallCarnivore();
            Animal newAnimal = GenerateLargeHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_MediumHerbivoreGetsAdded_ToLargeCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeCarnivore();
            Animal newAnimal = GenerateMediumHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_MediumHerbivoreGetsAdded_ToMediumCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumCarnivore();
            Animal newAnimal = GenerateMediumHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsTrue_MediumHerbivoreGetsAdded_ToSmallCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallCarnivore();
            Animal newAnimal = GenerateMediumHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_SmallHerbivoreGetsAdded_ToLargeCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateLargeCarnivore();
            Animal newAnimal = GenerateSmallHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_SmallHerbivoreGetsAdded_ToMediumCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateMediumCarnivore();
            Animal newAnimal = GenerateSmallHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddAnimal_ReturnsFalse_SmallHerbivoreGetsAdded_ToSmallCarnivore()
        {
            Wagon wagon = new Wagon();
            Animal animalInWagon = GenerateSmallCarnivore();
            Animal newAnimal = GenerateSmallHerbivore();

            wagon.AddAnimal(animalInWagon);

            var result = wagon.AddAnimal(newAnimal);

            Assert.IsFalse(result);
        }

        Animal GenerateLargeCarnivore()
        {
            return new Animal(Animal.Diet.Carnivore, Animal.Size.Large, "Lion");
        }

        Animal GenerateMediumCarnivore()
        {
            return new Animal(Animal.Diet.Carnivore, Animal.Size.Medium, "Hyena");
        }

        Animal GenerateSmallCarnivore()
        {
            return new Animal(Animal.Diet.Carnivore, Animal.Size.Small, "Lizard");
        }

        Animal GenerateSmallHerbivore()
        {
            return new Animal(Animal.Diet.Herbivore, Animal.Size.Small, "Rabbit");
        }

        Animal GenerateMediumHerbivore()
        {
            return new Animal(Animal.Diet.Herbivore, Animal.Size.Medium, "Sheep");
        }

        Animal GenerateLargeHerbivore()
        {
            return new Animal(Animal.Diet.Herbivore, Animal.Size.Large, "Elephant");
        }

        Wagon GenerateFullWagon()
        {
            Wagon wagon = new Wagon();
            Animal animal = GenerateLargeHerbivore();
            wagon.AddAnimal(animal);
            wagon.AddAnimal(animal);
            return wagon;
        }
    }
}
