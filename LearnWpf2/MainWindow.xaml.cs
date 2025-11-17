using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnWpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SingInButton(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string Password = PasswordTexBox.Password.Trim();

            if(login.Length < 5)
            {
                loginTextBox.ToolTip = "Введите логин более 5 символов";
                loginTextBox.Background = Brushes.Red; 
            }
            else if(Password.Length < 8)
            {
                PasswordTexBox.ToolTip = "Введите пароль более 8 символов";
                PasswordTexBox.Background = Brushes.Red;
            }
           else
            {
                loginTextBox.ToolTip = "";
                loginTextBox.Background = Brushes.Transparent;
                PasswordTexBox.ToolTip = "";
                PasswordTexBox.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно вошли");
            }
        }
    }
}