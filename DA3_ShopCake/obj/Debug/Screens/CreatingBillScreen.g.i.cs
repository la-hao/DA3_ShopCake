﻿#pragma checksum "..\..\..\Screens\CreatingBillScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "507B0200F26738E1EAE326A04C6BC0069CEC01D423FC927DB2CF5CB838472ED9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DA3_ShopCake.Screens;
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


namespace DA3_ShopCake.Screens {
    
    
    /// <summary>
    /// CreatingBillScreen
    /// </summary>
    public partial class CreatingBillScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBillId;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCustomorId;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSaleDate;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbSelectedCake;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Screens\CreatingBillScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCost;
        
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
            System.Uri resourceLocater = new System.Uri("/DA3_ShopCake;component/screens/creatingbillscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screens\CreatingBillScreen.xaml"
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
            this.txtBillId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtCustomorId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtCustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSaleDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.lbSelectedCake = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.txtCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 97 "..\..\..\Screens\CreatingBillScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.exitButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 133 "..\..\..\Screens\CreatingBillScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

