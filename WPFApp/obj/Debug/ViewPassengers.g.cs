#pragma checksum "..\..\ViewPassengers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DEDB45BDD841011F695111B1A6E32139782A7ED21BA73DD50839476C97971C9"
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
    /// ViewPassengers
    /// </summary>
    public partial class ViewPassengers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Quit;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goback;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listPassengers;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passengerID;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerID;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\ViewPassengers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox flightID;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\ViewPassengers.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WPFApp;component/viewpassengers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewPassengers.xaml"
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
            
            #line 7 "..\..\ViewPassengers.xaml"
            ((WPFApp.ViewPassengers)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoad);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Quit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\ViewPassengers.xaml"
            this.Quit.Click += new System.Windows.RoutedEventHandler(this.Quit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 48 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 49 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 50 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 57 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 58 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 59 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 13:
            this.goback = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\ViewPassengers.xaml"
            this.goback.Click += new System.Windows.RoutedEventHandler(this.goback_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.listPassengers = ((System.Windows.Controls.ListBox)(target));
            
            #line 91 "..\..\ViewPassengers.xaml"
            this.listPassengers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listPassengers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 94 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertEvent);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 95 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEvent);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 96 "..\..\ViewPassengers.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent);
            
            #line default
            #line hidden
            return;
            case 18:
            this.passengerID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.customerID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.flightID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.reset = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\ViewPassengers.xaml"
            this.reset.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

