﻿#pragma checksum "..\..\Test.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AE349760EBBBA06366BCE89468CC00DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using _1612367_FinalManagmentProject;


namespace _1612367_FinalManagmentProject {
    
    
    /// <summary>
    /// Test
    /// </summary>
    public partial class Test : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridContent;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExpandMenuButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClollapedMenuButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionContentSlide;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CursorSlide;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MenuList;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Title;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserButton;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shutdownButton;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\Test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel DropMenuUser;
        
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
            System.Uri resourceLocater = new System.Uri("/1612367_FinalManagmentProject;component/test.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Test.xaml"
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
            
            #line 38 "..\..\Test.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ExpandMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Test.xaml"
            this.ExpandMenuButton.Click += new System.Windows.RoutedEventHandler(this.ExpandMenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClollapedMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Test.xaml"
            this.ClollapedMenuButton.Click += new System.Windows.RoutedEventHandler(this.ClollapedMenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TrainsitionContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 7:
            this.CursorSlide = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.MenuList = ((System.Windows.Controls.ListView)(target));
            
            #line 75 "..\..\Test.xaml"
            this.MenuList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MenuList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Title = ((System.Windows.Controls.Grid)(target));
            
            #line 123 "..\..\Test.xaml"
            this.Title.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Title_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.UserButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\Test.xaml"
            this.UserButton.MouseMove += new System.Windows.Input.MouseEventHandler(this.UserButton_MouseMove);
            
            #line default
            #line hidden
            return;
            case 11:
            this.shutdownButton = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\Test.xaml"
            this.shutdownButton.Click += new System.Windows.RoutedEventHandler(this.shutdownButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DropMenuUser = ((System.Windows.Controls.StackPanel)(target));
            
            #line 146 "..\..\Test.xaml"
            this.DropMenuUser.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DropMenuUser_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

