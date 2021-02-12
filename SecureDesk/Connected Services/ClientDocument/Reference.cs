﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureDesk.ClientDocument {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientDocument.IDocumentService")]
    public interface IDocumentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/uploadDocument", ReplyAction="http://tempuri.org/IDocumentService/uploadDocumentResponse")]
        void uploadDocument(byte[] fileByte, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentService/uploadDocument", ReplyAction="http://tempuri.org/IDocumentService/uploadDocumentResponse")]
        System.Threading.Tasks.Task uploadDocumentAsync(byte[] fileByte, string fileName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentServiceChannel : SecureDesk.ClientDocument.IDocumentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentServiceClient : System.ServiceModel.ClientBase<SecureDesk.ClientDocument.IDocumentService>, SecureDesk.ClientDocument.IDocumentService {
        
        public DocumentServiceClient() {
        }
        
        public DocumentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void uploadDocument(byte[] fileByte, string fileName) {
            base.Channel.uploadDocument(fileByte, fileName);
        }
        
        public System.Threading.Tasks.Task uploadDocumentAsync(byte[] fileByte, string fileName) {
            return base.Channel.uploadDocumentAsync(fileByte, fileName);
        }
    }
}
