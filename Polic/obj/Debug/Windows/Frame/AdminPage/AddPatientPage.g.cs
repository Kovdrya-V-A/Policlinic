﻿#pragma checksum "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEB155938FC809EC7783A8C05303EE4E5F473621FE57E103AC2BEF15332AAF83"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Polic.Windows.Frame.AdminPage;
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


namespace Polic.Windows.Frame.AdminPage {
    
    
    /// <summary>
    /// AddPatientPage
    /// </summary>
    public partial class AddPatientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxFirstName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxLastName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxMidleName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpBirthDay;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPolis;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxCompanyName;
        
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
            System.Uri resourceLocater = new System.Uri("/Polic;component/windows/frame/adminpage/addpatientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbxFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxMidleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dpBirthDay = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.tbxPolis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxCompanyName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 47 "..\..\..\..\..\Windows\Frame\AdminPage\AddPatientPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddPatient);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

