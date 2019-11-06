﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Property", Namespace="http://schemas.datacontract.org/2004/07/PropertyService")]
    [System.SerializableAttribute()]
    public partial class Property : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Children_allowedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CurrentStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LeaseArrDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxNoOfOccupancyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MultipleOccupancyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Pets_allowedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PropertyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResidentStatusField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Children_allowed {
            get {
                return this.Children_allowedField;
            }
            set {
                if ((object.ReferenceEquals(this.Children_allowedField, value) != true)) {
                    this.Children_allowedField = value;
                    this.RaisePropertyChanged("Children_allowed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CurrentStatus {
            get {
                return this.CurrentStatusField;
            }
            set {
                if ((this.CurrentStatusField.Equals(value) != true)) {
                    this.CurrentStatusField = value;
                    this.RaisePropertyChanged("CurrentStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAvailable {
            get {
                return this.IsAvailableField;
            }
            set {
                if ((this.IsAvailableField.Equals(value) != true)) {
                    this.IsAvailableField = value;
                    this.RaisePropertyChanged("IsAvailable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LeaseArrDate {
            get {
                return this.LeaseArrDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LeaseArrDateField, value) != true)) {
                    this.LeaseArrDateField = value;
                    this.RaisePropertyChanged("LeaseArrDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxNoOfOccupancy {
            get {
                return this.MaxNoOfOccupancyField;
            }
            set {
                if ((this.MaxNoOfOccupancyField.Equals(value) != true)) {
                    this.MaxNoOfOccupancyField = value;
                    this.RaisePropertyChanged("MaxNoOfOccupancy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MultipleOccupancy {
            get {
                return this.MultipleOccupancyField;
            }
            set {
                if ((this.MultipleOccupancyField.Equals(value) != true)) {
                    this.MultipleOccupancyField = value;
                    this.RaisePropertyChanged("MultipleOccupancy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pets_allowed {
            get {
                return this.Pets_allowedField;
            }
            set {
                if ((object.ReferenceEquals(this.Pets_allowedField, value) != true)) {
                    this.Pets_allowedField = value;
                    this.RaisePropertyChanged("Pets_allowed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostCode {
            get {
                return this.PostCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostCodeField, value) != true)) {
                    this.PostCodeField = value;
                    this.RaisePropertyChanged("PostCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PropertyID {
            get {
                return this.PropertyIDField;
            }
            set {
                if ((this.PropertyIDField.Equals(value) != true)) {
                    this.PropertyIDField = value;
                    this.RaisePropertyChanged("PropertyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName {
            get {
                return this.PropertyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyNameField, value) != true)) {
                    this.PropertyNameField = value;
                    this.RaisePropertyChanged("PropertyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyPrice {
            get {
                return this.PropertyPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyPriceField, value) != true)) {
                    this.PropertyPriceField = value;
                    this.RaisePropertyChanged("PropertyPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyType {
            get {
                return this.PropertyTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyTypeField, value) != true)) {
                    this.PropertyTypeField = value;
                    this.RaisePropertyChanged("PropertyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResidentStatus {
            get {
                return this.ResidentStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.ResidentStatusField, value) != true)) {
                    this.ResidentStatusField = value;
                    this.RaisePropertyChanged("ResidentStatus");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPropertyService")]
    public interface IPropertyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/SearchPropertyByPostCode", ReplyAction="http://tempuri.org/IPropertyService/SearchPropertyByPostCodeResponse")]
        PropertyClient.ServiceReference1.Property[] SearchPropertyByPostCode(string postCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/SearchPropertyByPostCode", ReplyAction="http://tempuri.org/IPropertyService/SearchPropertyByPostCodeResponse")]
        System.Threading.Tasks.Task<PropertyClient.ServiceReference1.Property[]> SearchPropertyByPostCodeAsync(string postCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/EnterNewProperty", ReplyAction="http://tempuri.org/IPropertyService/EnterNewPropertyResponse")]
        bool EnterNewProperty(PropertyClient.ServiceReference1.Property p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/EnterNewProperty", ReplyAction="http://tempuri.org/IPropertyService/EnterNewPropertyResponse")]
        System.Threading.Tasks.Task<bool> EnterNewPropertyAsync(PropertyClient.ServiceReference1.Property p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/GetAllPropertiesForStudents", ReplyAction="http://tempuri.org/IPropertyService/GetAllPropertiesForStudentsResponse")]
        PropertyClient.ServiceReference1.Property[] GetAllPropertiesForStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyService/GetAllPropertiesForStudents", ReplyAction="http://tempuri.org/IPropertyService/GetAllPropertiesForStudentsResponse")]
        System.Threading.Tasks.Task<PropertyClient.ServiceReference1.Property[]> GetAllPropertiesForStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPropertyServiceChannel : PropertyClient.ServiceReference1.IPropertyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PropertyServiceClient : System.ServiceModel.ClientBase<PropertyClient.ServiceReference1.IPropertyService>, PropertyClient.ServiceReference1.IPropertyService {
        
        public PropertyServiceClient() {
        }
        
        public PropertyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PropertyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropertyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropertyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PropertyClient.ServiceReference1.Property[] SearchPropertyByPostCode(string postCode) {
            return base.Channel.SearchPropertyByPostCode(postCode);
        }
        
        public System.Threading.Tasks.Task<PropertyClient.ServiceReference1.Property[]> SearchPropertyByPostCodeAsync(string postCode) {
            return base.Channel.SearchPropertyByPostCodeAsync(postCode);
        }
        
        public bool EnterNewProperty(PropertyClient.ServiceReference1.Property p) {
            return base.Channel.EnterNewProperty(p);
        }
        
        public System.Threading.Tasks.Task<bool> EnterNewPropertyAsync(PropertyClient.ServiceReference1.Property p) {
            return base.Channel.EnterNewPropertyAsync(p);
        }
        
        public PropertyClient.ServiceReference1.Property[] GetAllPropertiesForStudents() {
            return base.Channel.GetAllPropertiesForStudents();
        }
        
        public System.Threading.Tasks.Task<PropertyClient.ServiceReference1.Property[]> GetAllPropertiesForStudentsAsync() {
            return base.Channel.GetAllPropertiesForStudentsAsync();
        }
    }
}