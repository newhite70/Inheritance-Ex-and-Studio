using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerClasses;
using ComputersClasses;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        Computer test_computer;
        Computer test_laptop;
        Computer test_smartphone;

        [TestInitialize]
        public void CreateComputerOvj()
        {
            test_computer = new Computer(false, "Dell");
        }
        public void CreateLaptop()
        {
            test_laptop = new Laptop(false, "Alien");
        }
        public void CreatePhoneOvj()
        {
            test_smartphone = new SmartPhone(false, "hp");
        }


        [TestMethod]
        public void Testlaptoppower()
            
        {
            test_laptop = new Laptop(false, "Alien");
            Assert.AreEqual(false, test_laptop.Power);
        }
        [TestMethod]
        public void TestlaptopMake()
        {
            test_laptop = new Laptop(false, "Alien");
            Assert.AreEqual("Alien", test_laptop.Make);
        }
        [TestMethod]
        public void TestlaptopPowerState()
        {
            test_laptop = new Laptop(true, "Alien");
            test_computer = new Computer(true, "dell");
            test_laptop.GetPowerState();
            Assert.AreEqual("On", test_laptop.powerState);
            Assert.AreEqual(5, test_computer.UUID);
        }








    }
}
