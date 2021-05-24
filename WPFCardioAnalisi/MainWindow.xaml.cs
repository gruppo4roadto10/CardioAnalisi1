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
    }
}
