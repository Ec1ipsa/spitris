﻿#pragma checksum "..\..\tourPurchase.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "871A3D3094DB8550DB234027838DC081"
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
    /// tourPurchase
    /// </summary>
    public partial class tourPurchase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label personName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView routesList;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dateBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox discountBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\tourPurchase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sellTourBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/travelAgency;component/tourpurchase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\tourPurchase.xaml"
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
            this.personName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.routesList = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.dateBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.countBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.discountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.priceBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sellTourBtn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\tourPurchase.xaml"
            this.sellTourBtn.Click += new System.Windows.RoutedEventHandler(this.sellTourBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

