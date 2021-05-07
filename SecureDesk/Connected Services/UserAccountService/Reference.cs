﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureDesk.UserAccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string accessPINField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateOfRegistrationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string questionAnsweredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int questionSelectedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string saltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool verifiedField;
        
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
        public string accessPIN {
            get {
                return this.accessPINField;
            }
            set {
                if ((object.ReferenceEquals(this.accessPINField, value) != true)) {
                    this.accessPINField = value;
                    this.RaisePropertyChanged("accessPIN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                if ((object.ReferenceEquals(this.dateOfBirthField, value) != true)) {
                    this.dateOfBirthField = value;
                    this.RaisePropertyChanged("dateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dateOfRegistration {
            get {
                return this.dateOfRegistrationField;
            }
            set {
                if ((object.ReferenceEquals(this.dateOfRegistrationField, value) != true)) {
                    this.dateOfRegistrationField = value;
                    this.RaisePropertyChanged("dateOfRegistration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string questionAnswered {
            get {
                return this.questionAnsweredField;
            }
            set {
                if ((object.ReferenceEquals(this.questionAnsweredField, value) != true)) {
                    this.questionAnsweredField = value;
                    this.RaisePropertyChanged("questionAnswered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int questionSelected {
            get {
                return this.questionSelectedField;
            }
            set {
                if ((this.questionSelectedField.Equals(value) != true)) {
                    this.questionSelectedField = value;
                    this.RaisePropertyChanged("questionSelected");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string salt {
            get {
                return this.saltField;
            }
            set {
                if ((object.ReferenceEquals(this.saltField, value) != true)) {
                    this.saltField = value;
                    this.RaisePropertyChanged("salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool verified {
            get {
                return this.verifiedField;
            }
            set {
                if ((this.verifiedField.Equals(value) != true)) {
                    this.verifiedField = value;
                    this.RaisePropertyChanged("verified");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserAccountService.IUserAccountService")]
    public interface IUserAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/getAccountInfo", ReplyAction="http://tempuri.org/IUserAccountService/getAccountInfoResponse")]
        SecureDesk.UserAccountService.User getAccountInfo(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/getAccountInfo", ReplyAction="http://tempuri.org/IUserAccountService/getAccountInfoResponse")]
        System.Threading.Tasks.Task<SecureDesk.UserAccountService.User> getAccountInfoAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/isAuthorized", ReplyAction="http://tempuri.org/IUserAccountService/isAuthorizedResponse")]
        bool isAuthorized(string email, int accessPin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/isAuthorized", ReplyAction="http://tempuri.org/IUserAccountService/isAuthorizedResponse")]
        System.Threading.Tasks.Task<bool> isAuthorizedAsync(string email, int accessPin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/updateUserAccount", ReplyAction="http://tempuri.org/IUserAccountService/updateUserAccountResponse")]
        SecureDesk.UserAccountService.User updateUserAccount(SecureDesk.UserAccountService.User updatedUserInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccountService/updateUserAccount", ReplyAction="http://tempuri.org/IUserAccountService/updateUserAccountResponse")]
        System.Threading.Tasks.Task<SecureDesk.UserAccountService.User> updateUserAccountAsync(SecureDesk.UserAccountService.User updatedUserInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserAccountServiceChannel : SecureDesk.UserAccountService.IUserAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserAccountServiceClient : System.ServiceModel.ClientBase<SecureDesk.UserAccountService.IUserAccountService>, SecureDesk.UserAccountService.IUserAccountService {
        
        public UserAccountServiceClient() {
        }
        
        public UserAccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserAccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SecureDesk.UserAccountService.User getAccountInfo(string email) {
            return base.Channel.getAccountInfo(email);
        }
        
        public System.Threading.Tasks.Task<SecureDesk.UserAccountService.User> getAccountInfoAsync(string email) {
            return base.Channel.getAccountInfoAsync(email);
        }
        
        public bool isAuthorized(string email, int accessPin) {
            return base.Channel.isAuthorized(email, accessPin);
        }
        
        public System.Threading.Tasks.Task<bool> isAuthorizedAsync(string email, int accessPin) {
            return base.Channel.isAuthorizedAsync(email, accessPin);
        }
        
        public SecureDesk.UserAccountService.User updateUserAccount(SecureDesk.UserAccountService.User updatedUserInfo) {
            return base.Channel.updateUserAccount(updatedUserInfo);
        }
        
        public System.Threading.Tasks.Task<SecureDesk.UserAccountService.User> updateUserAccountAsync(SecureDesk.UserAccountService.User updatedUserInfo) {
            return base.Channel.updateUserAccountAsync(updatedUserInfo);
        }
    }
}
