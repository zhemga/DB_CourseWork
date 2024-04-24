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
    /// Represents the single Address object view model.
    /// </summary>
    public partial class AddressViewModel : SingleObjectViewModel<Address, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AddressViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AddressViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AddressViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AddressViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AddressViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AddressViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Addresses, x => x.Street) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AddressViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the AddressOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> AddressOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AddressViewModel x) => x.AddressOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.From_AdressId,
                    navigationExpression: x => x.Address);
            }
        }

        /// <summary>
        /// The view model for the AddressOrders1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> AddressOrders1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AddressViewModel x) => x.AddressOrders1Details,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.To_AdressId,
                    navigationExpression: x => x.Address1);
            }
        }
    }
}
