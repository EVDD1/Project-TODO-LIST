﻿#pragma checksum "..\..\..\Bestandnaam.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B21C5606C36E750FF3C63560DF6CEAA3A4FB12DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using TODO_lijst;


namespace TODO_lijst {
    
    
    /// <summary>
    /// Bestandnaam
    /// </summary>
    public partial class Bestandnaam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Bestandnaam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxbestanden;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Bestandnaam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listboxbestand;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Bestandnaam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbestandNaam;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TODO-lijst;component/bestandnaam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Bestandnaam.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.comboboxbestanden = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\Bestandnaam.xaml"
            this.comboboxbestanden.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbxbestanden_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\Bestandnaam.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Bewerken_click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\Bestandnaam.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Verwijderen_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listboxbestand = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.txtbestandNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 25 "..\..\..\Bestandnaam.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Toevoegen_click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 29 "..\..\..\Bestandnaam.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Sluiten_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

