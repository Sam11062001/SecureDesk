﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureDesk.DiaryService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DiaryService.IPersonalDiary")]
    public interface IPersonalDiary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonalDiary/UploadDayThought", ReplyAction="http://tempuri.org/IPersonalDiary/UploadDayThoughtResponse")]
        string UploadDayThought(string date, string title, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonalDiary/UploadDayThought", ReplyAction="http://tempuri.org/IPersonalDiary/UploadDayThoughtResponse")]
        System.Threading.Tasks.Task<string> UploadDayThoughtAsync(string date, string title, string content);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonalDiaryChannel : SecureDesk.DiaryService.IPersonalDiary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonalDiaryClient : System.ServiceModel.ClientBase<SecureDesk.DiaryService.IPersonalDiary>, SecureDesk.DiaryService.IPersonalDiary {
        
        public PersonalDiaryClient() {
        }
        
        public PersonalDiaryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonalDiaryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonalDiaryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonalDiaryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string UploadDayThought(string date, string title, string content) {
            return base.Channel.UploadDayThought(date, title, content);
        }
        
        public System.Threading.Tasks.Task<string> UploadDayThoughtAsync(string date, string title, string content) {
            return base.Channel.UploadDayThoughtAsync(date, title, content);
        }
    }
}
