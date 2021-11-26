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
    public partial class WritePacient : Page
    {
        List<string> listSpeciality = new List<string>();

        public WritePacient()
        {
            InitializeComponent();
            datePicker.DisplayDateStart = DateTime.Now;
            datePicker.DisplayDateEnd = DateTime.Now.AddDays(+14);
            //calendar.DisplayDateStart = DateTime.Now;
            //calendar.DisplayDateEnd = DateTime.Now.AddDays(+14);
            var speciality = Context.DoctorSpeciality.ToList();
            foreach (var i in speciality)
            {
                listSpeciality.Add(i.NameSpeciality);
            }
            this.cmSpeciality.ItemsSource = listSpeciality;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void cmSpeciality_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> listDoctor = new List<string>();
            var doctor = Context.Staff.Where(i => i.IdSpeciality == cmSpeciality.SelectedIndex + 1).ToList();
            foreach (var i in doctor)
            {
                listDoctor.Add(i.FirstName + " " + i.LastName + " " + i.MidleName);
            }
            this.cmDoctor.ItemsSource = listDoctor;

            //DateTime sel = calendar.SelectedDate;
            //tbCalendar.Text = calendar.SelectedDate.ToString();

            DateTime today = DateTime.Today;
            //calendar.BlackoutDates.Add(new CalendarDateRange(today.AddDays(-5), today.AddDays(-3)));

            //datePicker.BlackoutDates.Add(new CalendarDateRange(today.AddDays(-5), today.AddDays(-3)));
            //datetimepicker 
            Console.WriteLine(datePicker.Text);
        }
    }
}
