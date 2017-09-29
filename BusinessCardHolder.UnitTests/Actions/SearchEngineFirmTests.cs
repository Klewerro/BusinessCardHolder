using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCardHolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardHolder.UnitTests;
using BusinessCardHolder.Entities;
using BusinessCardHolder.Actions;

namespace BusinessCardHolder.Tests
{
    [TestClass()]
    public class SearchEngineFirmTests
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
                var f4 = new Firm() { Name = "Zeto", City = "Kraków", Street = "Polna" };
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
        public void SearchFirmAnyWordTest_WordsToMultipleFinds()
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEngineFirm();
            var firmActions = new FirmActions();

            //act
            string[] s1 = { "Asseco", "Warszawa", "Kopisto" };
            string[] s2 = { "Zeto", "Kopisto" };
            string[] s3 = { "Zeto", "Dąbrowskiego" };
            var result1 = searchEngine.SearchFirmAnyWord(s1);
            var result2 = searchEngine.SearchFirmAnyWord(s2);
            var result3 = searchEngine.SearchFirmAnyWord(s3);

            //assert
            Assert.AreEqual(3, result1.Count);
            Assert.AreEqual(1, result2.Count);
            Assert.AreEqual(2, result3.Count);
        }

        [TestMethod()]
        public void SearchFirmByNameTest()
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEngineFirm();
            var firmActions = new FirmActions();

            //act
            string s = "  Zeto";
            var result1 = searchEngine.SearchFirmByName(s);
            firmActions.CreateFirm(new Firm() { Name = "Zeto" });
            var result2 = searchEngine.SearchFirmByName(s);

            //assert
            Assert.AreEqual("Zeto", result1[0].Name);
            Assert.IsTrue(result1.Count == 1);
            Assert.AreEqual("Zeto", result2[1].Name);
            Assert.IsTrue(result2.Count == 2);
        }

        [TestMethod()]
        [DataRow("Zeto", "Kopisto", "Rzeszów")]
        public void SearchFirmAllWordsTest(string name, string city, string street)
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEngineFirm();
            var firmActions = new FirmActions();

            //act
            firmActions.CreateFirm(new Firm() { Name = name, City = "Kraków", Street = "Kościelna" });
            string[] s1 = { name, city, street };
            string[] s2 = { street, name, city };
            string[] s3 = { "Zeto", "Rzeszów" };



            var result1 = searchEngine.SearchFirmAllWords(s1);
            var result2 = searchEngine.SearchFirmAllWords(s2);
            var result3 = searchEngine.SearchFirmAllWords(s3);


            //assert
            Assert.IsTrue(result1.Count == 1);
            Assert.IsTrue(result2.Count == 1);
            Assert.AreEqual("Zeto", result1[0].Name);
            Assert.AreEqual("Zeto", result2[0].Name);
            Assert.IsTrue(result3.Count == 0);
        }

        [TestMethod()]
        [DataRow("Zeto", "Kopisto", "Rzeszów")]
        [DataRow("Zeto", "", "Rzeszów")]
        [DataRow("Zeto", " ", "Rzeszów")]
        [DataRow("Zeto", null, "Rzeszów")]
        public void SearchFirmAnyWordTest_WordsToSingleFind(string name, string city, string street)
        {
            //arrange
            PrepareData();
            var searchEngine = new SearchEngineFirm();
            var firmActions = new FirmActions();

            //act
            var result1 = searchEngine.SearchFirmAnyWord(name, city, street); //1
            var result2 = searchEngine.SearchFirmAnyWord("  ", "Rzeszów", " Polna"); //0
            var result3 = searchEngine.SearchFirmAnyWord("   ", "Rzeszów", "  "); //2

            //assert
            Assert.AreEqual(0, result2.Count);
            Assert.AreEqual(2, result3.Count);
        }
    }
}