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
    /// Логика взаимодействия для Prosmotr.xaml
    /// </summary>
    public partial class Prosmotr : Page
    {
        List<Service> AdminStart = dannie.DB.Service.ToList();
        public Prosmotr()
        {
            InitializeComponent();
            LVUslugi.ItemsSource = AdminStart;
        }

        private void buttRed_Click(object sender, RoutedEventArgs e)
        {
            Button buttRed = (Button)sender;
            int ID = Convert.ToInt32(buttRed.Uid);
            Service jobNew = dannie.DB.Service.FirstOrDefault(x => x.ID == ID);
            frame.mainFrame.Navigate(new Zapisi(jobNew));
        }

        private void buttDel_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int ID = Convert.ToInt32(button.Uid);
            Service zapDel = dannie.DB.Service.FirstOrDefault(x => x.ID == ID);
            dannie.DB.Service.Remove(zapDel);
            dannie.DB.SaveChanges();
            frame.mainFrame.Navigate(new Prosmotr());
            MessageBox.Show("Запись удалена", "Удаление", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
