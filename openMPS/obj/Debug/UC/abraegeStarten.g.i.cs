﻿#pragma checksum "..\..\..\UC\abraegeStarten.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBA911A0E72B24F9A47CD70199B2FD137379466F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using de.as1259.openMPS.UC;


namespace de.as1259.openMPS.UC {
    
    
    /// <summary>
    /// abraegeStarten
    /// </summary>
    public partial class abraegeStarten : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid geraeteGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_start;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_senden;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_client;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UC\abraegeStarten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label progressPercent;
        
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
            System.Uri resourceLocater = new System.Uri("/openMPS;component/uc/abraegestarten.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\abraegeStarten.xaml"
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
            this.geraeteGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.bt_start = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\UC\abraegeStarten.xaml"
            this.bt_start.Click += new System.Windows.RoutedEventHandler(this.bt_start_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_senden = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\UC\abraegeStarten.xaml"
            this.bt_senden.Click += new System.Windows.RoutedEventHandler(this.bt_senden_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_client = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UC\abraegeStarten.xaml"
            this.bt_client.Click += new System.Windows.RoutedEventHandler(this.bt_client_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.progress = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 24 "..\..\..\UC\abraegeStarten.xaml"
            this.progress.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.progress_ValueChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\UC\abraegeStarten.xaml"
            this.progress.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.progress_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.progressPercent = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

