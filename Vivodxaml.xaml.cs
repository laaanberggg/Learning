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
    /// Логика взаимодействия для Vivodxaml.xaml
    /// </summary>
    public partial class Vivodxaml : Page
    {
        public Vivodxaml()
        {
            InitializeComponent();
            List<ClientService> cs = dannie.DB.ClientService.ToList();
            cs.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            cs.Reverse();
            DgVivod.ItemsSource = cs;
        }
    }
}
