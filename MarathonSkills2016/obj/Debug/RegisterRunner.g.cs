#pragma checksum "..\..\RegisterRunner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4049A7144A9AA3FD6B8F518C1475E7A5C1125D970B987BE54B1660C08A209E65"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MarathonSkills2016;
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


namespace MarathonSkills2016 {
    
    
    /// <summary>
    /// RegisterRunner
    /// </summary>
    public partial class RegisterRunner : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\RegisterRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IOld_B;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RegisterRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button INew_B;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RegisterRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login_B;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RegisterRunner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_B;
        
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
            System.Uri resourceLocater = new System.Uri("/MarathonSkills2016;component/registerrunner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisterRunner.xaml"
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
            this.IOld_B = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\RegisterRunner.xaml"
            this.IOld_B.Click += new System.Windows.RoutedEventHandler(this.Login_B_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.INew_B = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\RegisterRunner.xaml"
            this.INew_B.Click += new System.Windows.RoutedEventHandler(this.INew_B_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Login_B = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\RegisterRunner.xaml"
            this.Login_B.Click += new System.Windows.RoutedEventHandler(this.Login_B_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Back_B = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\RegisterRunner.xaml"
            this.Back_B.Click += new System.Windows.RoutedEventHandler(this.Back_B_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

