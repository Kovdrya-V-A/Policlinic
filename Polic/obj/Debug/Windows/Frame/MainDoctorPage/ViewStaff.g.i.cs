#pragma checksum "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64D29BEAAFC4FCB959DC23E54C50382F09DE41CC5967196F210F88749B2E8670"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using ZuevISP11_12.Windows.Frame.MainDoctorPage;


namespace ZuevISP11_12.Windows.Frame.MainDoctorPage {
    
    
    /// <summary>
    /// ViewStaff
    /// </summary>
    public partial class ViewStaff : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvPatientF;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvPatientL;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvPatientM;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvBirthDay;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvRole;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvSpeciality;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lvCab;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZuevISP11_12;component/windows/frame/maindoctorpage/viewstaff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 12 "..\..\..\..\..\Windows\Frame\MainDoctorPage\ViewStaff.xaml"
            this.listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvPatientF = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 3:
            this.lvPatientL = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.lvPatientM = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.lvBirthDay = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.lvRole = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.lvSpeciality = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.lvCab = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

