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
using Polic.EF;
using static Polic.ClassHelper.UserClass;
using static Polic.EF.Class1;

namespace Polic.Windows.Frame.MainDoctorPage
{
    public partial class PatientPage : Page
    {
        public PatientPage()
        {
            InitializeComponent();
            listView.ItemsSource = Context.Patient.ToList();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListView resultListView = (ListView)sender;
            //ViewStaff patientView = (ViewStaff)listView.SelectedItem;
            //staffId = patientView.Id;
            //EditStaffWindowxaml editStaffWindowxaml = new EditStaffWindowxaml();

            //editStaffWindowxaml.tbFirstName.Text = patientView.FirstName;
            //editStaffWindowxaml.tbLastName.Text = patientView.LastName;
            //editStaffWindowxaml.tbMidleName.Text = patientView.MidleName;
            //editStaffWindowxaml.bithDay.Text = patientView.BirthDay.ToString("d");
            //editStaffWindowxaml.cabNum.Text = patientView.CabNumber.ToString();
            //editStaffWindowxaml.tbLogin.Text = patientView.Login;
            //editStaffWindowxaml.passwordBox.Password = patientView.Password;

            //editStaffWindowxaml.cmRole.SelectedIndex = patientView.Role - 1;

            //editStaffWindowxaml.cmSpeciality.SelectedIndex = Convert.ToInt32(patientView.IdSpeciality) - 1;

            //editStaffWindowxaml.ShowDialog();
        }
    }
}
