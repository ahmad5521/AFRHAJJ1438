﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFRHAJJ1438.GetLookups {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.Lookups.ExternalHajj.sejel/GetLookupDetailsImpl/Integration/lookup" +
        "s/GetLookupDetailsImpl/Integration/lookups", ConfigurationName="GetLookups.PortType")]
    public interface PortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="/Integration/lookups/GetLookupDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AFRHAJJ1438.GetLookups.GetLookupDetailsResponse GetLookupDetails(AFRHAJJ1438.GetLookups.GetLookupDetailsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="/Integration/lookups/GetLookupDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<AFRHAJJ1438.GetLookups.GetLookupDetailsResponse> GetLookupDetailsAsync(AFRHAJJ1438.GetLookups.GetLookupDetailsRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1")]
    public partial class LOGIN : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uSER_NAMEField;
        
        private string pASSWORDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string USER_NAME {
            get {
                return this.uSER_NAMEField;
            }
            set {
                this.uSER_NAMEField = value;
                this.RaisePropertyChanged("USER_NAME");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string PASSWORD {
            get {
                return this.pASSWORDField;
            }
            set {
                this.pASSWORDField = value;
                this.RaisePropertyChanged("PASSWORD");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1")]
    public partial class REQUEST_INFO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long eNTITY_IDField;
        
        private long rECORD_IDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long ENTITY_ID {
            get {
                return this.eNTITY_IDField;
            }
            set {
                this.eNTITY_IDField = value;
                this.RaisePropertyChanged("ENTITY_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long RECORD_ID {
            get {
                return this.rECORD_IDField;
            }
            set {
                this.rECORD_IDField = value;
                this.RaisePropertyChanged("RECORD_ID");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1")]
    public partial class DETAILSCELL : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cNAMEField;
        
        private string cTYPEField;
        
        private string cVALUEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CNAME {
            get {
                return this.cNAMEField;
            }
            set {
                this.cNAMEField = value;
                this.RaisePropertyChanged("CNAME");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CTYPE {
            get {
                return this.cTYPEField;
            }
            set {
                this.cTYPEField = value;
                this.RaisePropertyChanged("CTYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CVALUE {
            get {
                return this.cVALUEField;
            }
            set {
                this.cVALUEField = value;
                this.RaisePropertyChanged("CVALUE");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1")]
    public partial class RESULT : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLookupDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1", Order=0)]
        public AFRHAJJ1438.GetLookups.LOGIN LOGIN;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1", Order=1)]
        public AFRHAJJ1438.GetLookups.REQUEST_INFO REQUEST_INFO;
        
        public GetLookupDetailsRequest() {
        }
        
        public GetLookupDetailsRequest(AFRHAJJ1438.GetLookups.LOGIN LOGIN, AFRHAJJ1438.GetLookups.REQUEST_INFO REQUEST_INFO) {
            this.LOGIN = LOGIN;
            this.REQUEST_INFO = REQUEST_INFO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLookupDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CELL", IsNullable=false)]
        public AFRHAJJ1438.GetLookups.DETAILSCELL[] DETAILS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://XSD.Hajj.net/ExternalHajj.Gov.Sa/V1", Order=1)]
        public AFRHAJJ1438.GetLookups.RESULT RESULT;
        
        public GetLookupDetailsResponse() {
        }
        
        public GetLookupDetailsResponse(AFRHAJJ1438.GetLookups.DETAILSCELL[] DETAILS, AFRHAJJ1438.GetLookups.RESULT RESULT) {
            this.DETAILS = DETAILS;
            this.RESULT = RESULT;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PortTypeChannel : AFRHAJJ1438.GetLookups.PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortTypeClient : System.ServiceModel.ClientBase<AFRHAJJ1438.GetLookups.PortType>, AFRHAJJ1438.GetLookups.PortType {
        
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
        AFRHAJJ1438.GetLookups.GetLookupDetailsResponse AFRHAJJ1438.GetLookups.PortType.GetLookupDetails(AFRHAJJ1438.GetLookups.GetLookupDetailsRequest request) {
            return base.Channel.GetLookupDetails(request);
        }
        
        public AFRHAJJ1438.GetLookups.DETAILSCELL[] GetLookupDetails(AFRHAJJ1438.GetLookups.LOGIN LOGIN, AFRHAJJ1438.GetLookups.REQUEST_INFO REQUEST_INFO, out AFRHAJJ1438.GetLookups.RESULT RESULT) {
            AFRHAJJ1438.GetLookups.GetLookupDetailsRequest inValue = new AFRHAJJ1438.GetLookups.GetLookupDetailsRequest();
            inValue.LOGIN = LOGIN;
            inValue.REQUEST_INFO = REQUEST_INFO;
            AFRHAJJ1438.GetLookups.GetLookupDetailsResponse retVal = ((AFRHAJJ1438.GetLookups.PortType)(this)).GetLookupDetails(inValue);
            RESULT = retVal.RESULT;
            return retVal.DETAILS;
        }
        
        public System.Threading.Tasks.Task<AFRHAJJ1438.GetLookups.GetLookupDetailsResponse> GetLookupDetailsAsync(AFRHAJJ1438.GetLookups.GetLookupDetailsRequest request) {
            return base.Channel.GetLookupDetailsAsync(request);
        }
    }
}
