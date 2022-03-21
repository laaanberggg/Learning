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
using System.Windows.Shapes;

namespace MurzaevIR
{
    /// <summary>
    /// Логика взаимодействия для NewZapis.xaml
    /// </summary>
    public partial class NewZapis : Window
    {
        Service ServiceAcc = new Service();
        List<ClientService> CS = dannie.DB.ClientService.ToList();
        public NewZapis(Service lessAcc)
        {
            InitializeComponent();

            ServiceAcc = lessAcc;
            string name;
            TbTitle.Text = ServiceAcc.Title;
            TbDuration.Text = ServiceAcc.Duration;
            foreach (Client client in dannie.DB.Client)
            {
                name = client.FirstName + " " + client.LastName;
                CbUsers.Items.Add(name);
            }
            CbUsers.SelectedValuePath = "ID";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientService ms = new ClientService();
                ms.StartTime = (System.DateTime)DpDate.SelectedDate;
                ms.ServiceID = ServiceAcc.ID;
                ms.ClientID = CbUsers.SelectedIndex + 1;
                dannie.DB.ClientService.Add(ms);
                dannie.DB.SaveChanges();
                MessageBox.Show("Успешно записано");
            }
            catch
            {
                MessageBox.Show("Запись не выполнена, проверьте ввод");
            }
        }
    }
}
