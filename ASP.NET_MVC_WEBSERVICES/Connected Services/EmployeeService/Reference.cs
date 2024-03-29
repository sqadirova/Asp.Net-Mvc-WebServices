﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET_MVC_WEBSERVICES.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="urn:BankOfBaku")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="betweendate", Namespace="urn:BankOfBaku1")]
    [System.SerializableAttribute()]
    public partial class betweendate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime birthdate1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime birthdate2Field;
        
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
        public System.DateTime birthdate1 {
            get {
                return this.birthdate1Field;
            }
            set {
                if ((this.birthdate1Field.Equals(value) != true)) {
                    this.birthdate1Field = value;
                    this.RaisePropertyChanged("birthdate1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime birthdate2 {
            get {
                return this.birthdate2Field;
            }
            set {
                if ((this.birthdate2Field.Equals(value) != true)) {
                    this.birthdate2Field = value;
                    this.RaisePropertyChanged("birthdate2");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IInputService")]
    public interface IInputService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SaveEmployee", ReplyAction="http://tempuri.org/IInputService/SaveEmployeeResponse")]
        string SaveEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SaveEmployee", ReplyAction="http://tempuri.org/IInputService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<string> SaveEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/UpdateEmployee", ReplyAction="http://tempuri.org/IInputService/UpdateEmployeeResponse")]
        string UpdateEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/UpdateEmployee", ReplyAction="http://tempuri.org/IInputService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<string> UpdateEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/DeleteEmployee", ReplyAction="http://tempuri.org/IInputService/DeleteEmployeeResponse")]
        string DeleteEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/DeleteEmployee", ReplyAction="http://tempuri.org/IInputService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<string> DeleteEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SelectAll", ReplyAction="http://tempuri.org/IInputService/SelectAllResponse")]
        ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] SelectAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SelectAll", ReplyAction="http://tempuri.org/IInputService/SelectAllResponse")]
        System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SelectbyID", ReplyAction="http://tempuri.org/IInputService/SelectbyIDResponse")]
        ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] SelectbyID(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/SelectbyID", ReplyAction="http://tempuri.org/IInputService/SelectbyIDResponse")]
        System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectbyIDAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/Selectbydate", ReplyAction="http://tempuri.org/IInputService/SelectbydateResponse")]
        ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] Selectbydate(ASP.NET_MVC_WEBSERVICES.EmployeeService.betweendate b1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInputService/Selectbydate", ReplyAction="http://tempuri.org/IInputService/SelectbydateResponse")]
        System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectbydateAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.betweendate b1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInputServiceChannel : ASP.NET_MVC_WEBSERVICES.EmployeeService.IInputService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InputServiceClient : System.ServiceModel.ClientBase<ASP.NET_MVC_WEBSERVICES.EmployeeService.IInputService>, ASP.NET_MVC_WEBSERVICES.EmployeeService.IInputService {
        
        public InputServiceClient() {
        }
        
        public InputServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InputServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InputServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InputServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SaveEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<string> SaveEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
        
        public string UpdateEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.UpdateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<string> UpdateEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.UpdateEmployeeAsync(employee);
        }
        
        public string DeleteEmployee(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.DeleteEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<string> DeleteEmployeeAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee employee) {
            return base.Channel.DeleteEmployeeAsync(employee);
        }
        
        public ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] SelectAll() {
            return base.Channel.SelectAll();
        }
        
        public System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectAllAsync() {
            return base.Channel.SelectAllAsync();
        }
        
        public ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] SelectbyID(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee p) {
            return base.Channel.SelectbyID(p);
        }
        
        public System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectbyIDAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee p) {
            return base.Channel.SelectbyIDAsync(p);
        }
        
        public ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[] Selectbydate(ASP.NET_MVC_WEBSERVICES.EmployeeService.betweendate b1) {
            return base.Channel.Selectbydate(b1);
        }
        
        public System.Threading.Tasks.Task<ASP.NET_MVC_WEBSERVICES.EmployeeService.Employee[]> SelectbydateAsync(ASP.NET_MVC_WEBSERVICES.EmployeeService.betweendate b1) {
            return base.Channel.SelectbydateAsync(b1);
        }
    }
}
