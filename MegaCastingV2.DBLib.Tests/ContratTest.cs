using System;
using MegaCastingV2.DBlib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MegaCastingV2.DBLib.Tests
{
    [TestClass]
    public class ContratTest
    {

        /// <summary>
        /// Methode - Scenario - Resultat attendu
        /// </summary>
        [TestMethod]
        public void ToString_HasName_True()
        {
            Contrat contrat = new Contrat();
            contrat.Nom = "Test";

            Assert.AreEqual("Test", contrat.ToString());
        }
        [TestMethod]
        public void Compare_Name()
        {
            Contrat contrat1 = new Contrat();
            Contrat contrat2 = new Contrat();
            contrat1.Nom = "Test";
            contrat2.Nom = "Test";

            Assert.AreEqual(contrat1.Nom, contrat2.Nom);
        }
    }
}
