using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
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

namespace BotonTroll
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random ubicacionBoton = new Random();
            int numero1 = ubicacionBoton.Next(1, 500);
            int numero2 = ubicacionBoton.Next(1, 380);
            int numero3 = ubicacionBoton.Next(1, 500);
            int numero4 = ubicacionBoton.Next(1, 380);

            Boton1.Margin = Padding(numero1, numero2, numero3, numero4);

            SoundPlayer player = new SoundPlayer(@"C:\Users\danie\OneDrive\Documentos\BotonTroll\BotonTroll\chamba.wav");
            player.Play();

            Random ColorBase = new Random();
            byte color1 = (byte)ColorBase.Next(0, 255);
            byte color2 = (byte)ColorBase.Next(0, 255);
            byte color3 = (byte)ColorBase.Next(0, 255);
            byte color4 = (byte)ColorBase.Next(0, 255);

            Color randomColor = Color.FromArgb(color1, color2, color3, color4);
            Boton1.Background = new SolidColorBrush(randomColor);



        }

        private Thickness Padding(int v1, int v2, int v3, int v4)
        {
            return new Thickness(v1, v2, v3, v4);
        }
    }
}
