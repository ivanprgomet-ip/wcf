﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Media", Namespace="http://schemas.datacontract.org/2004/07/E02.MyMediaServiceLibrary")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MediaClient.ServiceReference.Paper))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MediaClient.ServiceReference.Book))]
    public partial class Media : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NrOfPagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int NrOfPages {
            get {
                return this.NrOfPagesField;
            }
            set {
                if ((this.NrOfPagesField.Equals(value) != true)) {
                    this.NrOfPagesField = value;
                    this.RaisePropertyChanged("NrOfPages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Paper", Namespace="http://schemas.datacontract.org/2004/07/E02.MyMediaServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Paper : MediaClient.ServiceReference.Media {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/E02.MyMediaServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Book : MediaClient.ServiceReference.Media {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IMediaService")]
    public interface IMediaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/AddBook", ReplyAction="http://tempuri.org/IMediaService/AddBookResponse")]
        void AddBook(MediaClient.ServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/AddBook", ReplyAction="http://tempuri.org/IMediaService/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(MediaClient.ServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/AddPaper", ReplyAction="http://tempuri.org/IMediaService/AddPaperResponse")]
        void AddPaper(MediaClient.ServiceReference.Paper paper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/AddPaper", ReplyAction="http://tempuri.org/IMediaService/AddPaperResponse")]
        System.Threading.Tasks.Task AddPaperAsync(MediaClient.ServiceReference.Paper paper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/GetAllBooks", ReplyAction="http://tempuri.org/IMediaService/GetAllBooksResponse")]
        MediaClient.ServiceReference.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/GetAllBooks", ReplyAction="http://tempuri.org/IMediaService/GetAllBooksResponse")]
        System.Threading.Tasks.Task<MediaClient.ServiceReference.Book[]> GetAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/GetAllPapers", ReplyAction="http://tempuri.org/IMediaService/GetAllPapersResponse")]
        MediaClient.ServiceReference.Paper[] GetAllPapers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/GetAllPapers", ReplyAction="http://tempuri.org/IMediaService/GetAllPapersResponse")]
        System.Threading.Tasks.Task<MediaClient.ServiceReference.Paper[]> GetAllPapersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/RemoveBookFromLibrary", ReplyAction="http://tempuri.org/IMediaService/RemoveBookFromLibraryResponse")]
        void RemoveBookFromLibrary(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/RemoveBookFromLibrary", ReplyAction="http://tempuri.org/IMediaService/RemoveBookFromLibraryResponse")]
        System.Threading.Tasks.Task RemoveBookFromLibraryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/RemovePaperFromLibrary", ReplyAction="http://tempuri.org/IMediaService/RemovePaperFromLibraryResponse")]
        void RemovePaperFromLibrary(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaService/RemovePaperFromLibrary", ReplyAction="http://tempuri.org/IMediaService/RemovePaperFromLibraryResponse")]
        System.Threading.Tasks.Task RemovePaperFromLibraryAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMediaServiceChannel : MediaClient.ServiceReference.IMediaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MediaServiceClient : System.ServiceModel.ClientBase<MediaClient.ServiceReference.IMediaService>, MediaClient.ServiceReference.IMediaService {
        
        public MediaServiceClient() {
        }
        
        public MediaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MediaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MediaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MediaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBook(MediaClient.ServiceReference.Book book) {
            base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(MediaClient.ServiceReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public void AddPaper(MediaClient.ServiceReference.Paper paper) {
            base.Channel.AddPaper(paper);
        }
        
        public System.Threading.Tasks.Task AddPaperAsync(MediaClient.ServiceReference.Paper paper) {
            return base.Channel.AddPaperAsync(paper);
        }
        
        public MediaClient.ServiceReference.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<MediaClient.ServiceReference.Book[]> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
        
        public MediaClient.ServiceReference.Paper[] GetAllPapers() {
            return base.Channel.GetAllPapers();
        }
        
        public System.Threading.Tasks.Task<MediaClient.ServiceReference.Paper[]> GetAllPapersAsync() {
            return base.Channel.GetAllPapersAsync();
        }
        
        public void RemoveBookFromLibrary(int id) {
            base.Channel.RemoveBookFromLibrary(id);
        }
        
        public System.Threading.Tasks.Task RemoveBookFromLibraryAsync(int id) {
            return base.Channel.RemoveBookFromLibraryAsync(id);
        }
        
        public void RemovePaperFromLibrary(int id) {
            base.Channel.RemovePaperFromLibrary(id);
        }
        
        public System.Threading.Tasks.Task RemovePaperFromLibraryAsync(int id) {
            return base.Channel.RemovePaperFromLibraryAsync(id);
        }
    }
}
