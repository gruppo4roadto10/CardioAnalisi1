using System;
using System.Collections.Generic;
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
        public static void GeneraBattiti()
        {
            Random n = new Random();
            using (StreamWriter w = new StreamWriter("File1.txt"))
            {
                for (int i = 0; i < 1440; i++)
                {
                    w.WriteLine(n.Next(50,71));
                }
                w.Flush();
            }
        }
        public static double MediaBattiti(string file)
        {
            double somma = 0, totale;
            using (StreamReader r = new StreamReader(file))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    int n = int.Parse(Console.ReadLine());
                    somma += n;
                }
                totale = somma / 1440;
                totale = Math.Round(totale, 2);
            }
            return totale;

        }
        public static int BattitiaRiposo(string file)
        {
            List<int> dati = new List<int>();
            using (StreamReader r = new StreamReader(file))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    
                    dati.Add(int.Parse(line));
                }
            }
            dati.Sort();
            int min = dati[0];
            return min;
        }
        public static int VariabilitàBattiti(string file)
        {
            List<int> dati = new List<int>();
            using StreamReader r = new StreamReader(file);
            string line;
            while ((line = r.ReadLine()) != null)
            {
                
                dati.Add(int.Parse(line));
            }
            dati.Sort();
            int min = dati[0];
            int max = dati[1439];
            int variabilità = max - min;
            return variabilità;
        }
    }
}







