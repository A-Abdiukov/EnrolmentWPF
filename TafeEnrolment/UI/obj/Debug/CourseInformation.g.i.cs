﻿#pragma checksum "..\..\CourseInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED20FBF5421CA54B296E7546CD79AB5ECA8C9AFF8D31A8E8B0B501A7F71ED281"
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
    /// CourseInformation
    /// </summary>
    public partial class CourseInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button courseNotOffered_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subjectsNotAllocated_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clusterUnitCourse_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button courseTimetables_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CourseInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgBreadcrmbs;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/courseinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CourseInformation.xaml"
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
            this.goBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\CourseInformation.xaml"
            this.goBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.goBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.courseNotOffered_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CourseInformation.xaml"
            this.courseNotOffered_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.courseNotOffered_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.subjectsNotAllocated_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\CourseInformation.xaml"
            this.subjectsNotAllocated_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.subjectsNotAllocated_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clusterUnitCourse_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\CourseInformation.xaml"
            this.clusterUnitCourse_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.clusterUnitCourse_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.courseTimetables_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CourseInformation.xaml"
            this.courseTimetables_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.courseTimetables_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgBreadcrmbs = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

