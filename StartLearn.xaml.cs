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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartLearn : Window
    {
        public static bool adTumbler = false;
        public StartLearn()
        {
            InitializeComponent();
            dannie.DB = new School();
            frame.mainFrame = MainFrame;
            frame.mainFrame.Navigate(new Uslugi());
        }
        private void buttAuth_Click(object sender, RoutedEventArgs e)
        {
            Auth win = new Auth();
            win.ShowDialog();
            if (adTumbler == true)
            {
                frame.mainFrame.Navigate(new Prosmotr());
            }
        }
    }
}
