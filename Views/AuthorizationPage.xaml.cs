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

namespace LibraryProject.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Controllers.ClientsController clientsController = new Controllers.ClientsController();
        public AuthorizationPage()
        {
            InitializeComponent();

        }

        private void SignUpBtnClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {

            if(clientsController.CheckUser(LoginTextBox.Text, PasswordTextBox.Text))
            {
                this.NavigationService.Navigate(new MenuAdminPage());

                MainWindow page = (MainWindow)Application.Current.MainWindow;
                page.login = LoginTextBox.Text;
                page.password = PasswordTextBox.Text;
            }
        }
    }
}
