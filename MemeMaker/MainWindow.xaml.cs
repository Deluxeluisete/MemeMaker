using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MemeMaker
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object conversor(object value , Type targetType , object parameter , CultureInfo culture)
        {
            bool marcado = (bool)value;
            if (marcado)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
