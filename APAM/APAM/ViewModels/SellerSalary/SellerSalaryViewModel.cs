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
    /// Represents the single SellerSalary object view model.
    /// </summary>
    public partial class SellerSalaryViewModel : SingleObjectViewModel<SellerSalary, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SellerSalaryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SellerSalaryViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SellerSalaryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SellerSalaryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SellerSalaryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SellerSalaryViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SellerSalaries, x => x.SellerSalaryId) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Sellers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Seller> LookUpSellers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerSalaryViewModel x) => x.LookUpSellers,
                    getRepositoryFunc: x => x.Sellers);
            }
        }

    }
}
