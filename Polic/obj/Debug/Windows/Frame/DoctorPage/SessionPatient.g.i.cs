﻿#pragma checksum "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "612874140C8B9C8BEA8D8A9ADC350A681E7811D5D2F9FA2F6C239CDACC5E2DB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Polic.Windows.Frame.DoctorPage;
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


namespace Polic.Windows.Frame.DoctorPage {
    
    
    /// <summary>
    /// SessionPatient
    /// </summary>
    public partial class SessionPatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock namePatient;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxComplaints;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxJointInspection;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxMainDiagnosis;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxTherapy;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxRepice;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateStart;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateEnd;
        
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
            System.Uri resourceLocater = new System.Uri("/Polic;component/windows/frame/doctorpage/sessionpatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
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
            
            #line 10 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
            ((Polic.Windows.Frame.DoctorPage.SessionPatient)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.sessionPatientClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.namePatient = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 39 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.exitSessionPatient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbxComplaints = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxJointInspection = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxMainDiagnosis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxTherapy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 69 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSave);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 73 "..\..\..\..\..\Windows\Frame\DoctorPage\SessionPatient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMedCard);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tbxRepice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.dpDateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 12:
            this.dpDateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
