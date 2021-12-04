﻿#pragma checksum "..\..\MapSearchAfter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58984E396FEF615C27E1D82F03020AEC412326FC674667996EAEDA0B27E4D1EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CalgaryOS;
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


namespace CalgaryOS {
    
    
    /// <summary>
    /// MapSearchAfter
    /// </summary>
    public partial class MapSearchAfter : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox exploreText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mapText;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button languageButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock searchText;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choiceText;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MapSearchAfter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button enterButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CalgaryOS;component/mapsearchafter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MapSearchAfter.xaml"
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
            
            #line 23 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Explore);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exploreText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 31 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transit);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 39 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Map);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mapText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 47 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Services);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 55 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Taxi);
            
            #line default
            #line hidden
            return;
            case 8:
            this.languageButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MapSearchAfter.xaml"
            this.languageButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            case 9:
            this.searchText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.filterButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\MapSearchAfter.xaml"
            this.filterButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 11:
            this.choiceText = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\MapSearchAfter.xaml"
            this.choiceText.Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 97 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 13:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\MapSearchAfter.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 99 "..\..\MapSearchAfter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 15:
            this.enterButton = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\MapSearchAfter.xaml"
            this.enterButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
