﻿#pragma checksum "..\..\..\Screens\CakeDetailScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87CAB5B0FB853B03DBDD8786C51E4BD45C53FFB7ADEB2D80FD0650A5416896B5"
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
    /// CakeDetailScreen
    /// </summary>
    public partial class CakeDetailScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush mainImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbImages;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCakeName;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPrice;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDescription;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Screens\CakeDetailScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addToCartButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DA3_ShopCake;component/screens/cakedetailscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screens\CakeDetailScreen.xaml"
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
            this.mainImage = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            this.lbImages = ((System.Windows.Controls.ListBox)(target));
            
            #line 45 "..\..\..\Screens\CakeDetailScreen.xaml"
            this.lbImages.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlaceholdersListBox_OnPreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 76 "..\..\..\Screens\CakeDetailScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.exitDetailButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 106 "..\..\..\Screens\CakeDetailScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateDetailButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtCakeName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.addToCartButton = ((System.Windows.Controls.Button)(target));
            
            #line 174 "..\..\..\Screens\CakeDetailScreen.xaml"
            this.addToCartButton.Click += new System.Windows.RoutedEventHandler(this.addToCartButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

