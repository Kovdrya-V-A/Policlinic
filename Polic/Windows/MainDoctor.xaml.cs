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
using Polic.Windows.Frame.MainDoctorPage;

namespace Polic.Windows
{
    public partial class MainDoctor : Window
    {
        public bool isActiveFrame = false;

        public MainDoctor()
        {
            InitializeComponent();
            lbName.Content = person.FirstName + " " + person.LastName + " " + person.MidleName;
        }

        private void tb_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mainDoctorClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
        }

        private void btnViewStaff_Click(object sender, RoutedEventArgs e)
        {
            //ViewStaff viewStaff = new ViewStaff();
            //frmMainDoctor.Navigate(viewStaff);
            if (isActiveFrame)
            {
                frmMainDoctor.Content = null;
                while (frmMainDoctor.NavigationService.RemoveBackEntry() != null);
                isActiveFrame = false;
            }
            else
            {
                isActiveFrame = true;
                StaffPage viewStaff = new StaffPage();
                frmMainDoctor.Navigate(viewStaff);
            }
        }

        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            EditStaffWindowxaml editStaffWindowxaml = new EditStaffWindowxaml();
            editStaffWindowxaml.ShowDialog();
            staffId = 0;

            //editStaffWindowxaml.cmRole.SelectedIndex = 0;
            //editStaffWindowxaml.cmSpeciality.SelectedIndex = 0;
        }
    }
}
