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
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox item = (TextBox)sender;

            if (e.Key == Key.F1)
            {
                switch (item.Tag.ToString())
                {
                    case "nombre":
                        MensajeNombreTextBlock.Visibility = MensajeNombreTextBlock.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                        break;
                    case "apellido":
                        MensajeApellidoTextBlock.Visibility = MensajeApellidoTextBlock.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                        break;
                }
            }
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.F2)
            {
                try
                {
                    if (int.Parse(EdadTextBox.Text) > 0 && int.Parse(EdadTextBox.Text) <= 100)
                    {
                        MensajeEdadTextBlock.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        MensajeEdadTextBlock.Visibility = Visibility.Visible;
                    }
                }
                catch (FormatException)
                {
                    MensajeEdadTextBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
