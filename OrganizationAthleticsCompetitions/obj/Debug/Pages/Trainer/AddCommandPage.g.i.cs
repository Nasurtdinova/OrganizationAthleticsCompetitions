﻿#pragma checksum "..\..\..\..\Pages\Trainer\AddCommandPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA5CC1D786A7991D45B87D484CBACAB9C64DDC80C0FC8D12A44E9EDA1B1D3034"
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
    /// AddCommandPage
    /// </summary>
    public partial class AddCommandPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 38 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCities;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCom;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadImage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lvSportsmans;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSportsman;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/pages/trainer/addcommandpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
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
            this.comboCities = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.imgCom = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.btnLoadImage = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
            this.btnLoadImage.Click += new System.Windows.RoutedEventHandler(this.btnLoadImage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvSportsmans = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btnAddSportsman = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
            this.btnAddSportsman.Click += new System.Windows.RoutedEventHandler(this.btnAddSportsman_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
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
            case 6:
            
            #line 69 "..\..\..\..\Pages\Trainer\AddCommandPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditSportsman_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

