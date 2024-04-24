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
    /// Represents the single AdministratorContact object view model.
    /// </summary>
    public partial class AdministratorContactViewModel : SingleObjectViewModel<AdministratorContact, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AdministratorContactViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AdministratorContactViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AdministratorContactViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AdministratorContactViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AdministratorContactViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AdministratorContactViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AdministratorContacts, x => x.Value) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Administrators for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Administrator> LookUpAdministrators {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorContactViewModel x) => x.LookUpAdministrators,
                    getRepositoryFunc: x => x.Administrators);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ContactTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ContactType> LookUpContactTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorContactViewModel x) => x.LookUpContactTypes,
                    getRepositoryFunc: x => x.ContactTypes);
            }
        }

    }
}
