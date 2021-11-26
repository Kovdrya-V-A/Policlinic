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
using static Polic.ClassHelper.UserClass;
using Polic.Windows.Frame.AdminPage;

namespace Polic.Windows
{
    public partial class AdminWindow : Window
    {
        //WritePacient writePacient = new WritePacient();

        public AdminWindow()
        {
            InitializeComponent();
            lbName.Content = person.FirstName + " " + person.LastName + " " + person.MidleName;
        }

        private void adminClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
        }

        private void tb_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void awb1_Click(object sender, RoutedEventArgs e)
        {
            WritePacient writePacient = new WritePacient();
            frmAdmin.Navigate(writePacient);

        }

        private void awb2_Click(object sender, RoutedEventArgs e)
        {
            frmAdmin.Navigate(new AddPatientPage());
        }

        private void awb3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
