﻿#pragma checksum "..\..\PanelUsers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56389582AA78A9AA11813210F05FA465"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using RETO2APP;
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


namespace RETO2APP {
    
    
    /// <summary>
    /// PanelUsers
    /// </summary>
    public partial class PanelUsers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\PanelUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModuloClientes;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PanelUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModuloProductos;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PanelUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModuloCatalogos;
        
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
            System.Uri resourceLocater = new System.Uri("/RETO2APP;component/panelusers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelUsers.xaml"
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
            this.ModuloClientes = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\PanelUsers.xaml"
            this.ModuloClientes.Click += new System.Windows.RoutedEventHandler(this.Clientesmodule);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ModuloProductos = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\PanelUsers.xaml"
            this.ModuloProductos.Click += new System.Windows.RoutedEventHandler(this.ProductosModule);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ModuloCatalogos = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PanelUsers.xaml"
            this.ModuloCatalogos.Click += new System.Windows.RoutedEventHandler(this.Catalogosmodule);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\PanelUsers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AsociarModule);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

