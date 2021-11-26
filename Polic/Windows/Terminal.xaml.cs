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
using Polic.Windows.Frame.Terminal;

namespace Polic.Windows
{
    public partial class Terminal : Window
    {
        public Terminal()
        {
            InitializeComponent();
            frmTerm.Visibility = Visibility.Hidden;
        }

        private void termialClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            
        }

        private void enterPacient_Click(object sender, RoutedEventArgs e)
        {
            frmTerm.Visibility = Visibility.Visible;
            WritePacientTerm writePacientTerm = new WritePacientTerm();
            frmTerm.Navigate(writePacientTerm);
        }

    }
}
