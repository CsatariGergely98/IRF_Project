using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRF_Beadando;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IRF_Beadando.Tests
{
    [TestClass()] //annotalas
    public class CsvExporterTests
    {

        List<Munkavegzes> munkavegzesek;
        CsvExporter ce;
        string tesztFN = "test.csv";

        // A tesztekhez szükséges globális beállítások elvégzése, változók inicializálása
        [TestInitialize]
        public void TestInitialize()
        {
            munkavegzesek = new List<Munkavegzes>();
            ce = new CsvExporter();
            File.Delete(tesztFN);
        }

        // ha null-t kap, akkor nincs mit menteni (de nem szallhat el)
        [TestMethod()]
        public void exportTest1()
        {
            Assert.IsFalse(ce.Export(tesztFN, null), "Null lista export"); 
        }

        // ha ures listat kap, akkor csak a fejlecet irja bele
        [TestMethod()]
        public void exportTest2()
        {
            File.Delete(tesztFN);
            munkavegzesek.Clear();

            // itt mar sikeresen le kell futni az exportnak, 1 fejléc sorral
            Assert.IsTrue(ce.Export(tesztFN, munkavegzesek), "0 elemszámú lista export");
            Assert.IsTrue(File.Exists(tesztFN), "0 elemszámú lista export file létezik");

            // export file beolvasas
            var csvFile = File.ReadAllLines(tesztFN);
            var csvList = new List<string>(csvFile);
            Assert.AreEqual(csvList.Count, 1, "Csak fejléc sor van");
        }

        // konkret, 1 rekordos munkavegzes
        [TestMethod()]
        public void exportTest3()
        {
            File.Delete(tesztFN);
            munkavegzesek.Clear();
            // egy 1 perces munakvegzes osszeallitasa (adatbazis kapcsolat nelkul)
            Munkavegzes m = new MunkavegzesEpito()
                .Create(1, 2, DateTime.Now.AddMinutes(-1), DateTime.Now)
                .Megjegyzes("megj")
                .Ugyfelazonosito("1234")
                .Ikatoszam("5678")
                .IktatottOldalszam(0)
                .Build();
            m.Dolgozo = new Dolgozo();
            m.Dolgozo.LoginNev = "Teszt Elek";
            m.Tevekenyseg = new Tevekenyseg();
            m.Tevekenyseg.Megnevezes = "Ebédszünet";
            m.Ledolgozott = 1;
            munkavegzesek.Add(m);
            // itt mar sikeresen le kell futni az exportnak, 1 fejléc és 1 adatsorral
            Assert.IsTrue(ce.Export(tesztFN, munkavegzesek), "1 elemszámú lista export");
            Assert.IsTrue(File.Exists(tesztFN), "1 elemszámú lista export file létezik");

            // export file beolvasas
            var csvFile = File.ReadAllLines(tesztFN);
            var csvList = new List<string>(csvFile);
            Assert.AreEqual(csvList.Count, munkavegzesek.Count+1, "Csak fejléc sor van");

        }
    }
}