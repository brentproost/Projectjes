﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace PanoramaApp3.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_User", Namespace="http://schemas.datacontract.org/2004/07/Wcf")]
    public partial class Tbl_User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AdresField;
        
        private string GebruikersnaamField;
        
        private int IDField;
        
        private string NaamField;
        
        private int NummerField;
        
        private PanoramaApp3.ServiceReference1.Binary PaswoordField;
        
        private string PlaatsField;
        
        private int PostcodeField;
        
        private int Rechten_IDField;
        
        private string VoornaamField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adres {
            get {
                return this.AdresField;
            }
            set {
                if ((object.ReferenceEquals(this.AdresField, value) != true)) {
                    this.AdresField = value;
                    this.RaisePropertyChanged("Adres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gebruikersnaam {
            get {
                return this.GebruikersnaamField;
            }
            set {
                if ((object.ReferenceEquals(this.GebruikersnaamField, value) != true)) {
                    this.GebruikersnaamField = value;
                    this.RaisePropertyChanged("Gebruikersnaam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nummer {
            get {
                return this.NummerField;
            }
            set {
                if ((this.NummerField.Equals(value) != true)) {
                    this.NummerField = value;
                    this.RaisePropertyChanged("Nummer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PanoramaApp3.ServiceReference1.Binary Paswoord {
            get {
                return this.PaswoordField;
            }
            set {
                if ((object.ReferenceEquals(this.PaswoordField, value) != true)) {
                    this.PaswoordField = value;
                    this.RaisePropertyChanged("Paswoord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Plaats {
            get {
                return this.PlaatsField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaatsField, value) != true)) {
                    this.PlaatsField = value;
                    this.RaisePropertyChanged("Plaats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Postcode {
            get {
                return this.PostcodeField;
            }
            set {
                if ((this.PostcodeField.Equals(value) != true)) {
                    this.PostcodeField = value;
                    this.RaisePropertyChanged("Postcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rechten_ID {
            get {
                return this.Rechten_IDField;
            }
            set {
                if ((this.Rechten_IDField.Equals(value) != true)) {
                    this.Rechten_IDField = value;
                    this.RaisePropertyChanged("Rechten_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Voornaam {
            get {
                return this.VoornaamField;
            }
            set {
                if ((object.ReferenceEquals(this.VoornaamField, value) != true)) {
                    this.VoornaamField = value;
                    this.RaisePropertyChanged("Voornaam");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Binary", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Linq")]
    public partial class Binary : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] BytesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Tbl_Activiteiten", Namespace="http://schemas.datacontract.org/2004/07/Wcf")]
    public partial class Tbl_Activiteiten : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IDField;
        
        private string OmschrijvingField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Omschrijving {
            get {
                return this.OmschrijvingField;
            }
            set {
                if ((object.ReferenceEquals(this.OmschrijvingField, value) != true)) {
                    this.OmschrijvingField = value;
                    this.RaisePropertyChanged("Omschrijving");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetAllUsers", ReplyAction="http://tempuri.org/IService/GetAllUsersResponse")]
        System.IAsyncResult BeginGetAllUsers(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> EndGetAllUsers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetAllActivities", ReplyAction="http://tempuri.org/IService/GetAllActivitiesResponse")]
        System.IAsyncResult BeginGetAllActivities(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> EndGetAllActivities(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : PanoramaApp3.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllActivitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllActivitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<PanoramaApp3.ServiceReference1.IService>, PanoramaApp3.ServiceReference1.IService {
        
        private BeginOperationDelegate onBeginGetAllUsersDelegate;
        
        private EndOperationDelegate onEndGetAllUsersDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllUsersCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllActivitiesDelegate;
        
        private EndOperationDelegate onEndGetAllActivitiesDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllActivitiesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetAllUsersCompletedEventArgs> GetAllUsersCompleted;
        
        public event System.EventHandler<GetAllActivitiesCompletedEventArgs> GetAllActivitiesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PanoramaApp3.ServiceReference1.IService.BeginGetAllUsers(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllUsers(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> PanoramaApp3.ServiceReference1.IService.EndGetAllUsers(System.IAsyncResult result) {
            return base.Channel.EndGetAllUsers(result);
        }
        
        private System.IAsyncResult OnBeginGetAllUsers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((PanoramaApp3.ServiceReference1.IService)(this)).BeginGetAllUsers(callback, asyncState);
        }
        
        private object[] OnEndGetAllUsers(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> retVal = ((PanoramaApp3.ServiceReference1.IService)(this)).EndGetAllUsers(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllUsersCompleted(object state) {
            if ((this.GetAllUsersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllUsersCompleted(this, new GetAllUsersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllUsersAsync() {
            this.GetAllUsersAsync(null);
        }
        
        public void GetAllUsersAsync(object userState) {
            if ((this.onBeginGetAllUsersDelegate == null)) {
                this.onBeginGetAllUsersDelegate = new BeginOperationDelegate(this.OnBeginGetAllUsers);
            }
            if ((this.onEndGetAllUsersDelegate == null)) {
                this.onEndGetAllUsersDelegate = new EndOperationDelegate(this.OnEndGetAllUsers);
            }
            if ((this.onGetAllUsersCompletedDelegate == null)) {
                this.onGetAllUsersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllUsersCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllUsersDelegate, null, this.onEndGetAllUsersDelegate, this.onGetAllUsersCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PanoramaApp3.ServiceReference1.IService.BeginGetAllActivities(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllActivities(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> PanoramaApp3.ServiceReference1.IService.EndGetAllActivities(System.IAsyncResult result) {
            return base.Channel.EndGetAllActivities(result);
        }
        
        private System.IAsyncResult OnBeginGetAllActivities(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((PanoramaApp3.ServiceReference1.IService)(this)).BeginGetAllActivities(callback, asyncState);
        }
        
        private object[] OnEndGetAllActivities(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> retVal = ((PanoramaApp3.ServiceReference1.IService)(this)).EndGetAllActivities(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllActivitiesCompleted(object state) {
            if ((this.GetAllActivitiesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllActivitiesCompleted(this, new GetAllActivitiesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllActivitiesAsync() {
            this.GetAllActivitiesAsync(null);
        }
        
        public void GetAllActivitiesAsync(object userState) {
            if ((this.onBeginGetAllActivitiesDelegate == null)) {
                this.onBeginGetAllActivitiesDelegate = new BeginOperationDelegate(this.OnBeginGetAllActivities);
            }
            if ((this.onEndGetAllActivitiesDelegate == null)) {
                this.onEndGetAllActivitiesDelegate = new EndOperationDelegate(this.OnEndGetAllActivities);
            }
            if ((this.onGetAllActivitiesCompletedDelegate == null)) {
                this.onGetAllActivitiesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllActivitiesCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllActivitiesDelegate, null, this.onEndGetAllActivitiesDelegate, this.onGetAllActivitiesCompletedDelegate, userState);
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
        
        protected override PanoramaApp3.ServiceReference1.IService CreateChannel() {
            return new ServiceClientChannel(this);
        }
        
        private class ServiceClientChannel : ChannelBase<PanoramaApp3.ServiceReference1.IService>, PanoramaApp3.ServiceReference1.IService {
            
            public ServiceClientChannel(System.ServiceModel.ClientBase<PanoramaApp3.ServiceReference1.IService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetAllUsers(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllUsers", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> EndGetAllUsers(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User> _result = ((System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_User>)(base.EndInvoke("GetAllUsers", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetAllActivities(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllActivities", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> EndGetAllActivities(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten> _result = ((System.Collections.ObjectModel.ObservableCollection<PanoramaApp3.ServiceReference1.Tbl_Activiteiten>)(base.EndInvoke("GetAllActivities", _args, result)));
                return _result;
            }
        }
    }
}
