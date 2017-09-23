using BusinessCardHolder.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder.Entities;
using BusinessCardHolder.UnitTests;

namespace BusinessCardHolder.Actions.Tests
{
    [TestClass()]
    public class FirmTests
    {
        [TestInitialize]
        public void MyTestInitialize()
        {
            EffortProviderFactory.ResetDb();
        }

        private void PrepareData()
        {
            using (var model = new BusinessCardContext())
            {
                var f1 = new Firm() { Name = "Zeto" };
                var f2 = new Firm() { Name = "Komputronik" };
                var p1 = new Person() { Name = "Brzeczyszczykiewicz", Forename = "Grzegorz" };
                var p2 = new Person() { Name = "Kapusta", Forename = "Grarzyna" };
                var p3 = new Person() { Name = "Petru", Forename = "Ryszard" };

                f1.Employees.Add(p1);
                f1.Employees.Add(p2);
                f2.Employees.Add(p3);

                model.Firm.Add(f1);
                model.Firm.Add(f2);
                model.SaveChanges();
            }
        }




        [TestMethod()]
        public void ReadAllFirmsTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();

            //act
            var result = firmActions.ReadAllFirms();

            //assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod()]
        [DataRow(1, "Zeto")]
        [DataRow(2, "Komputronik")]
        public void ReadFirmTest(int idProp, string nameProp)
        {
            //arramge
            PrepareData();
            var firmActions = new FirmActions();

            //act
            var result = firmActions.ReadFirm(idProp);

            //assert
            Assert.AreEqual(nameProp, result.Name);
        }

        [TestMethod()]
        public void CreateFirmTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            Firm firm = new Firm() { Name = "Abcdefg", City = "Warszawa", Street = "Połogiewicza", Number = 3, Zip = "12-230" };

            //act
            firmActions.CreateFirm(firm);
            var result = firmActions.ReadAllFirms();

            //assert
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Count == 3);
            Assert.AreEqual("Abcdefg", result[2].Name); //3-1
            Assert.AreEqual(3, result[2].Number);
        }

        [TestMethod()]
        public void UpdateFirmTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            Firm firm = new Firm() { Name = "Abcdefg", City = "Warszawa", Street = "Połogiewicza", Number = 3, Zip = "12-230" };
            Firm firm2 = new Firm() { Name = "GFEDCBA", City = "Warszawa", Street = "Wiejska", Number = 2, Zip = "12-230", FirmId = 3 };

            //act
            firmActions.CreateFirm(firm);
            firmActions.UpdateFirm(firm2);
            var result = firmActions.ReadAllFirms();

            //assert
            Assert.IsTrue(result.Count == 3);
            Assert.IsFalse(result.Count > 3);
            Assert.IsTrue(result[2].Name == "GFEDCBA");
            Assert.IsTrue(result[2].FirmId == 3);
            Assert.IsTrue(result[2].Street == "Wiejska");
            Assert.IsFalse(result[2].Name == "Abcdefg");
            Assert.AreNotEqual("Abcdefg", result[2].Name);
        }

        [TestMethod()]
        public void DeleteFirmTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            Firm firm = new Firm() { Name = "Abcdefg", City = "Warszawa", Street = "Połogiewicza", Number = 3, Zip = "12-230" };

            //act
            firmActions.CreateFirm(firm);
            var result1 = firmActions.ReadAllFirms();
            firmActions.DeleteFirm("Abcdefg");
            var result2 = firmActions.ReadAllFirms();

            //assert
            Assert.IsTrue(result1.Count == 3);
            Assert.IsTrue(result2.Count == 2);
            Assert.IsTrue(result1[2].Name == "Abcdefg");
            try
            {
                Assert.IsTrue(result2[2].Name == "Abcdefg");
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException ex) { }
        }

        [TestMethod()]
        public void CheckIfFirmExistTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            Firm firm = new Firm() { Name = "Abcdefg", City = "Warszawa", Street = "Połogiewicza", Number = 3, Zip = "12-230" };

            //act
            firmActions.CreateFirm(firm);
            bool result = firmActions.CheckIfFirmExist("Abcdefg");

            //assert
            Assert.IsTrue(result == true);
        }
    }
}