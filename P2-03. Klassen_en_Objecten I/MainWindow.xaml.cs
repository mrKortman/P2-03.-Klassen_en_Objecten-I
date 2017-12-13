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
using P2_03.Klassen_en_Objecten_I.src;

namespace P2_03.Klassen_en_Objecten_I
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Car myFirstCar = new Car("Mercedes", "Benz", "X1");
            Car mySecondCar = new Car("BMW", "3", "M");

            lblFirstCar.Content = myFirstCar.type;
            lblSecondCar.Content = mySecondCar.brand;
        }
    }
}
