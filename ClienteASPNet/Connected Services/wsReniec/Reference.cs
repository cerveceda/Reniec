//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteASPNet.wsReniec {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReniec.wsReniecSoap")]
    public interface wsReniecSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarDNI(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsReniecSoapChannel : ClienteASPNet.wsReniec.wsReniecSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsReniecSoapClient : System.ServiceModel.ClientBase<ClienteASPNet.wsReniec.wsReniecSoap>, ClienteASPNet.wsReniec.wsReniecSoap {
        
        public wsReniecSoapClient() {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet BuscarDNI(string dni) {
            return base.Channel.BuscarDNI(dni);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni) {
            return base.Channel.BuscarDNIAsync(dni);
        }
    }
}
