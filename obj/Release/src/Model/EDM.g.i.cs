﻿#pragma checksum "..\..\..\..\src\Model\EDM.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B71EBAE0D1AE0D55003A671EA315BB65A621DD1FEAB7B7C1710F2D80C956C2E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FilterDataGrid;
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


namespace MnS {
    
    
    /// <summary>
    /// EDM
    /// </summary>
    public partial class EDM : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edm_input;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox edm_index;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edm_des;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edm_readt;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_3;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid edm_ref;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox edm_view;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_4;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\src\Model\EDM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid edm_his;
        
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
            System.Uri resourceLocater = new System.Uri("/M+S Power Tool;component/src/model/edm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\src\Model\EDM.xaml"
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
            this.grid_1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.edm_input = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\src\Model\EDM.xaml"
            this.edm_input.KeyUp += new System.Windows.Input.KeyEventHandler(this.EdmInput_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.edm_index = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\src\Model\EDM.xaml"
            this.edm_index.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Infor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grid_2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.edm_des = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.edm_readt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.grid_3 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.edm_ref = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\..\..\src\Model\EDM.xaml"
            this.edm_ref.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EDM_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.edm_view = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.grid_4 = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.edm_his = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

