﻿#pragma checksum "..\..\Editar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D76F4B375E1B76D203DB26A9265D8F9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using AgendaPessoal;
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


namespace AgendaPessoal {
    
    
    /// <summary>
    /// Editar
    /// </summary>
    public partial class Editar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvarEdicao;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditarEmail;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditarTelefone;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditarDescricao;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditarNome;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Editar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditarData;
        
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
            System.Uri resourceLocater = new System.Uri("/AgendaPessoal;component/editar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Editar.xaml"
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
            this.btnSalvarEdicao = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Editar.xaml"
            this.btnSalvarEdicao.Click += new System.Windows.RoutedEventHandler(this.btnSalvarEdicao_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEditarEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\Editar.xaml"
            this.txtEditarEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEditarEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtEditarTelefone = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Editar.xaml"
            this.txtEditarTelefone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEditarTelefone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtEditarDescricao = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\Editar.xaml"
            this.txtEditarDescricao.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEditarDescricao_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtEditarNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\Editar.xaml"
            this.txtEditarNome.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEditarNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtEditarData = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Editar.xaml"
            this.txtEditarData.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEditarData_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

