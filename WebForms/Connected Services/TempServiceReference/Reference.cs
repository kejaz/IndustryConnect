﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForms.TempServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TempServiceReference.TempServiceSoap")]
    public interface TempServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertFahrenheitToCelsius", ReplyAction="*")]
        double ConvertFahrenheitToCelsius(double fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertFahrenheitToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertFahrenheitToCelsiusAsync(double fahrenheit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TempServiceSoapChannel : WebForms.TempServiceReference.TempServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TempServiceSoapClient : System.ServiceModel.ClientBase<WebForms.TempServiceReference.TempServiceSoap>, WebForms.TempServiceReference.TempServiceSoap {
        
        public TempServiceSoapClient() {
        }
        
        public TempServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TempServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ConvertFahrenheitToCelsius(double fahrenheit) {
            return base.Channel.ConvertFahrenheitToCelsius(fahrenheit);
        }
        
        public System.Threading.Tasks.Task<double> ConvertFahrenheitToCelsiusAsync(double fahrenheit) {
            return base.Channel.ConvertFahrenheitToCelsiusAsync(fahrenheit);
        }
    }
}
