﻿#pragma checksum "..\..\..\Pages\Pagekab.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0907D0081AF682A15B6F17675C82722A90BA14C56528C0B90F99BBA6AEC561CD"
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
using tan.Pages;


namespace tan.Pages {
    
    
    /// <summary>
    /// Pagekab
    /// </summary>
    public partial class Pagekab : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 29 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock idText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addPersonBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshListBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\Pagekab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listPeopleListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/tan;component/pages/pagekab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Pagekab.xaml"
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
            this.idText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.firstNameText = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Pages\Pagekab.xaml"
            this.firstNameText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.firstNameText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lastNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addPersonBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\Pagekab.xaml"
            this.addPersonBtn.Click += new System.Windows.RoutedEventHandler(this.addPersonBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.refreshListBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\Pagekab.xaml"
            this.refreshListBtn.Click += new System.Windows.RoutedEventHandler(this.refreshListBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\Pagekab.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\Pagekab.xaml"
            this.deleteBtn.Click += new System.Windows.RoutedEventHandler(this.deleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.findBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\Pagekab.xaml"
            this.findBtn.Click += new System.Windows.RoutedEventHandler(this.findBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listPeopleListBox = ((System.Windows.Controls.ListBox)(target));
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 48 "..\..\..\Pages\Pagekab.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
