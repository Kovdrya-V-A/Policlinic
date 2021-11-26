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
using static ZuevISP11_12.EF.Class1;
using static ZuevISP11_12.ClassHelper.UserClass;

namespace ZuevISP11_12.Windows.Frame
{
    public partial class DoctorRecord : Page
    {
        public DoctorRecord()
        {
            InitializeComponent();
            //listView.ItemsSource = Context.RecordList.ToList();
            listView.ItemsSource = Context.RecordList.ToList();
        }
    }
}
