using APAM.Common;
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

namespace APAM.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow _mainWindow;
        private bool _isSuccesful = false;

        public LoginWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void OnLogin(object sender, RoutedEventArgs e)
        {
            var login = this.txtLogin.Text;
            var password = this.txtPassword.Password;

            try
            {
                APAM_Connection.SetConnectionSettings(login, password);
                MessageBox.Show("Succesful! Please, wait for the program to load...");
                _isSuccesful = true;

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong login or password!");
            }

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!_isSuccesful)
                _mainWindow.Close();
        }
    }
}
