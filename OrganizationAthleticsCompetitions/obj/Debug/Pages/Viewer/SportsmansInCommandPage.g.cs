﻿#pragma checksum "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1447F178AD994DDC6369AE6E1F0888F85BB059D859DF514D9D4F015191DE462A"
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
    /// SportsmansInCommandPage
    /// </summary>
    public partial class SportsmansInCommandPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvSportsmansInTeam;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTrainersInTeam;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvResults;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/pages/viewer/sportsmansincommandpage" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
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
            this.lvSportsmansInTeam = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.lvTrainersInTeam = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.lvResults = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Pages\Viewer\SportsmansInCommandPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

