﻿#pragma checksum "..\..\..\Screens\CakeScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7EE57F8027B97563109CDF1B51DFD09D96456C5458D60190BB406071CB67F65"
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
    /// CakeScreen
    /// </summary>
    public partial class CakeScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\..\Screens\CakeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CateName;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Screens\CakeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border itemBorder;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Screens\CakeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ImgItem;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Screens\CakeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LearnMoreButton;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Screens\CakeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToOrderButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DA3_ShopCake;component/screens/cakescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screens\CakeScreen.xaml"
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
            this.CateName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.itemBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.ImgItem = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 4:
            this.LearnMoreButton = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\Screens\CakeScreen.xaml"
            this.LearnMoreButton.Click += new System.Windows.RoutedEventHandler(this.LearnMoreButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddToOrderButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            
            #line 172 "..\..\..\Screens\CakeScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onPurchase);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

