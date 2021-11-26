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

namespace Polic.Windows.Frame.DoctorPage
{
    public partial class ViewDiseasePage : Page
    {
        public ViewDiseasePage()
        {
            InitializeComponent();
            DiseaseHistory diseaseHistory = Context.DiseaseHistory.Where(i => i.IdDisease == doctorActiveDisease).FirstOrDefault();
            //diseaseHistory = Context.DiseaseHistory.Where(i => i.IdDisease == doctorActiveDisease).FirstOrDefault();
            //var doctor = Context.Staff.Where(i => i.Id == diseaseHistory.IdDoctor).FirstOrDefault();
            nameDoctor.Text = diseaseHistory.Staff.FirstName + " " + diseaseHistory.Staff.LastName + " " + diseaseHistory.Staff.MidleName;
            name1.Text = diseaseHistory.Complaints;
            name2.Text = diseaseHistory.JointInspection;
            name3.Text = diseaseHistory.MainDiagnosis;
            name4.Text = diseaseHistory.Therapy;
        } 

    }
}
