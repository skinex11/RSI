﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlientB.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Kontrakt")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStrumien")]
    public interface IStrumien {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/GetStream", ReplyAction="http://tempuri.org/IStrumien/GetStreamResponse")]
        System.IO.Stream GetStream(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/GetStream", ReplyAction="http://tempuri.org/IStrumien/GetStreamResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IStrumien/GetDataUsingDataContractResponse")]
        KlientB.ServiceReference1.CompositeType GetDataUsingDataContract(KlientB.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStrumien/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IStrumien/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<KlientB.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(KlientB.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStrumienChannel : KlientB.ServiceReference1.IStrumien, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StrumienClient : System.ServiceModel.ClientBase<KlientB.ServiceReference1.IStrumien>, KlientB.ServiceReference1.IStrumien {
        
        public StrumienClient() {
        }
        
        public StrumienClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StrumienClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StrumienClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StrumienClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetStream(string nazwa) {
            return base.Channel.GetStream(nazwa);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string nazwa) {
            return base.Channel.GetStreamAsync(nazwa);
        }
        
        public KlientB.ServiceReference1.CompositeType GetDataUsingDataContract(KlientB.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<KlientB.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(KlientB.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
