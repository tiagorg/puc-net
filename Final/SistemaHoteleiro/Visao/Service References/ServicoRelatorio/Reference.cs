﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.530
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Visao.ServicoRelatorio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicoRelatorio.IServicoRelatorio")]
    public interface IServicoRelatorio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoRelatorio/ObterQuartos", ReplyAction="http://tempuri.org/IServicoRelatorio/ObterQuartosResponse")]
        Modelo.Dominio.Quarto[] ObterQuartos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoRelatorio/ObterQuartosEmLimpeza", ReplyAction="http://tempuri.org/IServicoRelatorio/ObterQuartosEmLimpezaResponse")]
        Modelo.Dominio.Quarto[] ObterQuartosEmLimpeza();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoRelatorio/ObterQuartosPorCategoria", ReplyAction="http://tempuri.org/IServicoRelatorio/ObterQuartosPorCategoriaResponse")]
        Modelo.Dominio.Quarto[] ObterQuartosPorCategoria(long categoriaDeQuartoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoRelatorio/ObterQuartosDisponiveisPorPeriodo", ReplyAction="http://tempuri.org/IServicoRelatorio/ObterQuartosDisponiveisPorPeriodoResponse")]
        Modelo.Dominio.Quarto[] ObterQuartosDisponiveisPorPeriodo(System.DateTime dataInicio, System.DateTime dataFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoRelatorio/ObterFaturamentoPorPeriodo", ReplyAction="http://tempuri.org/IServicoRelatorio/ObterFaturamentoPorPeriodoResponse")]
        float ObterFaturamentoPorPeriodo(System.DateTime dataInicio, System.DateTime dataFinal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoRelatorioChannel : Visao.ServicoRelatorio.IServicoRelatorio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoRelatorioClient : System.ServiceModel.ClientBase<Visao.ServicoRelatorio.IServicoRelatorio>, Visao.ServicoRelatorio.IServicoRelatorio {
        
        public ServicoRelatorioClient() {
        }
        
        public ServicoRelatorioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoRelatorioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoRelatorioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoRelatorioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Modelo.Dominio.Quarto[] ObterQuartos() {
            return base.Channel.ObterQuartos();
        }
        
        public Modelo.Dominio.Quarto[] ObterQuartosEmLimpeza() {
            return base.Channel.ObterQuartosEmLimpeza();
        }
        
        public Modelo.Dominio.Quarto[] ObterQuartosPorCategoria(long categoriaDeQuartoId) {
            return base.Channel.ObterQuartosPorCategoria(categoriaDeQuartoId);
        }
        
        public Modelo.Dominio.Quarto[] ObterQuartosDisponiveisPorPeriodo(System.DateTime dataInicio, System.DateTime dataFinal) {
            return base.Channel.ObterQuartosDisponiveisPorPeriodo(dataInicio, dataFinal);
        }
        
        public float ObterFaturamentoPorPeriodo(System.DateTime dataInicio, System.DateTime dataFinal) {
            return base.Channel.ObterFaturamentoPorPeriodo(dataInicio, dataFinal);
        }
    }
}