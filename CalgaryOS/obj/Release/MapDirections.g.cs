﻿#pragma checksum "..\..\MapDirections.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "868E8FBF0DC06A714F80A3DF91AD96F58E3DE6B0821AE27C82CE9E19E48158AE"
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
        
        
        #line 9 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Canvas1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image mapImage;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pointerImage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform translate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button languageButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button transitSwitchButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock searchText;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button instructionText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button instructionButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MapDirections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox exploreText;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\MapDirections.xaml"
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
            this.Grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Canvas1 = ((System.Windows.Controls.Canvas)(target));
            
            #line 12 "..\..\MapDirections.xaml"
            this.Canvas1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas1_MouseDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\MapDirections.xaml"
            this.Canvas1.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas1_MouseUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\MapDirections.xaml"
            this.Canvas1.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas1_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mapImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.pointerImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.translate = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 6:
            this.languageButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MapDirections.xaml"
            this.languageButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 7:
            this.transitSwitchButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\MapDirections.xaml"
            this.transitSwitchButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.searchText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.instructionText = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.instructionButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\MapDirections.xaml"
            this.instructionButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 76 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Explore);
            
            #line default
            #line hidden
            return;
            case 12:
            this.exploreText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 84 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transit);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 92 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Map);
            
            #line default
            #line hidden
            return;
            case 15:
            this.mapText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            
            #line 100 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Services);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 108 "..\..\MapDirections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Taxi);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

