﻿#pragma checksum "..\..\SponsorRacer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "332AED0826AA7D2BD62E63810D77B6AFFD30DE4500206B9DA8B93B8094F901C4"
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
using WSRKart;


namespace WSRKart {
    
    
    /// <summary>
    /// SponsorRider
    /// </summary>
    public partial class SponsorRider : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameSponsor;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Racer;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardholderName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumber;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Month;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Year;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CVC;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelOrganizationName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelCost;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SponsorRacer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cost;
        
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
            System.Uri resourceLocater = new System.Uri("/WSRKart;component/sponsorracer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SponsorRacer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 16 "..\..\SponsorRacer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameSponsor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Racer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\SponsorRacer.xaml"
            this.Racer.DropDownClosed += new System.EventHandler(this.Racer_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CardholderName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CardNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Month = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Year = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CVC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.LabelOrganizationName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.LabelCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Cost = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\SponsorRacer.xaml"
            this.Cost.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TexboxCost_CostChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 61 "..\..\SponsorRacer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Decrease);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 62 "..\..\SponsorRacer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Crease);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 64 "..\..\SponsorRacer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cancel);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 65 "..\..\SponsorRacer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Pay);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

