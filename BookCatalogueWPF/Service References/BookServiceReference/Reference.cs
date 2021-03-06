﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCatalogueWPF.Client.BookServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoBase", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.DtoBase")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.BookServiceReference.DtoEntityBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.BookServiceReference.BookDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi))]
    public partial class DtoBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BookCatalogueWPF.Client.BookServiceReference.Response _responseInstanceField;
        
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
        public BookCatalogueWPF.Client.BookServiceReference.Response _responseInstance {
            get {
                return this._responseInstanceField;
            }
            set {
                if ((object.ReferenceEquals(this._responseInstanceField, value) != true)) {
                    this._responseInstanceField = value;
                    this.RaisePropertyChanged("_responseInstance");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Message")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoEntityBase", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.DtoBase")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.BookServiceReference.BookDto))]
    public partial class DtoEntityBase : BookCatalogueWPF.Client.BookServiceReference.DtoBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookDto", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.EntityDto")]
    [System.SerializableAttribute()]
    public partial class BookDto : BookCatalogueWPF.Client.BookServiceReference.DtoEntityBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnnotationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long YearField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Annotation {
            get {
                return this.AnnotationField;
            }
            set {
                if ((object.ReferenceEquals(this.AnnotationField, value) != true)) {
                    this.AnnotationField = value;
                    this.RaisePropertyChanged("Annotation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoListOfBookDtoSwFggRHi", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.DtoBase")]
    [System.SerializableAttribute()]
    public partial class DtoListOfBookDtoSwFggRHi : BookCatalogueWPF.Client.BookServiceReference.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BookCatalogueWPF.Client.BookServiceReference.BookDto[] DtosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BookCatalogueWPF.Client.BookServiceReference.BookDto[] Dtos {
            get {
                return this.DtosField;
            }
            set {
                if ((object.ReferenceEquals(this.DtosField, value) != true)) {
                    this.DtosField = value;
                    this.RaisePropertyChanged("Dtos");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceReference.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_BookDto/GetAll", ReplyAction="http://tempuri.org/ICrudServiceOf_BookDto/GetAllResponse")]
        BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_BookDto/GetAll", ReplyAction="http://tempuri.org/ICrudServiceOf_BookDto/GetAllResponse")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooksByCategoryId", ReplyAction="http://tempuri.org/IBookService/GetBooksByCategoryIdResponse")]
        BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi GetBooksByCategoryId(long categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooksByCategoryId", ReplyAction="http://tempuri.org/IBookService/GetBooksByCategoryIdResponse")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi> GetBooksByCategoryIdAsync(long categoryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : BookCatalogueWPF.Client.BookServiceReference.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<BookCatalogueWPF.Client.BookServiceReference.IBookService>, BookCatalogueWPF.Client.BookServiceReference.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi GetBooksByCategoryId(long categoryId) {
            return base.Channel.GetBooksByCategoryId(categoryId);
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.BookServiceReference.DtoListOfBookDtoSwFggRHi> GetBooksByCategoryIdAsync(long categoryId) {
            return base.Channel.GetBooksByCategoryIdAsync(categoryId);
        }
    }
}
