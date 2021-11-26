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
using static Polic.EF.Class1;
using static Polic.ClassHelper.UserClass;
using Polic.EF;
using Polic.Windows.Frame.DoctorPage;

namespace Polic.Windows.Frame
{
    public partial class DoctorRecord : Page
    {
        //List<DoctorViewRecord> record = new List<DoctorViewRecord>();
        public DoctorRecord()
        {
            InitializeComponent();
            listView.ItemsSource = Context.DoctorViewRecord.Where(i => i.DoctorId == person.Id).ToList();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //ListView resultListView = (ListView)sender;
            //PatientView_Result patientView = (PatientView_Result)listView.SelectedItem;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnOpenSession_Click(object sender, RoutedEventArgs e)
        {
            SessionPatient sessionPatient = new SessionPatient();

            DoctorViewRecord record = (DoctorViewRecord)listView.SelectedItem;
            doctorActivePatient = record.Id;
            doctorActiveIdMedCard = record.MedCardId;
            sessionPatient.namePatient.Text = record.FirstName + " " + record.LastName + " " + record.MidleName;

            sessionPatient.ShowDialog();
        }
    }
}
