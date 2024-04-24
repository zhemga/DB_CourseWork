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
    /// Represents the single Order object view model.
    /// </summary>
    public partial class OrderViewModel : SingleObjectViewModel<Order, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders, x => x.OrderId) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Addresses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddresses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpAddresses,
                    getRepositoryFunc: x => x.Addresses);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of AutoParts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPart> LookUpAutoParts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpAutoParts,
                    getRepositoryFunc: x => x.AutoParts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of OrderStatus for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OrderStatu> LookUpOrderStatus {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpOrderStatus,
                    getRepositoryFunc: x => x.OrderStatus);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sellers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Seller> LookUpSellers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpSellers,
                    getRepositoryFunc: x => x.Sellers);
            }
        }

    }
}
