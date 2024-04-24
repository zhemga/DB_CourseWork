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
    /// Represents the single AutoPartManufacturer object view model.
    /// </summary>
    public partial class AutoPartManufacturerViewModel : SingleObjectViewModel<AutoPartManufacturer, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AutoPartManufacturerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AutoPartManufacturerViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AutoPartManufacturerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AutoPartManufacturerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AutoPartManufacturerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AutoPartManufacturerViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AutoPartManufacturers, x => x.Manufacturer) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AutoParts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPart> LookUpAutoParts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartManufacturerViewModel x) => x.LookUpAutoParts,
                    getRepositoryFunc: x => x.AutoParts);
            }
        }


        /// <summary>
        /// The view model for the AutoPartManufacturerAutoParts detail collection.
        /// </summary>
        public CollectionViewModelBase<AutoPart, AutoPart, int, IAPAM_DBEntitiesUnitOfWork> AutoPartManufacturerAutoPartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AutoPartManufacturerViewModel x) => x.AutoPartManufacturerAutoPartsDetails,
                    getRepositoryFunc: x => x.AutoParts,
                    foreignKeyExpression: x => x.AutoPartManufacturerId,
                    navigationExpression: x => x.AutoPartManufacturer);
            }
        }
    }
}
