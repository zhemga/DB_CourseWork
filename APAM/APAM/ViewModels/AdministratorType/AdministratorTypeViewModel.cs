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
    /// Represents the single AdministratorType object view model.
    /// </summary>
    public partial class AdministratorTypeViewModel : SingleObjectViewModel<AdministratorType, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AdministratorTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AdministratorTypeViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AdministratorTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AdministratorTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AdministratorTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AdministratorTypeViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AdministratorTypes, x => x.Type) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Administrators for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Administrator> LookUpAdministrators {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorTypeViewModel x) => x.LookUpAdministrators,
                    getRepositoryFunc: x => x.Administrators);
            }
        }


        /// <summary>
        /// The view model for the AdministratorTypeAdministrators detail collection.
        /// </summary>
        public CollectionViewModelBase<Administrator, Administrator, int, IAPAM_DBEntitiesUnitOfWork> AdministratorTypeAdministratorsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AdministratorTypeViewModel x) => x.AdministratorTypeAdministratorsDetails,
                    getRepositoryFunc: x => x.Administrators,
                    foreignKeyExpression: x => x.AdministratorTypeId,
                    navigationExpression: x => x.AdministratorType);
            }
        }
    }
}
