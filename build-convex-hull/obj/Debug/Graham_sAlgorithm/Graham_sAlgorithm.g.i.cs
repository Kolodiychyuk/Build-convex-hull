﻿#pragma checksum "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7C771F647B7CB5BD101BC1D78113F6B60E47216A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConvexHull;
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


namespace ConvexHull.Graham_sA {
    
    
    /// <summary>
    /// Graham_sAlgorithm
    /// </summary>
    public partial class Graham_sAlgorithm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel initialMessage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid workSpace;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ItemsControl;
        
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
            System.Uri resourceLocater = new System.Uri("/build-convex-hull;component/graham_salgorithm/graham_salgorithm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
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
            
            #line 8 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.initialMessage = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.workSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            
            #line 14 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
            this.ItemsControl.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CreatePoint);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\Graham_sAlgorithm\Graham_sAlgorithm.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Clear);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

