#pragma checksum "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FCE28C8734DC77B4F9416AD00C8232AAF3C9585D8D5694D560B4372D6AD1F24E"
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
    /// EditProfileTPage
    /// </summary>
    public partial class EditProfileTPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditPhoto;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditProfile;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTrainer;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFullName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPhone;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizationAthleticsCompetitions;component/pages/trainer/editprofiletpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
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
            this.btnEditPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
            this.btnEditPhoto.Click += new System.Windows.RoutedEventHandler(this.btnEditPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEditProfile = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\Trainer\EditProfileTPage.xaml"
            this.btnEditProfile.Click += new System.Windows.RoutedEventHandler(this.btnEditProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imgTrainer = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.tbFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

