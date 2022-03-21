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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void buttVhod_Click(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Text == "0000")
            {
                StartLearn.adTumbler = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введен неверный пароль","Ошибка");
            }
        }
    }
}
