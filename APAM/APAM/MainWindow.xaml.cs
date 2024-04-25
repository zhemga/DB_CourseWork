using APAM.Common;
using APAM.Views;
using DevExpress.Xpf.Core;
using System.Windows.Input;

namespace APAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private LoginWindow _loginWindow;

        public MainWindow()
        {
            _loginWindow = new LoginWindow(this);
            _loginWindow.ShowDialog();
            InitializeComponent();
        }
    }
}
