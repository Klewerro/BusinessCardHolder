using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder.Actions;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.UnitTests
{
    [TestClass]
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

        

        [TestMethod]
        public void Get_MatchingFirmName()
        {
            PrepareData();
            var firmActions = new FirmActions();

            var result = firmActions.ReadFirm("Zeto");

            Assert.AreSame("Zeto", result.Name);
        }


        [TestMethod]
        public void SingleFirmRemoved()
        {
            PrepareData();
            var firmActions = new FirmActions();
            var personActions = new PersonActions();
            var firmAndPersonsActions = new FirmPersonActions();

            var firms = firmActions.ReadFirm("Zeto");
            firmAndPersonsActions.RemoveFirmAndEmployees(1);
            var result = firmActions.ReadAllFirms();

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void EditFirmWorking()
        {
            PrepareData();
            var firmActions = new FirmActions();

            var firm = firmActions.ReadFirm(1);

            firmActions.UpdateFirm(1, "Triton", "Strzyżów", "Rynek", 3, "10-210");

            var result = firmActions.ReadFirm(1);

            Assert.AreNotSame(firm, result);
        }
    }
}
