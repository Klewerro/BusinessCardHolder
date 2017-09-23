using BusinessCardHolder.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder.UnitTests;
using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;

namespace BusinessCardHolder.Actions.Tests
{
    [TestClass()]
    public class PersonActionsTests
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
                var p1 = new Person() { Name = "Brzeczyszczykiewicz", Forename = "Grzegorz", Phone = "172764084", CellPhone = "696173994", Email = "grzes@tlen.com", BithDate = new DateTime(1995, 6, 26) };
                var p2 = new Person() { Name = "Kapusta", Forename = "Grarzyna", Phone = "172234035", CellPhone = "696126547", Email = "kapustra@asdr.pl", BithDate = new DateTime(1990, 2, 12) };
                var p3 = new Person() { Name = "Petru", Forename = "Ryszard", Phone = "17212354", CellPhone = "696173873", Email = "petru@blame.com", BithDate = new DateTime(1992, 1, 22) };

                f1.Employees.Add(p1);
                f1.Employees.Add(p2);
                f2.Employees.Add(p3);

                model.Firm.Add(f1);
                model.Firm.Add(f2);
                model.SaveChanges();
            }
        }



        [TestMethod()]
        public void ReadPersonsTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result = personActions.ReadPersons();

            //assert
            Assert.IsTrue(result.Count == 3);
            Assert.AreEqual("Petru", result[2].Name);
        }

        [TestMethod()]
        public void ReadPersonTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result = personActions.ReadPerson("Kapusta");   //var p2 = new Person() { Name = "Kapusta", Forename = "Grarzyna" };

            //assert
            Assert.AreEqual("Grarzyna", result.Forename);
        }

        [TestMethod()]
        public void ReadPersonsForFirmTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();
            var firmActions = new FirmActions();

            //act
            var firm = firmActions.ReadFirm(1); //var f2 = new Firm() { Name = "Komputronik" };
            var result = personActions.ReadPersonsForFirm(firm);    //1 employee

            //assert
            Assert.AreEqual("Zeto", firm.Name);
            Assert.AreEqual("Brzeczyszczykiewicz", result[0].Name);
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod()]
        public void CreatePersonTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result1 = personActions.ReadPersons();
            personActions.CreatePerson(new Person() { Forename = "ABC", Name = "DEF" });
            var result2 = personActions.ReadPersons();

            //assert
            Assert.AreNotSame(result1.Count, result2.Count);
            Assert.AreNotSame(result1, result2);
            Assert.AreEqual("ABC", result2[3].Forename);
            Assert.AreEqual("DEF", result2[3].Name);
        }

        [TestMethod()]
        public void CreatePersonAndAddToFirmTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();
            Person person1 = new Person() { Forename = "A", Name = "B" };
            Person person2 = new Person() { Forename = "C", Name = "D" };
            Person person3 = new Person() { Forename = "E", Name = "F" };

            //act       
            personActions.CreatePersonAndAddToFirm(person1, 1);  //f1 = new Firm() { Name = "Zeto" }; Employyes.count == 2
            personActions.CreatePersonAndAddToFirm(person2, 2); //f2 = new Firm() { Name = "Komputronik" }; Employyes.count == 1
            personActions.CreatePersonAndAddToFirm(person3, 1); // f1 = 4; f2 = 2
            var result1 = personActions.ReadPersonsForFirm(1);
            var result2 = personActions.ReadPersonsForFirm(2);

            //assert
            Assert.IsTrue(result1.Count == 4);
            Assert.IsTrue(result2.Count == 2);
            Assert.AreEqual("A", result1[2].Forename);
            Assert.AreEqual("B", result1[2].Name);
            Assert.AreEqual("C", result2[1].Forename);
            Assert.AreEqual("D", result2[1].Name);
        }

        [TestMethod()]
        public void DeletePersonTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result1 = personActions.ReadPersons();
            var result2 = personActions.ReadPersonsForFirm(2);
            personActions.DeletePerson("Petru");
            var result11 = personActions.ReadPersons();
            var result22 = personActions.ReadPersonsForFirm(2);

            //assert
            Assert.IsNotNull(result2[0]);
            Assert.AreEqual("Petru", result2[0].Name);
            try
            {
                Assert.IsNull(result22[0]);
                //Assert.IsTrue(result22[0].Name == "Petru");
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException ex) { }
            Assert.IsTrue(result1.Count == 3);
            Assert.IsTrue(result11.Count == 2);
            Assert.IsTrue(result2.Count == 1);
            Assert.IsTrue(result22.Count == 0);
        }

        [TestMethod()]
        public void DeletePersonsRangeTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result1 = personActions.ReadPersons();
            personActions.DeletePersonsRange(2, 3);
            var result2 = personActions.ReadPersons();

            //assert
            Assert.IsTrue(result1.Count == 3);
            Assert.IsTrue(result2.Count == 1);
            Assert.AreEqual("Brzeczyszczykiewicz", result2[0].Name);
        }

        [TestMethod()]
        public void DeleteAllEmployeesFromFirmTest()
        {
            //arrange
            PrepareData();
            var personActions = new PersonActions();

            //act
            var result1 = personActions.ReadPersonsForFirm(1); //count ==2
            personActions.DeleteAllEmployeesFromFirm(1);
            var result2 = personActions.ReadPersonsForFirm(1); //count should be 0

            //assert
            Assert.IsTrue(result2.Count == 0);
            try
            {
                Assert.IsNull(result2[0]);
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException ex) { }
            try
            {
                Assert.IsNull(result2[result2.Count]);
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException ex) { }
        }
    }
}