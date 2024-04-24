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
    /// Represents the single Seller object view model.
    /// </summary>
    public partial class SellerViewModel : SingleObjectViewModel<Seller, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SellerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SellerViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SellerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SellerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SellerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SellerViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sellers, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SellerContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SellerContact> LookUpSellerContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerViewModel x) => x.LookUpSellerContacts,
                    getRepositoryFunc: x => x.SellerContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SellerSalaries for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SellerSalary> LookUpSellerSalaries {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerViewModel x) => x.LookUpSellerSalaries,
                    getRepositoryFunc: x => x.SellerSalaries);
            }
        }


        /// <summary>
        /// The view model for the SellerOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> SellerOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SellerViewModel x) => x.SellerOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.SellerId,
                    navigationExpression: x => x.Seller);
            }
        }

        /// <summary>
        /// The view model for the SellerSellerContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<SellerContact, SellerContact, int, IAPAM_DBEntitiesUnitOfWork> SellerSellerContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SellerViewModel x) => x.SellerSellerContactsDetails,
                    getRepositoryFunc: x => x.SellerContacts,
                    foreignKeyExpression: x => x.SellerId,
                    navigationExpression: x => x.Seller);
            }
        }

        /// <summary>
        /// The view model for the SellerSellerSalaries detail collection.
        /// </summary>
        public CollectionViewModelBase<SellerSalary, SellerSalary, int, IAPAM_DBEntitiesUnitOfWork> SellerSellerSalariesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SellerViewModel x) => x.SellerSellerSalariesDetails,
                    getRepositoryFunc: x => x.SellerSalaries,
                    foreignKeyExpression: x => x.SellerId,
                    navigationExpression: x => x.Seller);
            }
        }
    }
}
