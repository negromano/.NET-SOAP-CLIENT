﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSoap.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Services")]
    public interface Services {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSoap.ServiceReference1.listResponse list(ClienteSoap.ServiceReference1.listRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.listResponse> listAsync(ClienteSoap.ServiceReference1.listRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSoap.ServiceReference1.deleteResponse delete(ClienteSoap.ServiceReference1.deleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.deleteResponse> deleteAsync(ClienteSoap.ServiceReference1.deleteRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSoap.ServiceReference1.readResponse read(ClienteSoap.ServiceReference1.readRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.readResponse> readAsync(ClienteSoap.ServiceReference1.readRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSoap.ServiceReference1.createResponse create(ClienteSoap.ServiceReference1.createRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.createResponse> createAsync(ClienteSoap.ServiceReference1.createRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteSoap.ServiceReference1.updateResponse update(ClienteSoap.ServiceReference1.updateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.updateResponse> updateAsync(ClienteSoap.ServiceReference1.updateRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class footballer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string clubField;
        
        private string forenameField;
        
        private double heightField;
        
        private string idField;
        
        private int numberField;
        
        private string positionField;
        
        private string surnameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string club {
            get {
                return this.clubField;
            }
            set {
                this.clubField = value;
                this.RaisePropertyChanged("club");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string forename {
            get {
                return this.forenameField;
            }
            set {
                this.forenameField = value;
                this.RaisePropertyChanged("forename");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
                this.RaisePropertyChanged("height");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
                this.RaisePropertyChanged("number");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
                this.RaisePropertyChanged("surname");
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class listRequest {
        
        public listRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class listResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSoap.ServiceReference1.footballer[] @return;
        
        public listResponse() {
        }
        
        public listResponse(ClienteSoap.ServiceReference1.footballer[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class deleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public deleteRequest() {
        }
        
        public deleteRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class deleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public deleteResponse() {
        }
        
        public deleteResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="read", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class readRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public readRequest() {
        }
        
        public readRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="readResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class readResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSoap.ServiceReference1.footballer @return;
        
        public readResponse() {
        }
        
        public readResponse(ClienteSoap.ServiceReference1.footballer @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class createRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSoap.ServiceReference1.footballer arg0;
        
        public createRequest() {
        }
        
        public createRequest(ClienteSoap.ServiceReference1.footballer arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class createResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public createResponse() {
        }
        
        public createResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClienteSoap.ServiceReference1.footballer arg0;
        
        public updateRequest() {
        }
        
        public updateRequest(ClienteSoap.ServiceReference1.footballer arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public updateResponse() {
        }
        
        public updateResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicesChannel : ClienteSoap.ServiceReference1.Services, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicesClient : System.ServiceModel.ClientBase<ClienteSoap.ServiceReference1.Services>, ClienteSoap.ServiceReference1.Services {
        
        public ServicesClient() {
        }
        
        public ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSoap.ServiceReference1.listResponse ClienteSoap.ServiceReference1.Services.list(ClienteSoap.ServiceReference1.listRequest request) {
            return base.Channel.list(request);
        }
        
        public ClienteSoap.ServiceReference1.footballer[] list() {
            ClienteSoap.ServiceReference1.listRequest inValue = new ClienteSoap.ServiceReference1.listRequest();
            ClienteSoap.ServiceReference1.listResponse retVal = ((ClienteSoap.ServiceReference1.Services)(this)).list(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.listResponse> ClienteSoap.ServiceReference1.Services.listAsync(ClienteSoap.ServiceReference1.listRequest request) {
            return base.Channel.listAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.listResponse> listAsync() {
            ClienteSoap.ServiceReference1.listRequest inValue = new ClienteSoap.ServiceReference1.listRequest();
            return ((ClienteSoap.ServiceReference1.Services)(this)).listAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSoap.ServiceReference1.deleteResponse ClienteSoap.ServiceReference1.Services.delete(ClienteSoap.ServiceReference1.deleteRequest request) {
            return base.Channel.delete(request);
        }
        
        public bool delete(string arg0) {
            ClienteSoap.ServiceReference1.deleteRequest inValue = new ClienteSoap.ServiceReference1.deleteRequest();
            inValue.arg0 = arg0;
            ClienteSoap.ServiceReference1.deleteResponse retVal = ((ClienteSoap.ServiceReference1.Services)(this)).delete(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.deleteResponse> ClienteSoap.ServiceReference1.Services.deleteAsync(ClienteSoap.ServiceReference1.deleteRequest request) {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.deleteResponse> deleteAsync(string arg0) {
            ClienteSoap.ServiceReference1.deleteRequest inValue = new ClienteSoap.ServiceReference1.deleteRequest();
            inValue.arg0 = arg0;
            return ((ClienteSoap.ServiceReference1.Services)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSoap.ServiceReference1.readResponse ClienteSoap.ServiceReference1.Services.read(ClienteSoap.ServiceReference1.readRequest request) {
            return base.Channel.read(request);
        }
        
        public ClienteSoap.ServiceReference1.footballer read(string arg0) {
            ClienteSoap.ServiceReference1.readRequest inValue = new ClienteSoap.ServiceReference1.readRequest();
            inValue.arg0 = arg0;
            ClienteSoap.ServiceReference1.readResponse retVal = ((ClienteSoap.ServiceReference1.Services)(this)).read(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.readResponse> ClienteSoap.ServiceReference1.Services.readAsync(ClienteSoap.ServiceReference1.readRequest request) {
            return base.Channel.readAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.readResponse> readAsync(string arg0) {
            ClienteSoap.ServiceReference1.readRequest inValue = new ClienteSoap.ServiceReference1.readRequest();
            inValue.arg0 = arg0;
            return ((ClienteSoap.ServiceReference1.Services)(this)).readAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSoap.ServiceReference1.createResponse ClienteSoap.ServiceReference1.Services.create(ClienteSoap.ServiceReference1.createRequest request) {
            return base.Channel.create(request);
        }
        
        public bool create(ClienteSoap.ServiceReference1.footballer arg0) {
            ClienteSoap.ServiceReference1.createRequest inValue = new ClienteSoap.ServiceReference1.createRequest();
            inValue.arg0 = arg0;
            ClienteSoap.ServiceReference1.createResponse retVal = ((ClienteSoap.ServiceReference1.Services)(this)).create(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.createResponse> ClienteSoap.ServiceReference1.Services.createAsync(ClienteSoap.ServiceReference1.createRequest request) {
            return base.Channel.createAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.createResponse> createAsync(ClienteSoap.ServiceReference1.footballer arg0) {
            ClienteSoap.ServiceReference1.createRequest inValue = new ClienteSoap.ServiceReference1.createRequest();
            inValue.arg0 = arg0;
            return ((ClienteSoap.ServiceReference1.Services)(this)).createAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSoap.ServiceReference1.updateResponse ClienteSoap.ServiceReference1.Services.update(ClienteSoap.ServiceReference1.updateRequest request) {
            return base.Channel.update(request);
        }
        
        public bool update(ClienteSoap.ServiceReference1.footballer arg0) {
            ClienteSoap.ServiceReference1.updateRequest inValue = new ClienteSoap.ServiceReference1.updateRequest();
            inValue.arg0 = arg0;
            ClienteSoap.ServiceReference1.updateResponse retVal = ((ClienteSoap.ServiceReference1.Services)(this)).update(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.updateResponse> ClienteSoap.ServiceReference1.Services.updateAsync(ClienteSoap.ServiceReference1.updateRequest request) {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteSoap.ServiceReference1.updateResponse> updateAsync(ClienteSoap.ServiceReference1.footballer arg0) {
            ClienteSoap.ServiceReference1.updateRequest inValue = new ClienteSoap.ServiceReference1.updateRequest();
            inValue.arg0 = arg0;
            return ((ClienteSoap.ServiceReference1.Services)(this)).updateAsync(inValue);
        }
    }
}
