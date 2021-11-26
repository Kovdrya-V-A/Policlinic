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
using Polic.EF;
using static Polic.EF.Class1;
using static Polic.ClassHelper.UserClass;

namespace Polic.Windows.Frame.MainDoctorPage
{

    public partial class EditStaffWindowxaml : Window
    {
        List<string> listRole = new List<string>();
        List<string> listSpeciality = new List<string>();

        public EditStaffWindowxaml()
        {
            InitializeComponent();
            var role = Context.Role.ToList();
            foreach (var i in role)
            {
                listRole.Add(i.NameRole);
            }

            var speciality = Context.DoctorSpeciality.ToList();
            foreach (var i in speciality)
            {
                listSpeciality.Add(i.NameSpeciality);
            }
            this.cmRole.ItemsSource = listRole;
            this.cmSpeciality.ItemsSource = listSpeciality;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //ViewStaff patientView = new ViewStaff();

            var staff = Context.Staff.Where(i => i.Id == staffId).FirstOrDefault();

            Console.WriteLine(staff);

            if (staff != null)
            {
                staff.FirstName = this.tbFirstName.Text;
                staff.LastName = this.tbLastName.Text;
                staff.MidleName = this.tbMidleName.Text;
                staff.BirthDay = DateTime.Parse(this.bithDay.Text);
                staff.CabNumber = int.Parse(this.cabNum.Text);
                staff.Login = this.tbLogin.Text;
                staff.Password = this.passwordBox.Password;
                Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                
            }
            else
            {
                //MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Context.Staff.Add(new Staff
                {
                    FirstName = this.tbFirstName.Text,
                    LastName = this.tbLastName.Text,
                    MidleName = this.tbMidleName.Text,
                    Role = this.cmRole.SelectedIndex + 1,
                    BirthDay = DateTime.Parse(this.bithDay.Text),
                    CabNumber = int.Parse(this.cabNum.Text),
                    Login = this.tbLogin.Text,
                    Password = this.passwordBox.Password,
                    IdSpeciality = cmSpeciality.SelectedIndex + 1
                }) ;
                Context.SaveChanges();
                MessageBox.Show("Сотрудник добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            

            //Console.WriteLine(staff.Login);

            
        }
    }
}
