using System;
using System.IO;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string FrequenzaBattitiConsigliata(int eta)
        {

            int freq = 220 - eta;
            double max = (freq * 90) / 100;
            double min = (freq * 70) / 100;
            string risultato = ($"Il numero massimo di battiti è {max} , il numero minimo battiti è {min}");
            return risultato;


        }
        public static string FrequenzaCardiacaRiposo(int battiti)
        {
            string risposta = "";

            if (battiti < 60)
            {

                risposta = "Bradicardia";
            }
            else if (battiti > 60 && battiti < 100)
            {
                risposta = "Normale";
            }
            else if (battiti >= 100)
            {
                risposta = "Tachicardia";
            }
            return risposta;
        }
        public static double CalorieUomo(int frequenza, int peso, int eta, int durata)
        {
            double calorie = ((eta * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184;
            calorie = Math.Round(calorie, 0);
            return calorie;
        }
        public static double CalorieDonna(int frequenza, int peso, int eta, int durata)
        {
            double calorie = ((eta * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184;
            calorie = Math.Round(calorie, 0);
            return calorie;
        }

        public static double CalorieCorsa(double kmpercorsi, double pesocorporeo)
        {
            double spesaEnergetica = 0.9 * kmpercorsi * pesocorporeo;
            return spesaEnergetica;
        }
        public static double CalorieCamminata(double kmpercorsi, double pesocorporeo)
        {
            double spesaEnergetica = 0.50 * kmpercorsi * pesocorporeo;
            return spesaEnergetica;
        }

    }
}







