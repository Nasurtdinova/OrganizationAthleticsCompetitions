#pragma checksum "..\..\..\Windows\AddEditProgramCompetition.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3DA4DA21B4D329532CD29BDFC3B5F741C4798E04D634544BA8B66D535FCE5A47"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using OrganizationAthleticsCompetitions;
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


namespace OrganizationAthleticsCompetitions {
    
    
    /// <summary>
    /// AddEditProgramCompetition
    /// </summary>
    public partial class AddEditProgramCompetition : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbGender;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboTypeProgram;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboTypeCompetition;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker tpTime;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboGender;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\AddEditProgramCompetition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/windows/addeditprogramcompetition.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddEditProgramCompetition.xaml"
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
            this.tbGender = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.comboTypeProgram = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.comboTypeCompetition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tpTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 6:
            this.comboGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Windows\AddEditProgramCompetition.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

