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
    /// Represents the single AutoPartCategory object view model.
    /// </summary>
    public partial class AutoPartCategoryViewModel : SingleObjectViewModel<AutoPartCategory, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AutoPartCategoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AutoPartCategoryViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AutoPartCategoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AutoPartCategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AutoPartCategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AutoPartCategoryViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AutoPartCategories, x => x.Category) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AutoParts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPart> LookUpAutoParts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartCategoryViewModel x) => x.LookUpAutoParts,
                    getRepositoryFunc: x => x.AutoParts);
            }
        }


        /// <summary>
        /// The view model for the AutoPartCategoryAutoParts detail collection.
        /// </summary>
        public CollectionViewModelBase<AutoPart, AutoPart, int, IAPAM_DBEntitiesUnitOfWork> AutoPartCategoryAutoPartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AutoPartCategoryViewModel x) => x.AutoPartCategoryAutoPartsDetails,
                    getRepositoryFunc: x => x.AutoParts,
                    foreignKeyExpression: x => x.AutoPartCategoryId,
                    navigationExpression: x => x.AutoPartCategory);
            }
        }
    }
}
