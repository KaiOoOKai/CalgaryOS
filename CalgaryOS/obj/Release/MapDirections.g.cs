﻿#pragma checksum "..\..\MapDirections.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BAF16AFA5A5A668134F9C49F57F3C3F2B4E7ECD477BBDF188A4EF251564B68D9"
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
    /// MapDirections
    /// </summary>
    public partial class MapDirections : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button languageButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button transitSwitchButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock searchText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button instructionText;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button instructionButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox exploreText;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mapText;
        
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
            System.Uri resourceLocater = new System.Uri("/CalgaryOS;component/mapdirections.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MapDirections.xaml"
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
            this.Canvas1 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.languageButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MapDirections.xaml"
            this.languageButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 3:
            this.transitSwitchButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\MapDirections.xaml"
            this.transitSwitchButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.filterButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.instructionText = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.instructionButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\MapDirections.xaml"
            this.instructionButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 71 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Explore);
            
            #line default
            #line hidden
            return;
            case 9:
            this.exploreText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 79 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transit);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 87 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Map);
            
            #line default
            #line hidden
            return;
            case 12:
            this.mapText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 95 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Services);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 103 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Taxi);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
