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
using Polic.EF;
using Polic.Windows.Frame.DoctorPage;

namespace Polic.Windows.Frame.DoctorPage
{
    public partial class SessionPatient : Window
    {
        public SessionPatient()
        {
            InitializeComponent();
        }

        private void exitSessionPatient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            doctorActiveIdMedCard = 0;
            doctorActivePatient = 0;
        }

        private void sessionPatientClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            doctorActiveIdMedCard = 0;
            doctorActivePatient = 0;
        }

        //void checkTbxText(string[] text)
        //{


        //}

        private void btnSave(object sender, RoutedEventArgs e)
        {

            bool err = false;
            string errText = "";

            if (tbxComplaints.Text.Count() > 500) { err = true; errText = "В поле 'Жалобы' введено более 500 символов."; }
            else if (tbxJointInspection.Text.Count() > 500) { err = true; errText = "В поле 'Обищий осмотр' введено более 500 символов."; }
            else if (tbxMainDiagnosis.Text.Count() > 500) { err = true; errText = "В поле 'Основной диагноз' введено более 500 символов."; }
            else if (tbxTherapy.Text.Count() > 500) { err = true; errText = "В поле 'Назначенное лечение' введено более 500 символов."; }
            else if (tbxRepice.Text.Count() > 0) 
            {
                if (dpDateStart.Text.Count() == 0) { err = true; errText = "Поле 'Действителен с' не заполнено"; }
                else if (dpDateEnd.Text.Count() == 0) { err = true; errText = "Поле 'Действителен до' не заполнено"; }

                if (err)
                {
                    MessageBox.Show(errText, "Сохранение записи", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    RepiceId repiceId = new RepiceId();
                    repiceId.PreparationName = tbxRepice.Text;
                    repiceId.DateStart = System.DateTime.Parse(dpDateStart.Text);
                    repiceId.DateEnd = System.DateTime.Parse(dpDateEnd.Text);

                    DiseaseHistory diseaseHistory = new DiseaseHistory();
                    diseaseHistory.Complaints = tbxComplaints.Text;
                    diseaseHistory.JointInspection = tbxJointInspection.Text;
                    diseaseHistory.MainDiagnosis = tbxMainDiagnosis.Text;
                    diseaseHistory.Therapy = tbxTherapy.Text;
                    //diseaseHistory.StartTime = System.DateTime.Parse(dpDateStart.Text);
                    //diseaseHistory.EndTime = System.DateTime.Parse(dpDateEnd.Text);
                }
            }
            else if (tbxRepice.Text.Count() == 0)
            {
                if (err)
                {
                    MessageBox.Show(errText, "Сохранение записи", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    DiseaseHistory diseaseHistory = new DiseaseHistory();
                    diseaseHistory.Complaints = tbxComplaints.Text;
                    diseaseHistory.JointInspection = tbxJointInspection.Text;
                    diseaseHistory.MainDiagnosis = tbxMainDiagnosis.Text;
                    diseaseHistory.Therapy = tbxTherapy.Text;
                    //diseaseHistory.StartTime = System.DateTime.Parse(dpDateStart.Text);
                    //diseaseHistory.EndTime = System.DateTime.Parse(dpDateEnd.Text);
                }
            }        
        }

        public int patientId;

        private void btnMedCard(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            patient = Context.Patient.Where(i => i.Id == doctorActivePatient).FirstOrDefault();
            //patientId = patient.MedCardId;
            MedCardPatient medCardPatient = new MedCardPatient();
            medCardPatient.namePatient.Text = patient.FirstName + " " + patient.LastName + " " + patient.MidleName;
            //doctorActiveIdMedCard = Convert.ToInt32(patient.MedCardId);
            //Console.WriteLine(doctorActiveIdMedCard);
            /*essageBox.Show(Convert.ToString(patient.MedCardId));*/
            medCardPatient.ShowDialog();
        }
    }
}
