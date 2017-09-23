using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using BusinessCardHolder.Entities;
using BusinessCardHolder.UnitTests;

namespace BusinessCardHolder.Actions.Tests
{
    [TestClass()]
    public class FirmPersonActionsTests
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
        public void CreateNewFirmAndNewPersonTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            var personActions = new PersonActions();
            var firmAndPersonActions = new FirmPersonActions();
            Firm firm1 = new Firm() { Name = "Abc", City = "Warszawa" };
            Firm firm2 = new Firm() { Name = "Cde", City = "Poznań" };
            Person person1 = new Person() { Forename = "A", Name = "B" };
            Person person2 = new Person() { Forename = "C", Name = "D" };
            Person person3 = new Person() { Forename = "E", Name = "F" };

            //act
            var result1 = firmActions.ReadAllFirms();
            var result2 = personActions.ReadPersons();
            firmAndPersonActions.CreateNewFirmAndNewPerson(firm1, person1);
            personActions.CreatePersonAndAddToFirm(person2, 3);
            firmAndPersonActions.CreateNewFirmAndNewPerson(firm2, person3);
            var result11 = firmActions.ReadAllFirms();
            var result22 = personActions.ReadPersons();
            var result33 = personActions.ReadPersonsForFirm(3);
            var result34 = personActions.ReadPersonsForFirm(4);

            //assert
            //beforeAct
            Assert.IsTrue(result1.Count == 2);
            Assert.IsTrue(result2.Count == 3);  ////number of pple before
            //afterAct
            Assert.IsTrue(result11.Count == 4);
            Assert.IsTrue(result22.Count == 6); //number of pple after
            Assert.IsTrue(result33.Count == 2); //number of pple in 1st added firm

            Assert.IsTrue(result34.Count == 1);
            Assert.AreEqual("D", result33[1].Name);
        }

        [TestMethod()]
        public void DeleteFirmAndEmployeesTest()
        {
            //arrange
            PrepareData();
            var firmActions = new FirmActions();
            var firmAndPersonActions = new FirmPersonActions();


            //act
            var resultBefore = firmActions.ReadAllFirms();
            var resultSingleFfirmBefore = firmActions.ReadFirm(1);
            firmAndPersonActions.DeleteFirmAndEmployees(1); //zeto, pple count == 2
            var resultAfter = firmActions.ReadAllFirms();
            var resultSingleFfirmAfter = firmActions.ReadFirm(1);

            //assert            
            Assert.IsTrue(resultBefore.Count == 2);
            Assert.IsFalse(resultAfter.Count == 2);
            Assert.IsTrue(resultAfter.Count == 1);
            Assert.AreEqual("Komputronik", resultAfter[0].Name);
            Assert.AreEqual(2, resultAfter[0].FirmId);
            try
            {
                Assert.IsNull(resultSingleFfirmAfter);
                //Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException ex) { }

        }
    }
}