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
    public partial class MedCardPatient : Window
    {
        public MedCardPatient()
        {
            InitializeComponent();
            Console.WriteLine(doctorActiveIdMedCard);
            listView.ItemsSource = Context.ViewDisease.Where(i => i.IdMedCard == doctorActiveIdMedCard).ToList();
            //listViewRepice.ItemsSource = Context.RepiceId.Where(i => i.MedCardId == doctorActiveIdMedCard).ToList();
        }

        private void exitSessionPatient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //doctorActiveIdMedCard = 0;
        }

        private void btnViewB(object sender, RoutedEventArgs e)
        {
            frmMedCard.Content = null;
            //ViewDisease vD = new ViewDisease();
            //vD = (ViewDisease)listView.SelectedItem;
            ViewDisease viewDisease = (ViewDisease)listView.SelectedItem;
            doctorActiveDisease = viewDisease.IdDisease;
            frmMedCard.Navigate(new ViewDiseasePage());
        }
    }
}
