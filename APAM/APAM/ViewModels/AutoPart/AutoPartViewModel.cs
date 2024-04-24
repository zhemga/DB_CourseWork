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
    /// Represents the single AutoPart object view model.
    /// </summary>
    public partial class AutoPartViewModel : SingleObjectViewModel<AutoPart, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AutoPartViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AutoPartViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AutoPartViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AutoPartViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AutoPartViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AutoPartViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AutoParts, x => x.Article) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AutoPartCarModels for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPartCarModel> LookUpAutoPartCarModels {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartViewModel x) => x.LookUpAutoPartCarModels,
                    getRepositoryFunc: x => x.AutoPartCarModels);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of AutoPartCategories for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPartCategory> LookUpAutoPartCategories {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartViewModel x) => x.LookUpAutoPartCategories,
                    getRepositoryFunc: x => x.AutoPartCategories);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of AutoPartManufacturers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPartManufacturer> LookUpAutoPartManufacturers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartViewModel x) => x.LookUpAutoPartManufacturers,
                    getRepositoryFunc: x => x.AutoPartManufacturers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the AutoPartOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IAPAM_DBEntitiesUnitOfWork> AutoPartOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AutoPartViewModel x) => x.AutoPartOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.AutoPartId,
                    navigationExpression: x => x.AutoPart);
            }
        }
    }
}
