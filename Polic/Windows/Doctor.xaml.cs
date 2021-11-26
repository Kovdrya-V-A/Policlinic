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
using static Polic.EF.Class1;
using static Polic.ClassHelper.UserClass;
using Polic.Windows.Frame;

namespace Polic.Windows
{
    public partial class DoctorWindow : Window
    {
        public DoctorWindow()
        {
            InitializeComponent();
            //listView.ItemsSource = Context.RecordList.ToList();
            lbName.Content = person.FirstName + " " + person.LastName + " " + person.MidleName;
            DoctorPage1 doctorPage1 = new DoctorPage1();
            doctorFrame.Navigate(doctorPage1);
        }

        private void tb_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void doctorClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();

        }

        private void btRecord_Click(object sender, RoutedEventArgs e)
        {
            DoctorRecord doctorRecord = new DoctorRecord();
            doctorFrame.Navigate(doctorRecord);
        }
    }
}
