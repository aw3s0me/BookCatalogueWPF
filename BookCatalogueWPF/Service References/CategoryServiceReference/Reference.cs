﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCatalogueWPF.Client.CategoryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoBase", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.DtoBase")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.CategoryServiceReference.DtoEntityBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi))]
    public partial class DtoBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BookCatalogueWPF.Client.CategoryServiceReference.Response _responseInstanceField;
        
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
        public BookCatalogueWPF.Client.CategoryServiceReference.Response _responseInstance {
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto))]
    public partial class DtoEntityBase : BookCatalogueWPF.Client.CategoryServiceReference.DtoBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryDto", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.EntityDto")]
    [System.SerializableAttribute()]
    public partial class CategoryDto : BookCatalogueWPF.Client.CategoryServiceReference.DtoEntityBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasChildrenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> ParentIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasChildren {
            get {
                return this.HasChildrenField;
            }
            set {
                if ((this.HasChildrenField.Equals(value) != true)) {
                    this.HasChildrenField = value;
                    this.RaisePropertyChanged("HasChildren");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ParentId {
            get {
                return this.ParentIdField;
            }
            set {
                if ((this.ParentIdField.Equals(value) != true)) {
                    this.ParentIdField = value;
                    this.RaisePropertyChanged("ParentId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoListOfCategoryDtoSwFggRHi", Namespace="http://schemas.datacontract.org/2004/07/BookCatalogueWPF.Common.Dto.DtoBase")]
    [System.SerializableAttribute()]
    public partial class DtoListOfCategoryDtoSwFggRHi : BookCatalogueWPF.Client.CategoryServiceReference.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto[] DtosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto[] Dtos {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryServiceReference.ICategoryService")]
    public interface ICategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_CategoryDto/GetAll", ReplyAction="http://tempuri.org/ICrudServiceOf_CategoryDto/GetAllResponse")]
        BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_CategoryDto/GetAll", ReplyAction="http://tempuri.org/ICrudServiceOf_CategoryDto/GetAllResponse")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_CategoryDto/GetById", ReplyAction="http://tempuri.org/ICrudServiceOf_CategoryDto/GetByIdResponse")]
        BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto GetById(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_CategoryDto/GetById", ReplyAction="http://tempuri.org/ICrudServiceOf_CategoryDto/GetByIdResponse")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto> GetByIdAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITreeServiceOf_CategoryDto/GetEntitiesForTreeByParentId", ReplyAction="http://tempuri.org/ITreeServiceOf_CategoryDto/GetEntitiesForTreeByParentIdRespons" +
            "e")]
        BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetEntitiesForTreeByParentId(long parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITreeServiceOf_CategoryDto/GetEntitiesForTreeByParentId", ReplyAction="http://tempuri.org/ITreeServiceOf_CategoryDto/GetEntitiesForTreeByParentIdRespons" +
            "e")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetEntitiesForTreeByParentIdAsync(long parentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITreeServiceOf_CategoryDto/GetFirstLevelTreeElements", ReplyAction="http://tempuri.org/ITreeServiceOf_CategoryDto/GetFirstLevelTreeElementsResponse")]
        BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetFirstLevelTreeElements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITreeServiceOf_CategoryDto/GetFirstLevelTreeElements", ReplyAction="http://tempuri.org/ITreeServiceOf_CategoryDto/GetFirstLevelTreeElementsResponse")]
        System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetFirstLevelTreeElementsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryServiceChannel : BookCatalogueWPF.Client.CategoryServiceReference.ICategoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryServiceClient : System.ServiceModel.ClientBase<BookCatalogueWPF.Client.CategoryServiceReference.ICategoryService>, BookCatalogueWPF.Client.CategoryServiceReference.ICategoryService {
        
        public CategoryServiceClient() {
        }
        
        public CategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto GetById(long id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.CategoryDto> GetByIdAsync(long id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetEntitiesForTreeByParentId(long parentId) {
            return base.Channel.GetEntitiesForTreeByParentId(parentId);
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetEntitiesForTreeByParentIdAsync(long parentId) {
            return base.Channel.GetEntitiesForTreeByParentIdAsync(parentId);
        }
        
        public BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi GetFirstLevelTreeElements() {
            return base.Channel.GetFirstLevelTreeElements();
        }
        
        public System.Threading.Tasks.Task<BookCatalogueWPF.Client.CategoryServiceReference.DtoListOfCategoryDtoSwFggRHi> GetFirstLevelTreeElementsAsync() {
            return base.Channel.GetFirstLevelTreeElementsAsync();
        }
    }
}