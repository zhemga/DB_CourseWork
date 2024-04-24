using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using APAM.APAM_DBEntitiesDataModel;
using APAM.Common;
using APAM;

namespace APAM.ViewModels {

    /// <summary>
    /// Represents the single ContactType object view model.
    /// </summary>
    public partial class ContactTypeViewModel : SingleObjectViewModel<ContactType, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ContactTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ContactTypeViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ContactTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ContactTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContactTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ContactTypeViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ContactTypes, x => x.Type) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AdministratorContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AdministratorContact> LookUpAdministratorContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.LookUpAdministratorContacts,
                    getRepositoryFunc: x => x.AdministratorContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of BookkeeperContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BookkeeperContact> LookUpBookkeeperContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.LookUpBookkeeperContacts,
                    getRepositoryFunc: x => x.BookkeeperContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of CustomerContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerContact> LookUpCustomerContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.LookUpCustomerContacts,
                    getRepositoryFunc: x => x.CustomerContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SellerContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SellerContact> LookUpSellerContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.LookUpSellerContacts,
                    getRepositoryFunc: x => x.SellerContacts);
            }
        }


        /// <summary>
        /// The view model for the ContactTypeAdministratorContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<AdministratorContact, AdministratorContact, int, IAPAM_DBEntitiesUnitOfWork> ContactTypeAdministratorContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.ContactTypeAdministratorContactsDetails,
                    getRepositoryFunc: x => x.AdministratorContacts,
                    foreignKeyExpression: x => x.ContactTypeId,
                    navigationExpression: x => x.ContactType);
            }
        }

        /// <summary>
        /// The view model for the ContactTypeBookkeeperContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<BookkeeperContact, BookkeeperContact, int, IAPAM_DBEntitiesUnitOfWork> ContactTypeBookkeeperContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.ContactTypeBookkeeperContactsDetails,
                    getRepositoryFunc: x => x.BookkeeperContacts,
                    foreignKeyExpression: x => x.ContactTypeId,
                    navigationExpression: x => x.ContactType);
            }
        }

        /// <summary>
        /// The view model for the ContactTypeCustomerContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<CustomerContact, CustomerContact, int, IAPAM_DBEntitiesUnitOfWork> ContactTypeCustomerContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.ContactTypeCustomerContactsDetails,
                    getRepositoryFunc: x => x.CustomerContacts,
                    foreignKeyExpression: x => x.ContactTypeId,
                    navigationExpression: x => x.ContactType);
            }
        }

        /// <summary>
        /// The view model for the ContactTypeSellerContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<SellerContact, SellerContact, int, IAPAM_DBEntitiesUnitOfWork> ContactTypeSellerContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContactTypeViewModel x) => x.ContactTypeSellerContactsDetails,
                    getRepositoryFunc: x => x.SellerContacts,
                    foreignKeyExpression: x => x.ContactTypeId,
                    navigationExpression: x => x.ContactType);
            }
        }
    }
}
