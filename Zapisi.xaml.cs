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
    /// Логика взаимодействия для Zapisi.xaml
    /// </summary>
    public partial class Zapisi : Page
    {
        Service job = new Service();
        public Zapisi(Service jobNew)
        {
            InitializeComponent();
            TbName.Text = jobNew.Title.ToString();
            TbPrice.Text = jobNew.Cost.ToString();
            TbTime.Text = (jobNew.DurationInSeconds / 60).ToString();
            TbAbout.Text = "" + jobNew.Description.ToString();
            TbSale.Text = (jobNew.Discount * 100).ToString();
            job = jobNew;
        }

        private void buttNew_Click(object sender, RoutedEventArgs e)
        {
            job.Title = TbName.Text;
            job.Cost = Convert.ToInt32(TbPrice.Text);
            job.DurationInSeconds = Convert.ToInt32(TbTime.Text) * 60;
            job.Description = TbAbout.Text;
            job.Discount = Convert.ToInt32(TbSale.Text) / 100;
            dannie.DB.SaveChanges();
            MessageBox.Show("Запись выполнена", "Запись", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            frame.mainFrame.Navigate(new Prosmotr());
        }
    }
}
