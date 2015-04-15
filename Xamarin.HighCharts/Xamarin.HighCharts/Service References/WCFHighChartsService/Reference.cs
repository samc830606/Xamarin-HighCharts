﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xamarin.HighCharts.WCFHighChartsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFHighChartsService.IWCFHighChartsService")]
    public interface IWCFHighChartsService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWCFHighChartsService/AddUser", ReplyAction="http://tempuri.org/IWCFHighChartsService/AddUserResponse")]
        System.IAsyncResult BeginAddUser(string user, System.AsyncCallback callback, object asyncState);
        
        bool EndAddUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWCFHighChartsService/DeleteUser", ReplyAction="http://tempuri.org/IWCFHighChartsService/DeleteUserResponse")]
        System.IAsyncResult BeginDeleteUser(int userId, System.AsyncCallback callback, object asyncState);
        
        bool EndDeleteUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWCFHighChartsService/UpdateUser", ReplyAction="http://tempuri.org/IWCFHighChartsService/UpdateUserResponse")]
        System.IAsyncResult BeginUpdateUser(string user, System.AsyncCallback callback, object asyncState);
        
        bool EndUpdateUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWCFHighChartsService/GetUsers", ReplyAction="http://tempuri.org/IWCFHighChartsService/GetUsersResponse")]
        System.IAsyncResult BeginGetUsers(System.AsyncCallback callback, object asyncState);
        
        string EndGetUsers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWCFHighChartsService/ValidateUser", ReplyAction="http://tempuri.org/IWCFHighChartsService/ValidateUserResponse")]
        System.IAsyncResult BeginValidateUser(string Login, string Password, System.AsyncCallback callback, object asyncState);
        
        bool EndValidateUser(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFHighChartsServiceChannel : Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeleteUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DeleteUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class ValidateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ValidateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFHighChartsServiceClient : System.ServiceModel.ClientBase<Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService>, Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService {
        
        private BeginOperationDelegate onBeginAddUserDelegate;
        
        private EndOperationDelegate onEndAddUserDelegate;
        
        private System.Threading.SendOrPostCallback onAddUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteUserDelegate;
        
        private EndOperationDelegate onEndDeleteUserDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateUserDelegate;
        
        private EndOperationDelegate onEndUpdateUserDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetUsersDelegate;
        
        private EndOperationDelegate onEndGetUsersDelegate;
        
        private System.Threading.SendOrPostCallback onGetUsersCompletedDelegate;
        
        private BeginOperationDelegate onBeginValidateUserDelegate;
        
        private EndOperationDelegate onEndValidateUserDelegate;
        
        private System.Threading.SendOrPostCallback onValidateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WCFHighChartsServiceClient() : 
                base(WCFHighChartsServiceClient.GetDefaultBinding(), WCFHighChartsServiceClient.GetDefaultEndpointAddress()) {
        }
        
        public WCFHighChartsServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WCFHighChartsServiceClient.GetBindingForEndpoint(endpointConfiguration), WCFHighChartsServiceClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public WCFHighChartsServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WCFHighChartsServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public WCFHighChartsServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WCFHighChartsServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public WCFHighChartsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<AddUserCompletedEventArgs> AddUserCompleted;
        
        public event System.EventHandler<DeleteUserCompletedEventArgs> DeleteUserCompleted;
        
        public event System.EventHandler<UpdateUserCompletedEventArgs> UpdateUserCompleted;
        
        public event System.EventHandler<GetUsersCompletedEventArgs> GetUsersCompleted;
        
        public event System.EventHandler<ValidateUserCompletedEventArgs> ValidateUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.BeginAddUser(string user, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddUser(user, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.EndAddUser(System.IAsyncResult result) {
            return base.Channel.EndAddUser(result);
        }
        
        private System.IAsyncResult OnBeginAddUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string user = ((string)(inValues[0]));
            return ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).BeginAddUser(user, callback, asyncState);
        }
        
        private object[] OnEndAddUser(System.IAsyncResult result) {
            bool retVal = ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).EndAddUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddUserCompleted(object state) {
            if ((this.AddUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddUserCompleted(this, new AddUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddUserAsync(string user) {
            this.AddUserAsync(user, null);
        }
        
        public void AddUserAsync(string user, object userState) {
            if ((this.onBeginAddUserDelegate == null)) {
                this.onBeginAddUserDelegate = new BeginOperationDelegate(this.OnBeginAddUser);
            }
            if ((this.onEndAddUserDelegate == null)) {
                this.onEndAddUserDelegate = new EndOperationDelegate(this.OnEndAddUser);
            }
            if ((this.onAddUserCompletedDelegate == null)) {
                this.onAddUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddUserCompleted);
            }
            base.InvokeAsync(this.onBeginAddUserDelegate, new object[] {
                        user}, this.onEndAddUserDelegate, this.onAddUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.BeginDeleteUser(int userId, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDeleteUser(userId, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.EndDeleteUser(System.IAsyncResult result) {
            return base.Channel.EndDeleteUser(result);
        }
        
        private System.IAsyncResult OnBeginDeleteUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int userId = ((int)(inValues[0]));
            return ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).BeginDeleteUser(userId, callback, asyncState);
        }
        
        private object[] OnEndDeleteUser(System.IAsyncResult result) {
            bool retVal = ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).EndDeleteUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDeleteUserCompleted(object state) {
            if ((this.DeleteUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteUserCompleted(this, new DeleteUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteUserAsync(int userId) {
            this.DeleteUserAsync(userId, null);
        }
        
        public void DeleteUserAsync(int userId, object userState) {
            if ((this.onBeginDeleteUserDelegate == null)) {
                this.onBeginDeleteUserDelegate = new BeginOperationDelegate(this.OnBeginDeleteUser);
            }
            if ((this.onEndDeleteUserDelegate == null)) {
                this.onEndDeleteUserDelegate = new EndOperationDelegate(this.OnEndDeleteUser);
            }
            if ((this.onDeleteUserCompletedDelegate == null)) {
                this.onDeleteUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteUserCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteUserDelegate, new object[] {
                        userId}, this.onEndDeleteUserDelegate, this.onDeleteUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.BeginUpdateUser(string user, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateUser(user, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.EndUpdateUser(System.IAsyncResult result) {
            return base.Channel.EndUpdateUser(result);
        }
        
        private System.IAsyncResult OnBeginUpdateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string user = ((string)(inValues[0]));
            return ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).BeginUpdateUser(user, callback, asyncState);
        }
        
        private object[] OnEndUpdateUser(System.IAsyncResult result) {
            bool retVal = ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).EndUpdateUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateUserCompleted(object state) {
            if ((this.UpdateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateUserCompleted(this, new UpdateUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateUserAsync(string user) {
            this.UpdateUserAsync(user, null);
        }
        
        public void UpdateUserAsync(string user, object userState) {
            if ((this.onBeginUpdateUserDelegate == null)) {
                this.onBeginUpdateUserDelegate = new BeginOperationDelegate(this.OnBeginUpdateUser);
            }
            if ((this.onEndUpdateUserDelegate == null)) {
                this.onEndUpdateUserDelegate = new EndOperationDelegate(this.OnEndUpdateUser);
            }
            if ((this.onUpdateUserCompletedDelegate == null)) {
                this.onUpdateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateUserCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateUserDelegate, new object[] {
                        user}, this.onEndUpdateUserDelegate, this.onUpdateUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.BeginGetUsers(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetUsers(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.EndGetUsers(System.IAsyncResult result) {
            return base.Channel.EndGetUsers(result);
        }
        
        private System.IAsyncResult OnBeginGetUsers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).BeginGetUsers(callback, asyncState);
        }
        
        private object[] OnEndGetUsers(System.IAsyncResult result) {
            string retVal = ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).EndGetUsers(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetUsersCompleted(object state) {
            if ((this.GetUsersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetUsersCompleted(this, new GetUsersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetUsersAsync() {
            this.GetUsersAsync(null);
        }
        
        public void GetUsersAsync(object userState) {
            if ((this.onBeginGetUsersDelegate == null)) {
                this.onBeginGetUsersDelegate = new BeginOperationDelegate(this.OnBeginGetUsers);
            }
            if ((this.onEndGetUsersDelegate == null)) {
                this.onEndGetUsersDelegate = new EndOperationDelegate(this.OnEndGetUsers);
            }
            if ((this.onGetUsersCompletedDelegate == null)) {
                this.onGetUsersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetUsersCompleted);
            }
            base.InvokeAsync(this.onBeginGetUsersDelegate, null, this.onEndGetUsersDelegate, this.onGetUsersCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.BeginValidateUser(string Login, string Password, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginValidateUser(Login, Password, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService.EndValidateUser(System.IAsyncResult result) {
            return base.Channel.EndValidateUser(result);
        }
        
        private System.IAsyncResult OnBeginValidateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Login = ((string)(inValues[0]));
            string Password = ((string)(inValues[1]));
            return ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).BeginValidateUser(Login, Password, callback, asyncState);
        }
        
        private object[] OnEndValidateUser(System.IAsyncResult result) {
            bool retVal = ((Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService)(this)).EndValidateUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnValidateUserCompleted(object state) {
            if ((this.ValidateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ValidateUserCompleted(this, new ValidateUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ValidateUserAsync(string Login, string Password) {
            this.ValidateUserAsync(Login, Password, null);
        }
        
        public void ValidateUserAsync(string Login, string Password, object userState) {
            if ((this.onBeginValidateUserDelegate == null)) {
                this.onBeginValidateUserDelegate = new BeginOperationDelegate(this.OnBeginValidateUser);
            }
            if ((this.onEndValidateUserDelegate == null)) {
                this.onEndValidateUserDelegate = new EndOperationDelegate(this.OnEndValidateUser);
            }
            if ((this.onValidateUserCompletedDelegate == null)) {
                this.onValidateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnValidateUserCompleted);
            }
            base.InvokeAsync(this.onBeginValidateUserDelegate, new object[] {
                        Login,
                        Password}, this.onEndValidateUserDelegate, this.onValidateUserCompletedDelegate, userState);
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
        
        protected override Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService CreateChannel() {
            return new WCFHighChartsServiceClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFHighChartsService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFHighChartsService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8973/WCFHighChartsService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WCFHighChartsServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWCFHighChartsService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WCFHighChartsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWCFHighChartsService);
        }
        
        private class WCFHighChartsServiceClientChannel : ChannelBase<Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService>, Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService {
            
            public WCFHighChartsServiceClientChannel(System.ServiceModel.ClientBase<Xamarin.HighCharts.WCFHighChartsService.IWCFHighChartsService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginAddUser(string user, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = user;
                System.IAsyncResult _result = base.BeginInvoke("AddUser", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndAddUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("AddUser", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDeleteUser(int userId, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = userId;
                System.IAsyncResult _result = base.BeginInvoke("DeleteUser", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndDeleteUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("DeleteUser", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdateUser(string user, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = user;
                System.IAsyncResult _result = base.BeginInvoke("UpdateUser", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndUpdateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("UpdateUser", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetUsers(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetUsers", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetUsers(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetUsers", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginValidateUser(string Login, string Password, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = Login;
                _args[1] = Password;
                System.IAsyncResult _result = base.BeginInvoke("ValidateUser", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndValidateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("ValidateUser", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IWCFHighChartsService,
        }
    }
}