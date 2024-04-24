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
    /// Represents the single AdministratorSalary object view model.
    /// </summary>
    public partial class AdministratorSalaryViewModel : SingleObjectViewModel<AdministratorSalary, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AdministratorSalaryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AdministratorSalaryViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AdministratorSalaryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AdministratorSalaryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AdministratorSalaryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AdministratorSalaryViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.AdministratorSalaries, x => x.AdministratorSalaryId) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Administrators for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Administrator> LookUpAdministrators {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AdministratorSalaryViewModel x) => x.LookUpAdministrators,
                    getRepositoryFunc: x => x.Administrators);
            }
        }

    }
}
