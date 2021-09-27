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

namespace Imagen
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
        // Metodos para cambiar la opacidad
        private void AltaRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 1;
        }

        private void MediaRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 0.6;
        }
        private void BajaRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 0.3;
        }

        // Metodos para el stretch
        private void RellenoRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.Fill;
        }
        private void RellenoUniformeRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.UniformToFill;
        }
        private void UniformeRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.Uniform;
        }
        private void NoneRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.None;
        }
    }
}
