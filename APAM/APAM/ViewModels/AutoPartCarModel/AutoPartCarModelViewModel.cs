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
    /// Represents the single AutoPartCarModel object view model.
    /// </summary>
    public partial class AutoPartCarModelViewModel : SingleObjectViewModel<AutoPartCarModel, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AutoPartCarModelViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AutoPartCarModelViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AutoPartCarModelViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AutoPartCarModelViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AutoPartCarModelViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AutoPartCarModelViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AutoPartCarModels, x => x.Brand) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AutoParts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AutoPart> LookUpAutoParts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AutoPartCarModelViewModel x) => x.LookUpAutoParts,
                    getRepositoryFunc: x => x.AutoParts);
            }
        }


        /// <summary>
        /// The view model for the AutoPartCarModelAutoParts detail collection.
        /// </summary>
        public CollectionViewModelBase<AutoPart, AutoPart, int, IAPAM_DBEntitiesUnitOfWork> AutoPartCarModelAutoPartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AutoPartCarModelViewModel x) => x.AutoPartCarModelAutoPartsDetails,
                    getRepositoryFunc: x => x.AutoParts,
                    foreignKeyExpression: x => x.AutoPartCarModelId,
                    navigationExpression: x => x.AutoPartCarModel);
            }
        }
    }
}
