﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Statistic.Stat_service {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TestService.dbItemss", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class TestServicedbItemss : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime DatetimeField;
        
        private string FlightField;
        
        private string IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Datetime {
            get {
                return this.DatetimeField;
            }
            set {
                if ((this.DatetimeField.Equals(value) != true)) {
                    this.DatetimeField = value;
                    this.RaisePropertyChanged("Datetime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Flight {
            get {
                return this.FlightField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightField, value) != true)) {
                    this.FlightField = value;
                    this.RaisePropertyChanged("Flight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Stat_service.TestService")]
    public interface TestService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:TestService/GetServerTIme", ReplyAction="urn:TestService/GetServerTImeResponse")]
        System.IAsyncResult BeginGetServerTIme(System.AsyncCallback callback, object asyncState);
        
        string EndGetServerTIme(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:TestService/sqlTest", ReplyAction="urn:TestService/sqlTestResponse")]
        System.IAsyncResult BeginsqlTest(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> EndsqlTest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:TestService/addCHG", ReplyAction="urn:TestService/addCHGResponse")]
        System.IAsyncResult BeginaddCHG(string message, System.AsyncCallback callback, object asyncState);
        
        void EndaddCHG(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TestServiceChannel : Statistic.Stat_service.TestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetServerTImeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetServerTImeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class sqlTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public sqlTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<Statistic.Stat_service.TestService>, Statistic.Stat_service.TestService {
        
        private BeginOperationDelegate onBeginGetServerTImeDelegate;
        
        private EndOperationDelegate onEndGetServerTImeDelegate;
        
        private System.Threading.SendOrPostCallback onGetServerTImeCompletedDelegate;
        
        private BeginOperationDelegate onBeginsqlTestDelegate;
        
        private EndOperationDelegate onEndsqlTestDelegate;
        
        private System.Threading.SendOrPostCallback onsqlTestCompletedDelegate;
        
        private BeginOperationDelegate onBeginaddCHGDelegate;
        
        private EndOperationDelegate onEndaddCHGDelegate;
        
        private System.Threading.SendOrPostCallback onaddCHGCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetServerTImeCompletedEventArgs> GetServerTImeCompleted;
        
        public event System.EventHandler<sqlTestCompletedEventArgs> sqlTestCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> addCHGCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Statistic.Stat_service.TestService.BeginGetServerTIme(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetServerTIme(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Statistic.Stat_service.TestService.EndGetServerTIme(System.IAsyncResult result) {
            return base.Channel.EndGetServerTIme(result);
        }
        
        private System.IAsyncResult OnBeginGetServerTIme(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Statistic.Stat_service.TestService)(this)).BeginGetServerTIme(callback, asyncState);
        }
        
        private object[] OnEndGetServerTIme(System.IAsyncResult result) {
            string retVal = ((Statistic.Stat_service.TestService)(this)).EndGetServerTIme(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetServerTImeCompleted(object state) {
            if ((this.GetServerTImeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetServerTImeCompleted(this, new GetServerTImeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetServerTImeAsync() {
            this.GetServerTImeAsync(null);
        }
        
        public void GetServerTImeAsync(object userState) {
            if ((this.onBeginGetServerTImeDelegate == null)) {
                this.onBeginGetServerTImeDelegate = new BeginOperationDelegate(this.OnBeginGetServerTIme);
            }
            if ((this.onEndGetServerTImeDelegate == null)) {
                this.onEndGetServerTImeDelegate = new EndOperationDelegate(this.OnEndGetServerTIme);
            }
            if ((this.onGetServerTImeCompletedDelegate == null)) {
                this.onGetServerTImeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetServerTImeCompleted);
            }
            base.InvokeAsync(this.onBeginGetServerTImeDelegate, null, this.onEndGetServerTImeDelegate, this.onGetServerTImeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Statistic.Stat_service.TestService.BeginsqlTest(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginsqlTest(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> Statistic.Stat_service.TestService.EndsqlTest(System.IAsyncResult result) {
            return base.Channel.EndsqlTest(result);
        }
        
        private System.IAsyncResult OnBeginsqlTest(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Statistic.Stat_service.TestService)(this)).BeginsqlTest(callback, asyncState);
        }
        
        private object[] OnEndsqlTest(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> retVal = ((Statistic.Stat_service.TestService)(this)).EndsqlTest(result);
            return new object[] {
                    retVal};
        }
        
        private void OnsqlTestCompleted(object state) {
            if ((this.sqlTestCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.sqlTestCompleted(this, new sqlTestCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void sqlTestAsync() {
            this.sqlTestAsync(null);
        }
        
        public void sqlTestAsync(object userState) {
            if ((this.onBeginsqlTestDelegate == null)) {
                this.onBeginsqlTestDelegate = new BeginOperationDelegate(this.OnBeginsqlTest);
            }
            if ((this.onEndsqlTestDelegate == null)) {
                this.onEndsqlTestDelegate = new EndOperationDelegate(this.OnEndsqlTest);
            }
            if ((this.onsqlTestCompletedDelegate == null)) {
                this.onsqlTestCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnsqlTestCompleted);
            }
            base.InvokeAsync(this.onBeginsqlTestDelegate, null, this.onEndsqlTestDelegate, this.onsqlTestCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Statistic.Stat_service.TestService.BeginaddCHG(string message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginaddCHG(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void Statistic.Stat_service.TestService.EndaddCHG(System.IAsyncResult result) {
            base.Channel.EndaddCHG(result);
        }
        
        private System.IAsyncResult OnBeginaddCHG(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string message = ((string)(inValues[0]));
            return ((Statistic.Stat_service.TestService)(this)).BeginaddCHG(message, callback, asyncState);
        }
        
        private object[] OnEndaddCHG(System.IAsyncResult result) {
            ((Statistic.Stat_service.TestService)(this)).EndaddCHG(result);
            return null;
        }
        
        private void OnaddCHGCompleted(object state) {
            if ((this.addCHGCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.addCHGCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void addCHGAsync(string message) {
            this.addCHGAsync(message, null);
        }
        
        public void addCHGAsync(string message, object userState) {
            if ((this.onBeginaddCHGDelegate == null)) {
                this.onBeginaddCHGDelegate = new BeginOperationDelegate(this.OnBeginaddCHG);
            }
            if ((this.onEndaddCHGDelegate == null)) {
                this.onEndaddCHGDelegate = new EndOperationDelegate(this.OnEndaddCHG);
            }
            if ((this.onaddCHGCompletedDelegate == null)) {
                this.onaddCHGCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnaddCHGCompleted);
            }
            base.InvokeAsync(this.onBeginaddCHGDelegate, new object[] {
                        message}, this.onEndaddCHGDelegate, this.onaddCHGCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Statistic.Stat_service.TestService CreateChannel() {
            return new TestServiceClientChannel(this);
        }
        
        private class TestServiceClientChannel : ChannelBase<Statistic.Stat_service.TestService>, Statistic.Stat_service.TestService {
            
            public TestServiceClientChannel(System.ServiceModel.ClientBase<Statistic.Stat_service.TestService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetServerTIme(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetServerTIme", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetServerTIme(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetServerTIme", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginsqlTest(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("sqlTest", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> EndsqlTest(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss> _result = ((System.Collections.ObjectModel.ObservableCollection<Statistic.Stat_service.TestServicedbItemss>)(base.EndInvoke("sqlTest", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginaddCHG(string message, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = message;
                System.IAsyncResult _result = base.BeginInvoke("addCHG", _args, callback, asyncState);
                return _result;
            }
            
            public void EndaddCHG(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("addCHG", _args, result);
            }
        }
    }
}
