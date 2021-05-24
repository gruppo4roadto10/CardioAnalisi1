using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCardioAnalisi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {
            if (tbxBattiti.Text != "")
            {
                int battiti = int.Parse(tbxBattiti.Text);
                if (battiti < 60)
                {
                    lblStampa.Content = "Bradicardiaco";
                }

                else if (battiti > 60 && battiti <= 100)
                {
                    lblStampa.Content = "Normale";
                }
                else if (battiti > 100)
                {
                    lblStampa.Content = "Tachicardia";
                }
            }
            else
            {
                MessageBox.Show("Inserisci i battiti!", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnConsigliati_Click(object sender, RoutedEventArgs e)
        {
            if (txbEta.Text != "")
            {
                int eta = int.Parse(txbEta.Text);
                int freq = 220 - eta;
                double max = (freq * 90) / 100;
                double min = (freq * 70) / 100;
                lblBattitiConsigliati.Content = $"Max = {max}, Min = {min}";

            }
            else
            {
                MessageBox.Show("Inserisci l'età!", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnFreqUomo_Click(object sender, RoutedEventArgs e)
        {
            int eta = int.Parse(txbEtà.Text);
            int peso = int.Parse(txbPeso.Text);
            int frequenza = int.Parse(txbFrequenza.Text);
            int durata = int.Parse(txbDurata.Text);
            if (txbEtà.Text != "" || txbPeso.Text != "" || txbFrequenza.Text != "" || txbDurata.Text != "")
            {
                double calorie = ((eta * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184;
                calorie = Math.Round(calorie, 0);
                lblUomo.Content = $"{calorie}";
            }
            else
            {
                MessageBox.Show("Inserisci i dati richiesti", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnFreqDonna_Click_1(object sender, RoutedEventArgs e)
        {
            int eta = int.Parse(txbEtà.Text);
            int peso = int.Parse(txbPeso.Text);
            int frequenza = int.Parse(txbFrequenza.Text);
            int durata = int.Parse(txbDurata.Text);
            if (txbEtà.Text != "" || txbPeso.Text != "" || txbFrequenza.Text != "" || txbDurata.Text != "")
            {
                double calorie = ((eta * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184;
                calorie = Math.Round(calorie, 0);
                lblDonna.Content = $"{calorie}";
            }
            else
            {
                MessageBox.Show("Inserisci i dati richiesti", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnCorsa_Click(object sender, RoutedEventArgs e)
        {
            if (txbKM.Text != "" || txbPesoCorporeo.Text != "")
            {
                int kmPercorsi = int.Parse(txbKM.Text);
                int pesoCorporeo = int.Parse(txbPesoCorporeo.Text);
                double spesaEnergetica = 0.9 * kmPercorsi * pesoCorporeo;
                lblCorsa.Content = $"{spesaEnergetica}";
            }
            else
            {
                MessageBox.Show("Inserisci i dati richiesti", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnCamminata_Click(object sender, RoutedEventArgs e)
        {
            if (txbKM.Text != "" || txbPesoCorporeo.Text != "")
            {
                int kmPercorsi = int.Parse(txbKM.Text);
                int pesoCorporeo = int.Parse(txbPesoCorporeo.Text);
                double spesaEnergetica = 0.50 * kmPercorsi * pesoCorporeo;
                lblCamminata.Content = $"{spesaEnergetica}";
            }
            else
            {
                MessageBox.Show("Inserisci i dati richiesti", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        



    }
}
