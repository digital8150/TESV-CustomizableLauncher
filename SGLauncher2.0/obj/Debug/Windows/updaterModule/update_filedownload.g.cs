﻿#pragma checksum "..\..\..\..\Windows\updaterModule\update_filedownload.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A0B5D427D6D756BC0D5A5F9E0AF4A92AAC1C5735353E101CA46BCE85A7DFD00"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome6.Fonts;
using FontAwesome6.Fonts.Converters;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using SGLauncher2._0.Windows.updaterModule;
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


namespace SGLauncher2._0.Windows.updaterModule {
    
    
    /// <summary>
    /// update_filedownload
    /// </summary>
    public partial class update_filedownload : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_main;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome6.Fonts.FontAwesome status_icon;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock status_text;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar install_progress;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock install_task;
        
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
            System.Uri resourceLocater = new System.Uri("/Customizable Launcher;component/windows/updatermodule/update_filedownload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
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
            
            #line 15 "..\..\..\..\Windows\updaterModule\update_filedownload.xaml"
            ((SGLauncher2._0.Windows.updaterModule.update_filedownload)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.border_main = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.status_icon = ((FontAwesome6.Fonts.FontAwesome)(target));
            return;
            case 4:
            this.status_text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.install_progress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            this.install_task = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

