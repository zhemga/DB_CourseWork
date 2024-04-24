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
    /// Represents the single BookkeeperSalary object view model.
    /// </summary>
    public partial class BookkeeperSalaryViewModel : SingleObjectViewModel<BookkeeperSalary, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BookkeeperSalaryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BookkeeperSalaryViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BookkeeperSalaryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BookkeeperSalaryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BookkeeperSalaryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BookkeeperSalaryViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BookkeeperSalaries, x => x.BookkeeperSalaryId) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bookkeepers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bookkeeper> LookUpBookkeepers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BookkeeperSalaryViewModel x) => x.LookUpBookkeepers,
                    getRepositoryFunc: x => x.Bookkeepers);
            }
        }

    }
}
