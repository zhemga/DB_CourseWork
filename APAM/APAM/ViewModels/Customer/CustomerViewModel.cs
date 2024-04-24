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
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of CustomerContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerContact> LookUpCustomerContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpCustomerContacts,
                    getRepositoryFunc: x => x.CustomerContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the CustomerCustomerContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<CustomerContact, CustomerContact, int, IAPAM_DBEntitiesUnitOfWork> CustomerCustomerContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerCustomerContactsDetails,
                    getRepositoryFunc: x => x.CustomerContacts,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customer);
            }
        }

        /// <summary>
        /// The view model for the CustomerOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> CustomerOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}
