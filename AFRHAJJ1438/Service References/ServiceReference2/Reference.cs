﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFRHAJJ1438.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendHajMianifestInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AFRHAJJ1438.ServiceReference2.RESULT3 SendHajMianifestInfo([System.ServiceModel.MessageParameterAttribute(Name="SendHajMianifestInfo")] AFRHAJJ1438.ServiceReference2.SendHajMianifestInfo SendHajMianifestInfo1, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendHajMianifestInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT3> SendHajMianifestInfoAsync(AFRHAJJ1438.ServiceReference2.SendHajMianifestInfo SendHajMianifestInfo, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HajjTrip", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AFRHAJJ1438.ServiceReference2.RESULT HajjTrip(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HajjTrip", ReplyAction="*")]
        System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT> HajjTripAsync(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendHajjTrip", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AFRHAJJ1438.ServiceReference2.RESULT SendHajjTrip([System.ServiceModel.MessageParameterAttribute(Name="SendHajjTrip")] AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip1, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendHajjTrip", ReplyAction="*")]
        System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT> SendHajjTripAsync(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SendHajMianifestInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string mANIFEST_IDField;
        
        private long mANIFEST_PRT_IDField;
        
        private long mANIFEST_LTC_IDField;
        
        private long mANIFEST_ROUTE_IDField;
        
        private System.DateTime mANIFEST_TRIP_DATEField;
        
        private long mANIFEST_TRIP_DATE_HIJField;
        
        private long mANIFEST_BI_IDField;
        
        private long mANIFEST_DI_IDField;
        
        private long mANIFEST_HOUSE_IDField;
        
        private long mANIFEST_STATEField;
        
        private string mANIFEST_EST_IDField;
        
        private string mANIFEST_HEB_IDField;
        
        private string vEHICLE_TYPEField;
        
        private string nATIONALITY_BUS_IDField;
        
        private string mANIFEST_TYPEField;
        
        private DETAILS[] mANIFEST_DETAILSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MANIFEST_ID {
            get {
                return this.mANIFEST_IDField;
            }
            set {
                this.mANIFEST_IDField = value;
                this.RaisePropertyChanged("MANIFEST_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long MANIFEST_PRT_ID {
            get {
                return this.mANIFEST_PRT_IDField;
            }
            set {
                this.mANIFEST_PRT_IDField = value;
                this.RaisePropertyChanged("MANIFEST_PRT_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long MANIFEST_LTC_ID {
            get {
                return this.mANIFEST_LTC_IDField;
            }
            set {
                this.mANIFEST_LTC_IDField = value;
                this.RaisePropertyChanged("MANIFEST_LTC_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long MANIFEST_ROUTE_ID {
            get {
                return this.mANIFEST_ROUTE_IDField;
            }
            set {
                this.mANIFEST_ROUTE_IDField = value;
                this.RaisePropertyChanged("MANIFEST_ROUTE_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime MANIFEST_TRIP_DATE {
            get {
                return this.mANIFEST_TRIP_DATEField;
            }
            set {
                this.mANIFEST_TRIP_DATEField = value;
                this.RaisePropertyChanged("MANIFEST_TRIP_DATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public long MANIFEST_TRIP_DATE_HIJ {
            get {
                return this.mANIFEST_TRIP_DATE_HIJField;
            }
            set {
                this.mANIFEST_TRIP_DATE_HIJField = value;
                this.RaisePropertyChanged("MANIFEST_TRIP_DATE_HIJ");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public long MANIFEST_BI_ID {
            get {
                return this.mANIFEST_BI_IDField;
            }
            set {
                this.mANIFEST_BI_IDField = value;
                this.RaisePropertyChanged("MANIFEST_BI_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public long MANIFEST_DI_ID {
            get {
                return this.mANIFEST_DI_IDField;
            }
            set {
                this.mANIFEST_DI_IDField = value;
                this.RaisePropertyChanged("MANIFEST_DI_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public long MANIFEST_HOUSE_ID {
            get {
                return this.mANIFEST_HOUSE_IDField;
            }
            set {
                this.mANIFEST_HOUSE_IDField = value;
                this.RaisePropertyChanged("MANIFEST_HOUSE_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public long MANIFEST_STATE {
            get {
                return this.mANIFEST_STATEField;
            }
            set {
                this.mANIFEST_STATEField = value;
                this.RaisePropertyChanged("MANIFEST_STATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string MANIFEST_EST_ID {
            get {
                return this.mANIFEST_EST_IDField;
            }
            set {
                this.mANIFEST_EST_IDField = value;
                this.RaisePropertyChanged("MANIFEST_EST_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string MANIFEST_HEB_ID {
            get {
                return this.mANIFEST_HEB_IDField;
            }
            set {
                this.mANIFEST_HEB_IDField = value;
                this.RaisePropertyChanged("MANIFEST_HEB_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string VEHICLE_TYPE {
            get {
                return this.vEHICLE_TYPEField;
            }
            set {
                this.vEHICLE_TYPEField = value;
                this.RaisePropertyChanged("VEHICLE_TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string NATIONALITY_BUS_ID {
            get {
                return this.nATIONALITY_BUS_IDField;
            }
            set {
                this.nATIONALITY_BUS_IDField = value;
                this.RaisePropertyChanged("NATIONALITY_BUS_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string MANIFEST_TYPE {
            get {
                return this.mANIFEST_TYPEField;
            }
            set {
                this.mANIFEST_TYPEField = value;
                this.RaisePropertyChanged("MANIFEST_TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
        public DETAILS[] MANIFEST_DETAILS {
            get {
                return this.mANIFEST_DETAILSField;
            }
            set {
                this.mANIFEST_DETAILSField = value;
                this.RaisePropertyChanged("MANIFEST_DETAILS");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class DETAILS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string mANIFEST_PASSPORT_NOField;
        
        private long mANIFEST_NT_IDField;
        
        private string mANIFEST_HD_IDField;
        
        private string mANIFEST_HAJ_TYPEField;
        
        private string mAINFEST_DEPENDENT_NOField;
        
        private long gROUP_IDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MANIFEST_PASSPORT_NO {
            get {
                return this.mANIFEST_PASSPORT_NOField;
            }
            set {
                this.mANIFEST_PASSPORT_NOField = value;
                this.RaisePropertyChanged("MANIFEST_PASSPORT_NO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long MANIFEST_NT_ID {
            get {
                return this.mANIFEST_NT_IDField;
            }
            set {
                this.mANIFEST_NT_IDField = value;
                this.RaisePropertyChanged("MANIFEST_NT_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string MANIFEST_HD_ID {
            get {
                return this.mANIFEST_HD_IDField;
            }
            set {
                this.mANIFEST_HD_IDField = value;
                this.RaisePropertyChanged("MANIFEST_HD_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MANIFEST_HAJ_TYPE {
            get {
                return this.mANIFEST_HAJ_TYPEField;
            }
            set {
                this.mANIFEST_HAJ_TYPEField = value;
                this.RaisePropertyChanged("MANIFEST_HAJ_TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string MAINFEST_DEPENDENT_NO {
            get {
                return this.mAINFEST_DEPENDENT_NOField;
            }
            set {
                this.mAINFEST_DEPENDENT_NOField = value;
                this.RaisePropertyChanged("MAINFEST_DEPENDENT_NO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public long GROUP_ID {
            get {
                return this.gROUP_IDField;
            }
            set {
                this.gROUP_IDField = value;
                this.RaisePropertyChanged("GROUP_ID");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class House : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long hT_HC_IDField;
        
        private HAJJS[] hAJJSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long HT_HC_ID {
            get {
                return this.hT_HC_IDField;
            }
            set {
                this.hT_HC_IDField = value;
                this.RaisePropertyChanged("HT_HC_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public HAJJS[] HAJJS {
            get {
                return this.hAJJSField;
            }
            set {
                this.hAJJSField = value;
                this.RaisePropertyChanged("HAJJS");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class HAJJS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sHT_HD_IDField;
        
        private string sHT_NT_IDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SHT_HD_ID {
            get {
                return this.sHT_HD_IDField;
            }
            set {
                this.sHT_HD_IDField = value;
                this.RaisePropertyChanged("SHT_HD_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SHT_NT_ID {
            get {
                return this.sHT_NT_IDField;
            }
            set {
                this.sHT_NT_IDField = value;
                this.RaisePropertyChanged("SHT_NT_ID");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Flight : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long sHT_FD_IDField;
        
        private HAJJS[] hAJJSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long SHT_FD_ID {
            get {
                return this.sHT_FD_IDField;
            }
            set {
                this.sHT_FD_IDField = value;
                this.RaisePropertyChanged("SHT_FD_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public HAJJS[] HAJJS {
            get {
                return this.hAJJSField;
            }
            set {
                this.hAJJSField = value;
                this.RaisePropertyChanged("HAJJS");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Details : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Flight[] flightsField;
        
        private House[] housesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public Flight[] Flights {
            get {
                return this.flightsField;
            }
            set {
                this.flightsField = value;
                this.RaisePropertyChanged("Flights");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public House[] Houses {
            get {
                return this.housesField;
            }
            set {
                this.housesField = value;
                this.RaisePropertyChanged("Houses");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SendHajjTrip : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sHT_TAFWEEJ_IDField;
        
        private string sHT_NAQABA_CONFIRM_NOField;
        
        private string sHT_EST_IDField;
        
        private string sHT_HEB_IDField;
        
        private string sHT_TRIP_IDField;
        
        private string sHT_LTC_IDField;
        
        private string sHT_BUS_IDField;
        
        private string sHT_DRIVER_IDField;
        
        private string sHT_STATEField;
        
        private string sHT_TYPEField;
        
        private System.DateTime sHT_TRIP_DATEField;
        
        private Details detailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SHT_TAFWEEJ_ID {
            get {
                return this.sHT_TAFWEEJ_IDField;
            }
            set {
                this.sHT_TAFWEEJ_IDField = value;
                this.RaisePropertyChanged("SHT_TAFWEEJ_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SHT_NAQABA_CONFIRM_NO {
            get {
                return this.sHT_NAQABA_CONFIRM_NOField;
            }
            set {
                this.sHT_NAQABA_CONFIRM_NOField = value;
                this.RaisePropertyChanged("SHT_NAQABA_CONFIRM_NO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SHT_EST_ID {
            get {
                return this.sHT_EST_IDField;
            }
            set {
                this.sHT_EST_IDField = value;
                this.RaisePropertyChanged("SHT_EST_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string SHT_HEB_ID {
            get {
                return this.sHT_HEB_IDField;
            }
            set {
                this.sHT_HEB_IDField = value;
                this.RaisePropertyChanged("SHT_HEB_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string SHT_TRIP_ID {
            get {
                return this.sHT_TRIP_IDField;
            }
            set {
                this.sHT_TRIP_IDField = value;
                this.RaisePropertyChanged("SHT_TRIP_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string SHT_LTC_ID {
            get {
                return this.sHT_LTC_IDField;
            }
            set {
                this.sHT_LTC_IDField = value;
                this.RaisePropertyChanged("SHT_LTC_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string SHT_BUS_ID {
            get {
                return this.sHT_BUS_IDField;
            }
            set {
                this.sHT_BUS_IDField = value;
                this.RaisePropertyChanged("SHT_BUS_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string SHT_DRIVER_ID {
            get {
                return this.sHT_DRIVER_IDField;
            }
            set {
                this.sHT_DRIVER_IDField = value;
                this.RaisePropertyChanged("SHT_DRIVER_ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string SHT_STATE {
            get {
                return this.sHT_STATEField;
            }
            set {
                this.sHT_STATEField = value;
                this.RaisePropertyChanged("SHT_STATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string SHT_TYPE {
            get {
                return this.sHT_TYPEField;
            }
            set {
                this.sHT_TYPEField = value;
                this.RaisePropertyChanged("SHT_TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public System.DateTime SHT_TRIP_DATE {
            get {
                return this.sHT_TRIP_DATEField;
            }
            set {
                this.sHT_TRIP_DATEField = value;
                this.RaisePropertyChanged("SHT_TRIP_DATE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public Details Details {
            get {
                return this.detailsField;
            }
            set {
                this.detailsField = value;
                this.RaisePropertyChanged("Details");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RESULT3))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RESULT3 : RESULT {
        
        private long referenceIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long ReferenceID {
            get {
                return this.referenceIDField;
            }
            set {
                this.referenceIDField = value;
                this.RaisePropertyChanged("ReferenceID");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : AFRHAJJ1438.ServiceReference2.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<AFRHAJJ1438.ServiceReference2.WebServiceSoap>, AFRHAJJ1438.ServiceReference2.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AFRHAJJ1438.ServiceReference2.RESULT3 SendHajMianifestInfo(AFRHAJJ1438.ServiceReference2.SendHajMianifestInfo SendHajMianifestInfo1, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.SendHajMianifestInfo(SendHajMianifestInfo1, LOGIN);
        }
        
        public System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT3> SendHajMianifestInfoAsync(AFRHAJJ1438.ServiceReference2.SendHajMianifestInfo SendHajMianifestInfo, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.SendHajMianifestInfoAsync(SendHajMianifestInfo, LOGIN);
        }
        
        public AFRHAJJ1438.ServiceReference2.RESULT HajjTrip(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.HajjTrip(SendHajjTrip, LOGIN);
        }
        
        public System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT> HajjTripAsync(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.HajjTripAsync(SendHajjTrip, LOGIN);
        }
        
        public AFRHAJJ1438.ServiceReference2.RESULT SendHajjTrip(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip1, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.SendHajjTrip(SendHajjTrip1, LOGIN);
        }
        
        public System.Threading.Tasks.Task<AFRHAJJ1438.ServiceReference2.RESULT> SendHajjTripAsync(AFRHAJJ1438.ServiceReference2.SendHajjTrip[] SendHajjTrip, AFRHAJJ1438.ServiceReference2.LOGIN LOGIN) {
            return base.Channel.SendHajjTripAsync(SendHajjTrip, LOGIN);
        }
    }
}
