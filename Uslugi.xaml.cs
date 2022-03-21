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

namespace MurzaevIR
{
    /// <summary>
    /// Логика взаимодействия для Uslugi.xaml
    /// </summary>
    public partial class Uslugi : Page
    {
        List<Service> ServiceStart = dannie.DB.Service.ToList();
        public Uslugi()
        {
            InitializeComponent();
            LVUslugi.ItemsSource = ServiceStart;
        }
    }
}
