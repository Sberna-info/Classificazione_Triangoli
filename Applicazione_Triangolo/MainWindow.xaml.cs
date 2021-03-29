using System;
using Libreria_Triangoli;
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

namespace Applicazione_Triangolo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtLato1.Text != "" && txtLato2.Text != "" && txtLato3.Text != "")
            {
                try
                {
                    double lato1 = double.Parse(txtLato1.Text);
                    double lato2 = double.Parse(txtLato2.Text);
                    double lato3 = double.Parse(txtLato3.Text);

                    if (lato1 <= 0 || lato2 <= 0 || lato3 <= 0)
                        MessageBox.Show("non puoi inserire lati minori di zero", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                    else if (lato1 + lato2 <= lato3 || lato1 + lato3 <= lato2 || lato2 + lato3 <= lato1)
                        MessageBox.Show("questo non è un triangolo", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                    {
                        lblOutputTriangolo.Content = Gestione.OutputTrangolo(lato1, lato2, lato3);
                        lblOutputArea.Content = Gestione.Area(lato1, lato2, lato3);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Inserisci tutti i dati", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
