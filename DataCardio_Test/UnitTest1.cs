using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(30, "Il numero massimo di battiti è 171 , il numero minimo battiti è 133")]
        [DataRow(40, "Il numero massimo di battiti è 162 , il numero minimo battiti è 126")]
        [DataRow(50, "Il numero massimo di battiti è 153 , il numero minimo battiti è 119")]
        [DataRow(70, "Il numero massimo di battiti è 135 , il numero minimo battiti è 105")]

        public void FreqMaxMin(int eta, string valoreAspettato)
        {
            string risposta = DataCardio.FrequenzaBattitiConsigliata(eta);
            Assert.AreEqual(valoreAspettato, risposta);
        }
        [DataTestMethod]
        [DataRow(88, "Normale")]
        [DataRow(100, "Tachicardia")]
        [DataRow(50, "Bradicardia")]
        public void FrequenzaBattitiRiposo(int battiti, string risultato)
        {
            string risposta = DataCardio.FrequenzaCardiacaRiposo(battiti);
            Assert.AreEqual(risultato, risposta);
        }
        [DataTestMethod]
        [DataRow(16, 100, 70, 10, 60)]
        public void CalorieUomo(int anni, int battitiriposo, int peso, int temp, double risultatoaspettato)
        {
            double risultato = DataCardio.CalorieUomo(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(16, 100, 70, 10, 40)]
        public void CalorieDonna(int anni, int battitiriposo, int peso, int temp, double risultatoaspettato)
        {
            double risultato = DataCardio.CalorieDonna(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }

        [TestMethod]
        public void Corsa()
        {
            double kmpercorsi = 10, pesocorporeo = 60;
            double valoreAspettato = 540;
            double valorefisso = 0.9;
            double valoreRitorno = DataCardio.CalorieCorsa(kmpercorsi, pesocorporeo);
            Assert.AreEqual(valoreAspettato,valoreRitorno,valorefisso);




        }
        [TestMethod]
        public void Camminata()
        {
            double kmpercorsi = 20, pesocorporeo = 70;
            double valoreAspettato = 700;
            double valoreFisso = 0.50;
            double valoreRitorno = DataCardio.CalorieCamminata(kmpercorsi, pesocorporeo);
            Assert.AreEqual(valoreAspettato, valoreRitorno, valoreFisso);

        }

    }
}
