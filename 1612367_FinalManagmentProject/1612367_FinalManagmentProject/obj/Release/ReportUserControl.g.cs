﻿#pragma checksum "..\..\ReportUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AF90C69402DF63C4F00AEDB2391BE4D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
    /// ReportUserControl
    /// </summary>
    public partial class ReportUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTimeStatistic;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startDate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker endDate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStatistic;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Content;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameProductlbl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label quantityProductlbl;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameCustomerlbl;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreCustomerlbl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTypeProductReport;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ReportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridInterestReport;
        
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
            System.Uri resourceLocater = new System.Uri("/1612367_FinalManagmentProject;component/reportusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReportUserControl.xaml"
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
            this.cbTimeStatistic = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.startDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.endDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.btnStatistic = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ReportUserControl.xaml"
            this.btnStatistic.Click += new System.Windows.RoutedEventHandler(this.btnStatistic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Content = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.nameProductlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.quantityProductlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.nameCustomerlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.scoreCustomerlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.gridTypeProductReport = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.gridInterestReport = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

