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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MensajeNombreTextBlock.Tag = "nombre";
            MensajeApellidoTextBlock.Tag = "apellido";
            MensajeEdadTextBlock.Tag = "edad";
        }
        int i = 2;
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox item = (TextBox)sender;
            
            if(e.Key == Key.F1)
            {
                if(i%2 == 0)
                    {
                        item.Visibility = Visibility.Visible;
                    i++;
                    }
                else
                {
                    item.Visibility = Visibility.Hidden;
                    i++;
                }
                
            }
        }
    }
}
