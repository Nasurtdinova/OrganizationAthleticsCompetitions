﻿#pragma checksum "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "956A6188093320D2494A2E2DE4ED83215FE60099C5FDAB882DE16C19106DDE3E"
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
    /// CompetitionsPage
    /// </summary>
    public partial class CompetitionsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkMonth;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCity;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgFutureCompetitions;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPastCompetitions;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCompet;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/pages/viewer/competitionspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
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
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkMonth = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.checkMonth.Click += new System.Windows.RoutedEventHandler(this.checkMonth_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboCity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.comboCity.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboCity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgFutureCompetitions = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.dgFutureCompetitions.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgFutureCompetitions_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgPastCompetitions = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddCompet = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            this.btnAddCompet.Click += new System.Windows.RoutedEventHandler(this.btnAddCompet_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 44 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnProgram_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 64 "..\..\..\..\Pages\Viewer\CompetitionsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnResult_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

