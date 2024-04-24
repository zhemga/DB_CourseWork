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
    /// Represents the single OrderStatu object view model.
    /// </summary>
    public partial class OrderStatuViewModel : SingleObjectViewModel<OrderStatu, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderStatuViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderStatuViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderStatuViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderStatuViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderStatuViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderStatuViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OrderStatus, x => x.Status) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderStatuViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the OrderStatuOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> OrderStatuOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OrderStatuViewModel x) => x.OrderStatuOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.OrderStatusId,
                    navigationExpression: x => x.OrderStatu);
            }
        }
    }
}
