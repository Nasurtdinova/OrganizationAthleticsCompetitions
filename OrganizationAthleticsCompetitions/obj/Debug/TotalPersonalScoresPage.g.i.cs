#pragma checksum "..\..\TotalPersonalScoresPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE97B27768CE5FEFD6693A5F9A528BFBF78673FF11CFD993A63BDC0E1FA8982F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// TotalPersonalScoresPage
    /// </summary>
    public partial class TotalPersonalScoresPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\TotalPersonalScoresPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvTotalScore;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TotalPersonalScoresPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvPersonalScore;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\TotalPersonalScoresPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioTotal;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TotalPersonalScoresPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioPersonal;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/totalpersonalscorespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TotalPersonalScoresPage.xaml"
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
            this.lvTotalScore = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.lvPersonalScore = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.radioTotal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 31 "..\..\TotalPersonalScoresPage.xaml"
            this.radioTotal.Click += new System.Windows.RoutedEventHandler(this.radioTotal_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.radioPersonal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 32 "..\..\TotalPersonalScoresPage.xaml"
            this.radioPersonal.Click += new System.Windows.RoutedEventHandler(this.radioPersonal_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

