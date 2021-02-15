﻿#pragma checksum "..\..\StudentInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08DF6A9C1A806D6CFA8A5C9CE8AB361508BBB722225C13C1BBE886F380491665"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// StudentInformation
    /// </summary>
    public partial class StudentInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 11 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgStudentProfiles;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchFullTime;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_SearchPartTime;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\StudentInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_EnrolledNoFees;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/studentinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentInformation.xaml"
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
            this.SearchTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\StudentInformation.xaml"
            this.SearchTextbox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SearchTextbox_MouseClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\StudentInformation.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.goBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\StudentInformation.xaml"
            this.goBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.goBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgStudentProfiles = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.checkbox_SearchFullTime = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\StudentInformation.xaml"
            this.checkbox_SearchFullTime.Checked += new System.Windows.RoutedEventHandler(this.checkbox_SearchFullTime_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkbox_SearchPartTime = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\StudentInformation.xaml"
            this.checkbox_SearchPartTime.Checked += new System.Windows.RoutedEventHandler(this.checkbox_SearchPartTime_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkbox_EnrolledNoFees = ((System.Windows.Controls.CheckBox)(target));
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
            
            #line 24 "..\..\StudentInformation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSelect_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

