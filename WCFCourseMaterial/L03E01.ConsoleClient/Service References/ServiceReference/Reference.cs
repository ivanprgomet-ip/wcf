﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace L03E01.ConsoleClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://free-web-services.com/soap", ConfigurationName="ServiceReference.addSoap")]
    public interface addSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://free-web-services.com/soap", ReplyAction="*")]
        L03E01.ConsoleClient.ServiceReference.addResponse add(L03E01.ConsoleClient.ServiceReference.addRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://free-web-services.com/soap", ReplyAction="*")]
        System.Threading.Tasks.Task<L03E01.ConsoleClient.ServiceReference.addResponse> addAsync(L03E01.ConsoleClient.ServiceReference.addRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addRequest", WrapperNamespace="http://free-web-services.com/soap", IsWrapped=true)]
    public partial class addRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int b;
        
        public addRequest() {
        }
        
        public addRequest(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addResponse", WrapperNamespace="http://free-web-services.com/soap", IsWrapped=true)]
    public partial class addResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int sum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public double time;
        
        public addResponse() {
        }
        
        public addResponse(int sum, double time) {
            this.sum = sum;
            this.time = time;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface addSoapChannel : L03E01.ConsoleClient.ServiceReference.addSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class addSoapClient : System.ServiceModel.ClientBase<L03E01.ConsoleClient.ServiceReference.addSoap>, L03E01.ConsoleClient.ServiceReference.addSoap {
        
        public addSoapClient() {
        }
        
        public addSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public addSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public addSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public addSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        L03E01.ConsoleClient.ServiceReference.addResponse L03E01.ConsoleClient.ServiceReference.addSoap.add(L03E01.ConsoleClient.ServiceReference.addRequest request) {
            return base.Channel.add(request);
        }
        
        public int add(int a, int b, out double time) {
            L03E01.ConsoleClient.ServiceReference.addRequest inValue = new L03E01.ConsoleClient.ServiceReference.addRequest();
            inValue.a = a;
            inValue.b = b;
            L03E01.ConsoleClient.ServiceReference.addResponse retVal = ((L03E01.ConsoleClient.ServiceReference.addSoap)(this)).add(inValue);
            time = retVal.time;
            return retVal.sum;
        }
        
        public System.Threading.Tasks.Task<L03E01.ConsoleClient.ServiceReference.addResponse> addAsync(L03E01.ConsoleClient.ServiceReference.addRequest request) {
            return base.Channel.addAsync(request);
        }
    }
}
