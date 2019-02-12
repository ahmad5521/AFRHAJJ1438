﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFRHAJJ1438._2wayWSDL {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xmlns.example.com/1483948284918/OperationImpl/MOH/Integration", ConfigurationName="_2wayWSDL.PortType")]
    public interface PortType {
        
        // CODEGEN: Generating message contract since the operation Operation is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="/MOH/Integration/2WaySSL", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AFRHAJJ1438._2wayWSDL.OperationResponse Operation(AFRHAJJ1438._2wayWSDL.OperationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="/MOH/Integration/2WaySSL", ReplyAction="*")]
        System.Threading.Tasks.Task<AFRHAJJ1438._2wayWSDL.OperationResponse> OperationAsync(AFRHAJJ1438._2wayWSDL.OperationRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://XSD.Yahajj.net/2WaySSL.Gov.Sa/V1")]
    public partial class Result : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eRROR_CODEField;
        
        private string eRROR_DESCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ERROR_CODE {
            get {
                return this.eRROR_CODEField;
            }
            set {
                this.eRROR_CODEField = value;
                this.RaisePropertyChanged("ERROR_CODE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ERROR_DESC {
            get {
                return this.eRROR_DESCField;
            }
            set {
                this.eRROR_DESCField = value;
                this.RaisePropertyChanged("ERROR_DESC");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OperationRequest {
        
        public OperationRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OperationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://XSD.Yahajj.net/2WaySSL.Gov.Sa/V1", Order=0)]
        public AFRHAJJ1438._2wayWSDL.Result Result;
        
        public OperationResponse() {
        }
        
        public OperationResponse(AFRHAJJ1438._2wayWSDL.Result Result) {
            this.Result = Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PortTypeChannel : AFRHAJJ1438._2wayWSDL.PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortTypeClient : System.ServiceModel.ClientBase<AFRHAJJ1438._2wayWSDL.PortType>, AFRHAJJ1438._2wayWSDL.PortType {
        
        public PortTypeClient() {
        }
        
        public PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AFRHAJJ1438._2wayWSDL.OperationResponse AFRHAJJ1438._2wayWSDL.PortType.Operation(AFRHAJJ1438._2wayWSDL.OperationRequest request) {
            return base.Channel.Operation(request);
        }
        
        public AFRHAJJ1438._2wayWSDL.Result Operation() {
            AFRHAJJ1438._2wayWSDL.OperationRequest inValue = new AFRHAJJ1438._2wayWSDL.OperationRequest();
            AFRHAJJ1438._2wayWSDL.OperationResponse retVal = ((AFRHAJJ1438._2wayWSDL.PortType)(this)).Operation(inValue);
            return retVal.Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AFRHAJJ1438._2wayWSDL.OperationResponse> AFRHAJJ1438._2wayWSDL.PortType.OperationAsync(AFRHAJJ1438._2wayWSDL.OperationRequest request) {
            return base.Channel.OperationAsync(request);
        }
        
        public System.Threading.Tasks.Task<AFRHAJJ1438._2wayWSDL.OperationResponse> OperationAsync() {
            AFRHAJJ1438._2wayWSDL.OperationRequest inValue = new AFRHAJJ1438._2wayWSDL.OperationRequest();
            return ((AFRHAJJ1438._2wayWSDL.PortType)(this)).OperationAsync(inValue);
        }
    }
}
