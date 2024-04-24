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
    /// Represents the single Administrator object view model.
    /// </summary>
    public partial class AdministratorViewModel : SingleObjectViewModel<Administrator, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AdministratorViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AdministratorViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AdministratorViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AdministratorViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AdministratorViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AdministratorViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Administrators, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of AdministratorTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AdministratorType> LookUpAdministratorTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorViewModel x) => x.LookUpAdministratorTypes,
                    getRepositoryFunc: x => x.AdministratorTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of AdministratorContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AdministratorContact> LookUpAdministratorContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorViewModel x) => x.LookUpAdministratorContacts,
                    getRepositoryFunc: x => x.AdministratorContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of AdministratorSalaries for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AdministratorSalary> LookUpAdministratorSalaries {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorViewModel x) => x.LookUpAdministratorSalaries,
                    getRepositoryFunc: x => x.AdministratorSalaries);
            }
        }


        /// <summary>
        /// The view model for the AdministratorAdministratorContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<AdministratorContact, AdministratorContact, int, IAPAM_DBEntitiesUnitOfWork> AdministratorAdministratorContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AdministratorViewModel x) => x.AdministratorAdministratorContactsDetails,
                    getRepositoryFunc: x => x.AdministratorContacts,
                    foreignKeyExpression: x => x.AdministratorId,
                    navigationExpression: x => x.Administrator);
            }
        }

        /// <summary>
        /// The view model for the AdministratorAdministratorSalaries detail collection.
        /// </summary>
        public CollectionViewModelBase<AdministratorSalary, AdministratorSalary, int, IAPAM_DBEntitiesUnitOfWork> AdministratorAdministratorSalariesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AdministratorViewModel x) => x.AdministratorAdministratorSalariesDetails,
                    getRepositoryFunc: x => x.AdministratorSalaries,
                    foreignKeyExpression: x => x.AdministratorId,
                    navigationExpression: x => x.Administrator);
            }
        }
    }
}
