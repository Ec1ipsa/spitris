﻿#pragma checksum "..\..\Clients.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD237805108975C37A5DC8A88F39B820"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using travelAgency;


namespace travelAgency {
    
    
    /// <summary>
    /// Clients
    /// </summary>
    public partial class Clients : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal travelAgency.Clients clients;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView clientsList;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientBtn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditClientBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteClientBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/travelAgency;component/clients.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Clients.xaml"
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
            this.clients = ((travelAgency.Clients)(target));
            
            #line 10 "..\..\Clients.xaml"
            this.clients.Closing += new System.ComponentModel.CancelEventHandler(this.clients_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.searchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Clients.xaml"
            this.searchBtn.Click += new System.Windows.RoutedEventHandler(this.searchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clientsList = ((System.Windows.Controls.ListView)(target));
            
            #line 50 "..\..\Clients.xaml"
            this.clientsList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.clientsList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Clients.xaml"
            this.AddClientBtn.Click += new System.Windows.RoutedEventHandler(this.AddClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Clients.xaml"
            this.EditClientBtn.Click += new System.Windows.RoutedEventHandler(this.EditClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Clients.xaml"
            this.DeleteClientBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteClientBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

