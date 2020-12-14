using System.Collections.Generic;
using System.Windows;

namespace Actividad1_PlantillasDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos;
        string rutaImagenes = @"E:\2 DAM 2020-21\DINT\Tema 5\Imagenes\";

        public MainWindow()
        {
            InitializeComponent();

            platos = Plato.GetSamples(rutaImagenes);
            listaComidas.ItemsSource = platos;

            List<string> tiposComida = new List<string>() { "China", "Americana", "Mexicana" };
            tiposComidaComboBox.ItemsSource = tiposComida;
        }
    }
}
