﻿#pragma checksum "..\..\Customers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA4D6E0D692A32B0B1C941FCFAF43BA442C9C6E4AAC927E7CCE245940B183219"
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
using WPFApp;


namespace WPFApp {
    
    
    /// <summary>
    /// Customers
    /// </summary>
    public partial class Customers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Quit;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goback;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCustomers;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerID;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerName;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerAddress;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerEmail;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerPhone;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\Customers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reset;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFApp;component/customers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customers.xaml"
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
            
            #line 7 "..\..\Customers.xaml"
            ((WPFApp.Customers)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoad);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Quit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\Customers.xaml"
            this.Quit.Click += new System.Windows.RoutedEventHandler(this.Quit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 48 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 49 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 50 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 57 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 58 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 59 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 13:
            this.goback = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\Customers.xaml"
            this.goback.Click += new System.Windows.RoutedEventHandler(this.goback_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.listCustomers = ((System.Windows.Controls.ListBox)(target));
            
            #line 91 "..\..\Customers.xaml"
            this.listCustomers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listCustomers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 94 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 95 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 96 "..\..\Customers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 18:
            this.customerID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.customerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.customerAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.customerEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.customerPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 23:
            this.reset = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\Customers.xaml"
            this.reset.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
