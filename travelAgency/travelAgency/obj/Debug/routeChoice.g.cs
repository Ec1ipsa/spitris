﻿#pragma checksum "..\..\routeChoice.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55B50995F5A2950C2B62CD37278868B2"
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
    /// routeChoice
    /// </summary>
    public partial class routeChoice : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 71 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label personName;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ClimateListBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CountryListBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HotelListBox;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minDurationBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maxDurationBox;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minCostBox;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maxCostBox;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findRouteBtn;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView routesList;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\routeChoice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectRouteBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/travelAgency;component/routechoice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\routeChoice.xaml"
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
            
            #line 11 "..\..\routeChoice.xaml"
            ((travelAgency.routeChoice)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.routes_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.personName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ClimateListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.CountryListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.HotelListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.minDurationBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.maxDurationBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.minCostBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.maxCostBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.findRouteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\routeChoice.xaml"
            this.findRouteBtn.Click += new System.Windows.RoutedEventHandler(this.findRouteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.routesList = ((System.Windows.Controls.ListView)(target));
            return;
            case 14:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\routeChoice.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.selectRouteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\routeChoice.xaml"
            this.selectRouteBtn.Click += new System.Windows.RoutedEventHandler(this.selectRouteBtn_Click);
            
            #line default
            #line hidden
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
            case 4:
            
            #line 86 "..\..\routeChoice.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.ClimateCheckBox_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 98 "..\..\routeChoice.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.CountryCheckBox_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

