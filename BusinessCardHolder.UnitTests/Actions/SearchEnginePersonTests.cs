using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardHolder.UnitTests;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Actions.Tests
{
    [TestClass()]
    public class SearchEnginePersonTests
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
                var f1 = new Firm() { Name = "Zeto", City = "Rzeszów", Street = "Kopisto" };
                var f2 = new Firm() { Name = "Komputronik", City = "Warszawa", Street = "Wiejska" };
                var f3 = new Firm() { Name = "Asseco", City = "Rzeszów", Street = "Dąbrowskiego" };
                var p1 = new Person() { Name = "Brzeczyszczykiewicz", Forename = "Grzegorz", Phone = "172764084", CellPhone = "696173994", Email = "grzes@tlen.com", BithDate = new DateTime(1995, 6, 26) };
                var p2 = new Person() { Name = "Kapusta", Forename = "Grarzyna", Phone = "172234035", CellPhone = "696126547", Email = "kapustra@asdr.pl", BithDate = new DateTime(1990, 2, 12) };
                var p3 = new Person() { Name = "Petru", Forename = "Ryszard", Phone = "17212354", CellPhone = "696173873", Email = "petru@blame.com", BithDate = new DateTime(1992, 1, 22) };

                f1.Employees.Add(p1);
                f2.Employees.Add(p2);
                f2.Employees.Add(p3);
                f3.Employees.Add(p3);

                model.Firm.Add(f1);
                model.Firm.Add(f2);
                model.Firm.Add(f3);
                model.SaveChanges();
            }
        }




        [TestMethod()]
        public void SearchPersonAnyWordTest()
        {
            //arrange
            PrepareData();
            var searchEnginePerson = new SearchEnginePerson();
            var firmActions = new FirmActions();

            //act
            string[] s = { "Brzeczyszczykiewicz", "Petru", "kapustra@asdr.pl" };
            var result = searchEnginePerson.SearchPersonAnyWord(s);

            //assert
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod()]
        public void SearchPersonByNameTest()
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEnginePerson();
            var personActions = new PersonActions();
            var firmActions = new FirmActions();

            //act
            string s = "Brzeczyszczykiewicz";
            var result1 = searchEngine.SearchPersonByName(s);
            personActions.CreatePersonAndAddToFirm(new Person() { Name = "Brzeczyszczykiewicz", Forename = "Barbara" }, firmActions.ReadFirm("Zeto").FirmId);
            var result2 = searchEngine.SearchPersonByName(s);

            //assert
            Assert.IsTrue(result1.Count == 1);
            Assert.IsTrue(result2.Count == 2);
        }

        [TestMethod()]
        public void SearchPersonAnyWordTest_MultipleWordsToResult()
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEnginePerson();

            //act
            var result = searchEngine.SearchPersonAnyWord("Brzeczyszczykiewicz", "Grzegorz", null, "          ");

            //assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void SearchPersonAnyWordTest_InSpecificFirm_FirmForm()
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEnginePerson();
            var firmActions = new FirmActions();

            //act
            var firm = firmActions.ReadFirm("Zeto");
            var result = searchEngine.SearchPersonAnyWord("  ", "   ", null, firm);

            //assert
            Assert.AreEqual(1, result.Count);
        }
    }
}