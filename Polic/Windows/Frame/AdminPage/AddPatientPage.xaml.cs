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
using static Polic.EF.Class1;
using static Polic.ClassHelper.UserClass;

namespace Polic.Windows.Frame.AdminPage
{
    public partial class AddPatientPage : Page
    {
        public AddPatientPage()
        {
            InitializeComponent();
        }

        private void btnAddPatient(object sender, RoutedEventArgs e)
        {
            MedCard medCard = new MedCard();
            medCard.NumPolis = int.Parse(tbxPolis.Text);
            medCard.CompanyName = tbxCompanyName.Text;
            Context.MedCard.Add(medCard);
            Context.SaveChanges();

            Patient patient = new Patient();
            patient.FirstName = tbxFirstName.Text;
            patient.LastName = tbxLastName.Text;
            patient.MidleName = tbxMidleName.Text;
            patient.BirthDay = System.DateTime.Parse(dpBirthDay.Text);
            patient.PolisId = int.Parse(tbxPolis.Text);
            var pp = Context.MedCard.Where(i => i.NumPolis == medCard.NumPolis).FirstOrDefault();
            patient.MedCardId = pp.IdCard;
            Context.Patient.Add(patient);
            Context.SaveChanges();
            MessageBox.Show("Пациент успешно прикреплен!", "Прикрепление пациента", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
