﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.EmpServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.EmpServiceRef.DevelopmentEmployee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.EmpServiceRef.TraineeEmployees))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EmpSalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int empIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpName {
            get {
                return this.EmpNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpNameField, value) != true)) {
                    this.EmpNameField = value;
                    this.RaisePropertyChanged("EmpName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EmpSalary {
            get {
                return this.EmpSalaryField;
            }
            set {
                if ((this.EmpSalaryField.Equals(value) != true)) {
                    this.EmpSalaryField = value;
                    this.RaisePropertyChanged("EmpSalary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int empId {
            get {
                return this.empIdField;
            }
            set {
                if ((this.empIdField.Equals(value) != true)) {
                    this.empIdField = value;
                    this.RaisePropertyChanged("empId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DevelopmentEmployee", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDataContracts")]
    [System.SerializableAttribute()]
    public partial class DevelopmentEmployee : Client.EmpServiceRef.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProgrammingLanguageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProgrammingLanguage {
            get {
                return this.ProgrammingLanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.ProgrammingLanguageField, value) != true)) {
                    this.ProgrammingLanguageField = value;
                    this.RaisePropertyChanged("ProgrammingLanguage");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TraineeEmployees", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDataContracts")]
    [System.SerializableAttribute()]
    public partial class TraineeEmployees : Client.EmpServiceRef.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.deccansoft.com/wcf", ConfigurationName="EmpServiceRef.IEmpService")]
    public interface IEmpService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/InsertEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/InsertEmpResponse")]
        void InsertEmp(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/InsertEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/InsertEmpResponse")]
        System.Threading.Tasks.Task InsertEmpAsync(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/UpdateEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/UpdateEmpResponse")]
        void UpdateEmp(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/UpdateEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/UpdateEmpResponse")]
        System.Threading.Tasks.Task UpdateEmpAsync(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/DeleteEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/DeleteEmpResponse")]
        void DeleteEmp(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/DeleteEmp", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/DeleteEmpResponse")]
        System.Threading.Tasks.Task DeleteEmpAsync(Client.EmpServiceRef.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/GetEmployees", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/GetEmployeesResponse")]
        Client.EmpServiceRef.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/GetEmployees", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<Client.EmpServiceRef.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/GetEmpDetails", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/GetEmpDetailsResponse")]
        Client.EmpServiceRef.Employee GetEmpDetails(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/wcf/IEmpService/GetEmpDetails", ReplyAction="http://www.deccansoft.com/wcf/IEmpService/GetEmpDetailsResponse")]
        System.Threading.Tasks.Task<Client.EmpServiceRef.Employee> GetEmpDetailsAsync(int empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpServiceChannel : Client.EmpServiceRef.IEmpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpServiceClient : System.ServiceModel.ClientBase<Client.EmpServiceRef.IEmpService>, Client.EmpServiceRef.IEmpService {
        
        public EmpServiceClient() {
        }
        
        public EmpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertEmp(Client.EmpServiceRef.Employee e) {
            base.Channel.InsertEmp(e);
        }
        
        public System.Threading.Tasks.Task InsertEmpAsync(Client.EmpServiceRef.Employee e) {
            return base.Channel.InsertEmpAsync(e);
        }
        
        public void UpdateEmp(Client.EmpServiceRef.Employee e) {
            base.Channel.UpdateEmp(e);
        }
        
        public System.Threading.Tasks.Task UpdateEmpAsync(Client.EmpServiceRef.Employee e) {
            return base.Channel.UpdateEmpAsync(e);
        }
        
        public void DeleteEmp(Client.EmpServiceRef.Employee e) {
            base.Channel.DeleteEmp(e);
        }
        
        public System.Threading.Tasks.Task DeleteEmpAsync(Client.EmpServiceRef.Employee e) {
            return base.Channel.DeleteEmpAsync(e);
        }
        
        public Client.EmpServiceRef.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<Client.EmpServiceRef.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public Client.EmpServiceRef.Employee GetEmpDetails(int empId) {
            return base.Channel.GetEmpDetails(empId);
        }
        
        public System.Threading.Tasks.Task<Client.EmpServiceRef.Employee> GetEmpDetailsAsync(int empId) {
            return base.Channel.GetEmpDetailsAsync(empId);
        }
    }
}