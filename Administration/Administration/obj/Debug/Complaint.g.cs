﻿#pragma checksum "..\..\Complaint.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B1136F243D1FC556AAEEC9A0E60BFDB704FC98F669437121A9C4094AD156799"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Administration;
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


namespace Administration {
    
    
    /// <summary>
    /// Complaint
    /// </summary>
    public partial class Complaint : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid data;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button print;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock cont;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock adress;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Complaint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rezol;
        
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
            System.Uri resourceLocater = new System.Uri("/Administration;component/complaint.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Complaint.xaml"
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
            this.data = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\Complaint.xaml"
            this.data.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.data_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Complaint.xaml"
            this.data.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.data_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Complaint.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Complaint.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Complaint.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.print = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Complaint.xaml"
            this.print.Click += new System.Windows.RoutedEventHandler(this.print_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\Complaint.xaml"
            this.combo.DropDownClosed += new System.EventHandler(this.combo_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.search = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\Complaint.xaml"
            this.search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cont = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.adress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.rezol = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

