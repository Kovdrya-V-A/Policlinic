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
using Polic.Windows;

namespace Polic
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = EF.Class1.Context.Staff.Where(i => i.Login == tb_login.Text && i.Password == tb_password.Password).FirstOrDefault();

            if (userAuth != null)
            {
                ClassHelper.UserClass.person = userAuth;

                //MessageBox.Show(userAuth.FirstName + " " + userAuth.LastName + " " + userAuth.MidleName);

                switch (userAuth.Role)
                {
                    case 1: // Глав.врач
                        //MessageBox.Show(userAuth.Role1.NameRole);
                        MainDoctor mainDoctor = new MainDoctor();
                        mainDoctor.Show();
                        this.Close();

                        break;   
                        
                    case 2: // Доктор
                        //MessageBox.Show(userAuth.Role1.NameRole);
                        DoctorWindow Doctor = new DoctorWindow();
                        Doctor.Show();
                        this.Close();

                        break;                    
                    case 3: // Администратор (регистратура)
                        //MessageBox.Show(userAuth.Role1.NameRole);
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();
                        this.Close();

                        break;   
                        
                    case 4: // Пациент ???????!
                        //MessageBox.Show(userAuth.Role1.NameRole);
                        break;

                    default:
                        break;
                }

                //MainWindow mainWindow = new MainWindows();
                //MainWindow.ShowNAvigate();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void clearLogin(object sender, MouseButtonEventArgs e)
        {
            tb_login.Clear();
        }

        private void terminal_click(object sender, RoutedEventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.ShowDialog();
            this.Close();
        }
    }
}
