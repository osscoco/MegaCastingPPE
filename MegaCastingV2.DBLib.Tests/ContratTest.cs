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
            contrat.Libelle_Contrat = "Test";

            Assert.AreEqual("Test", contrat.ToString());
        }
    }
}
