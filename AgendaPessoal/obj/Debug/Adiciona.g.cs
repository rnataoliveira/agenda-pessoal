﻿#pragma checksum "..\..\Adiciona.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7BD9F38297FA0B678F75E830400031A"
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
    /// Adiciona
    /// </summary>
    public partial class Adiciona : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefone;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtData;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescricao;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Adiciona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarNovoLembrete;
        
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
            System.Uri resourceLocater = new System.Uri("/AgendaPessoal;component/adiciona.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Adiciona.xaml"
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
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\Adiciona.xaml"
            this.txtNome.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\Adiciona.xaml"
            this.txtEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtTelefone = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\Adiciona.xaml"
            this.txtTelefone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTelefone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtData = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\Adiciona.xaml"
            this.txtData.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtData_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDescricao = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\Adiciona.xaml"
            this.txtDescricao.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtDescricao_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCadastrarNovoLembrete = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Adiciona.xaml"
            this.btnCadastrarNovoLembrete.Click += new System.Windows.RoutedEventHandler(this.btnCadastrarNovoLembrete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

