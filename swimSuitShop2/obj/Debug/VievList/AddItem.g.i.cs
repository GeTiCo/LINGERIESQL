﻿#pragma checksum "..\..\..\VievList\AddItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E86C109102E5B18C59C6EA516639F89E4190208B786B034A4DB03F164C25F7CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using swimSuitShop2.VievList;


namespace swimSuitShop2.VievList {
    
    
    /// <summary>
    /// AddItem
    /// </summary>
    public partial class AddItem : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCategory;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listViewProducts;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameItem;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialItem;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StructureItem;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InformationItem;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UidItem;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostItem;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\VievList\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SizeItem;
        
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
            System.Uri resourceLocater = new System.Uri("/swimSuitShop2;component/vievlist/additem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VievList\AddItem.xaml"
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
            this.listCategory = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\..\VievList\AddItem.xaml"
            this.listCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listViewProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.NameItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MaterialItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StructureItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.InformationItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.UidItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CostItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.SizeItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 108 "..\..\..\VievList\AddItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_NewList);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 115 "..\..\..\VievList\AddItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_DelList);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 123 "..\..\..\VievList\AddItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 126 "..\..\..\VievList\AddItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewItemClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 59 "..\..\..\VievList\AddItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

