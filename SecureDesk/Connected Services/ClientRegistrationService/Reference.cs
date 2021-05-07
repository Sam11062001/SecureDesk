﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureDesk.ClientRegistrationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
    [System.SerializableAttribute()]
    public partial class CustomException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageToUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorTitleNameField;
        
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
        public string errorMessageToUser {
            get {
                return this.errorMessageToUserField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageToUserField, value) != true)) {
                    this.errorMessageToUserField = value;
                    this.RaisePropertyChanged("errorMessageToUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errorTitleName {
            get {
                return this.errorTitleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.errorTitleNameField, value) != true)) {
                    this.errorTitleNameField = value;
                    this.RaisePropertyChanged("errorTitleName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User Register", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
    [System.SerializableAttribute()]
    public partial class UserRegister : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Date_Of_BirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Email_AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string First_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Last_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Question_AnsweredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Question_Number_SelectedField;
        
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
        public string Date_Of_Birth {
            get {
                return this.Date_Of_BirthField;
            }
            set {
                if ((object.ReferenceEquals(this.Date_Of_BirthField, value) != true)) {
                    this.Date_Of_BirthField = value;
                    this.RaisePropertyChanged("Date_Of_Birth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email_Address {
            get {
                return this.Email_AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.Email_AddressField, value) != true)) {
                    this.Email_AddressField = value;
                    this.RaisePropertyChanged("Email_Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_Name {
            get {
                return this.First_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.First_NameField, value) != true)) {
                    this.First_NameField = value;
                    this.RaisePropertyChanged("First_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_Name {
            get {
                return this.Last_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Last_NameField, value) != true)) {
                    this.Last_NameField = value;
                    this.RaisePropertyChanged("Last_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Question_Answered {
            get {
                return this.Question_AnsweredField;
            }
            set {
                if ((object.ReferenceEquals(this.Question_AnsweredField, value) != true)) {
                    this.Question_AnsweredField = value;
                    this.RaisePropertyChanged("Question_Answered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Question_Number_Selected {
            get {
                return this.Question_Number_SelectedField;
            }
            set {
                if ((this.Question_Number_SelectedField.Equals(value) != true)) {
                    this.Question_Number_SelectedField = value;
                    this.RaisePropertyChanged("Question_Number_Selected");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientRegistrationService.RegistrationService")]
    public interface RegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/getQuestions", ReplyAction="http://tempuri.org/RegistrationService/getQuestionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/getQuestionsCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        string[] getQuestions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/getQuestions", ReplyAction="http://tempuri.org/RegistrationService/getQuestionsResponse")]
        System.Threading.Tasks.Task<string[]> getQuestionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/connectToFirebase", ReplyAction="http://tempuri.org/RegistrationService/connectToFirebaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/connectToFirebaseCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        bool connectToFirebase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/connectToFirebase", ReplyAction="http://tempuri.org/RegistrationService/connectToFirebaseResponse")]
        System.Threading.Tasks.Task<bool> connectToFirebaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/registerNewUser", ReplyAction="http://tempuri.org/RegistrationService/registerNewUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/registerNewUserCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        void registerNewUser(SecureDesk.ClientRegistrationService.UserRegister user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/registerNewUser", ReplyAction="http://tempuri.org/RegistrationService/registerNewUserResponse")]
        System.Threading.Tasks.Task registerNewUserAsync(SecureDesk.ClientRegistrationService.UserRegister user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/sendOTP", ReplyAction="http://tempuri.org/RegistrationService/sendOTPResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/sendOTPCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        bool sendOTP(string email, string userName, bool isForgetPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/sendOTP", ReplyAction="http://tempuri.org/RegistrationService/sendOTPResponse")]
        System.Threading.Tasks.Task<bool> sendOTPAsync(string email, string userName, bool isForgetPassword);
        
        // CODEGEN: Generating message contract since the wrapper name (UserOtpVerification) of message UserOtpVerification does not match the default value (verifyUser)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyUser", ReplyAction="http://tempuri.org/RegistrationService/verifyUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/verifyUserCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        SecureDesk.ClientRegistrationService.OTP_Verified verifyUser(SecureDesk.ClientRegistrationService.UserOtpVerification request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyUser", ReplyAction="http://tempuri.org/RegistrationService/verifyUserResponse")]
        System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> verifyUserAsync(SecureDesk.ClientRegistrationService.UserOtpVerification request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/getUserQuestion", ReplyAction="http://tempuri.org/RegistrationService/getUserQuestionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/getUserQuestionCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        string getUserQuestion(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/getUserQuestion", ReplyAction="http://tempuri.org/RegistrationService/getUserQuestionResponse")]
        System.Threading.Tasks.Task<string> getUserQuestionAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyAnswer", ReplyAction="http://tempuri.org/RegistrationService/verifyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/verifyAnswerCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        bool verifyAnswer(string email, string userAnswer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyAnswer", ReplyAction="http://tempuri.org/RegistrationService/verifyAnswerResponse")]
        System.Threading.Tasks.Task<bool> verifyAnswerAsync(string email, string userAnswer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/resetPassword", ReplyAction="http://tempuri.org/RegistrationService/resetPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/resetPasswordCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        void resetPassword(string email, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/resetPassword", ReplyAction="http://tempuri.org/RegistrationService/resetPasswordResponse")]
        System.Threading.Tasks.Task resetPasswordAsync(string email, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/isUnique", ReplyAction="http://tempuri.org/RegistrationService/isUniqueResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/isUniqueCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        bool isUnique(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/isUnique", ReplyAction="http://tempuri.org/RegistrationService/isUniqueResponse")]
        System.Threading.Tasks.Task<bool> isUniqueAsync(string email);
        
        // CODEGEN: Generating message contract since the wrapper name (UserOtpVerification) of message UserOtpVerification does not match the default value (verifyForgetPassword)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyForgetPassword", ReplyAction="http://tempuri.org/RegistrationService/verifyForgetPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureDesk.ClientRegistrationService.CustomException), Action="http://tempuri.org/RegistrationService/verifyForgetPasswordCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/SecureDesk_WCF_Service.Models")]
        SecureDesk.ClientRegistrationService.OTP_Verified verifyForgetPassword(SecureDesk.ClientRegistrationService.UserOtpVerification request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrationService/verifyForgetPassword", ReplyAction="http://tempuri.org/RegistrationService/verifyForgetPasswordResponse")]
        System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> verifyForgetPasswordAsync(SecureDesk.ClientRegistrationService.UserOtpVerification request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserOtpVerification", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UserOtpVerification {
        
        [System.ServiceModel.MessageHeaderAttribute(Name="One_x0020_Time_x0020_Password_x0020_for_x0020_Verification", Namespace="http://tempuri.org/")]
        public string OneTimePasswordforVerification;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string User_Email_Address;
        
        public UserOtpVerification() {
        }
        
        public UserOtpVerification(string OneTimePasswordforVerification, string User_Email_Address) {
            this.OneTimePasswordforVerification = OneTimePasswordforVerification;
            this.User_Email_Address = User_Email_Address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="User OTP Verified by Service", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OTP_Verified {
        
        [System.ServiceModel.MessageHeaderAttribute(Name="User_x0020_OTP_x0020_Verification_x0020_Result", Namespace="http://tempuri.org/")]
        public bool UserOTPVerificationResult;
        
        public OTP_Verified() {
        }
        
        public OTP_Verified(bool UserOTPVerificationResult) {
            this.UserOTPVerificationResult = UserOTPVerificationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegistrationServiceChannel : SecureDesk.ClientRegistrationService.RegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrationServiceClient : System.ServiceModel.ClientBase<SecureDesk.ClientRegistrationService.RegistrationService>, SecureDesk.ClientRegistrationService.RegistrationService {
        
        public RegistrationServiceClient() {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getQuestions() {
            return base.Channel.getQuestions();
        }
        
        public System.Threading.Tasks.Task<string[]> getQuestionsAsync() {
            return base.Channel.getQuestionsAsync();
        }
        
        public bool connectToFirebase() {
            return base.Channel.connectToFirebase();
        }
        
        public System.Threading.Tasks.Task<bool> connectToFirebaseAsync() {
            return base.Channel.connectToFirebaseAsync();
        }
        
        public void registerNewUser(SecureDesk.ClientRegistrationService.UserRegister user) {
            base.Channel.registerNewUser(user);
        }
        
        public System.Threading.Tasks.Task registerNewUserAsync(SecureDesk.ClientRegistrationService.UserRegister user) {
            return base.Channel.registerNewUserAsync(user);
        }
        
        public bool sendOTP(string email, string userName, bool isForgetPassword) {
            return base.Channel.sendOTP(email, userName, isForgetPassword);
        }
        
        public System.Threading.Tasks.Task<bool> sendOTPAsync(string email, string userName, bool isForgetPassword) {
            return base.Channel.sendOTPAsync(email, userName, isForgetPassword);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SecureDesk.ClientRegistrationService.OTP_Verified SecureDesk.ClientRegistrationService.RegistrationService.verifyUser(SecureDesk.ClientRegistrationService.UserOtpVerification request) {
            return base.Channel.verifyUser(request);
        }
        
        public bool verifyUser(string OneTimePasswordforVerification, string User_Email_Address) {
            SecureDesk.ClientRegistrationService.UserOtpVerification inValue = new SecureDesk.ClientRegistrationService.UserOtpVerification();
            inValue.OneTimePasswordforVerification = OneTimePasswordforVerification;
            inValue.User_Email_Address = User_Email_Address;
            SecureDesk.ClientRegistrationService.OTP_Verified retVal = ((SecureDesk.ClientRegistrationService.RegistrationService)(this)).verifyUser(inValue);
            return retVal.UserOTPVerificationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> SecureDesk.ClientRegistrationService.RegistrationService.verifyUserAsync(SecureDesk.ClientRegistrationService.UserOtpVerification request) {
            return base.Channel.verifyUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> verifyUserAsync(string OneTimePasswordforVerification, string User_Email_Address) {
            SecureDesk.ClientRegistrationService.UserOtpVerification inValue = new SecureDesk.ClientRegistrationService.UserOtpVerification();
            inValue.OneTimePasswordforVerification = OneTimePasswordforVerification;
            inValue.User_Email_Address = User_Email_Address;
            return ((SecureDesk.ClientRegistrationService.RegistrationService)(this)).verifyUserAsync(inValue);
        }
        
        public string getUserQuestion(string email) {
            return base.Channel.getUserQuestion(email);
        }
        
        public System.Threading.Tasks.Task<string> getUserQuestionAsync(string email) {
            return base.Channel.getUserQuestionAsync(email);
        }
        
        public bool verifyAnswer(string email, string userAnswer) {
            return base.Channel.verifyAnswer(email, userAnswer);
        }
        
        public System.Threading.Tasks.Task<bool> verifyAnswerAsync(string email, string userAnswer) {
            return base.Channel.verifyAnswerAsync(email, userAnswer);
        }
        
        public void resetPassword(string email, string newPassword) {
            base.Channel.resetPassword(email, newPassword);
        }
        
        public System.Threading.Tasks.Task resetPasswordAsync(string email, string newPassword) {
            return base.Channel.resetPasswordAsync(email, newPassword);
        }
        
        public bool isUnique(string email) {
            return base.Channel.isUnique(email);
        }
        
        public System.Threading.Tasks.Task<bool> isUniqueAsync(string email) {
            return base.Channel.isUniqueAsync(email);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SecureDesk.ClientRegistrationService.OTP_Verified SecureDesk.ClientRegistrationService.RegistrationService.verifyForgetPassword(SecureDesk.ClientRegistrationService.UserOtpVerification request) {
            return base.Channel.verifyForgetPassword(request);
        }
        
        public bool verifyForgetPassword(string OneTimePasswordforVerification, string User_Email_Address) {
            SecureDesk.ClientRegistrationService.UserOtpVerification inValue = new SecureDesk.ClientRegistrationService.UserOtpVerification();
            inValue.OneTimePasswordforVerification = OneTimePasswordforVerification;
            inValue.User_Email_Address = User_Email_Address;
            SecureDesk.ClientRegistrationService.OTP_Verified retVal = ((SecureDesk.ClientRegistrationService.RegistrationService)(this)).verifyForgetPassword(inValue);
            return retVal.UserOTPVerificationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> SecureDesk.ClientRegistrationService.RegistrationService.verifyForgetPasswordAsync(SecureDesk.ClientRegistrationService.UserOtpVerification request) {
            return base.Channel.verifyForgetPasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<SecureDesk.ClientRegistrationService.OTP_Verified> verifyForgetPasswordAsync(string OneTimePasswordforVerification, string User_Email_Address) {
            SecureDesk.ClientRegistrationService.UserOtpVerification inValue = new SecureDesk.ClientRegistrationService.UserOtpVerification();
            inValue.OneTimePasswordforVerification = OneTimePasswordforVerification;
            inValue.User_Email_Address = User_Email_Address;
            return ((SecureDesk.ClientRegistrationService.RegistrationService)(this)).verifyForgetPasswordAsync(inValue);
        }
    }
}
