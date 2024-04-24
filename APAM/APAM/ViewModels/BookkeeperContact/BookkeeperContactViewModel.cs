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
    /// Represents the single BookkeeperContact object view model.
    /// </summary>
    public partial class BookkeeperContactViewModel : SingleObjectViewModel<BookkeeperContact, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BookkeeperContactViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BookkeeperContactViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BookkeeperContactViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BookkeeperContactViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BookkeeperContactViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BookkeeperContactViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BookkeeperContacts, x => x.Value) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bookkeepers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bookkeeper> LookUpBookkeepers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BookkeeperContactViewModel x) => x.LookUpBookkeepers,
                    getRepositoryFunc: x => x.Bookkeepers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ContactTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ContactType> LookUpContactTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BookkeeperContactViewModel x) => x.LookUpContactTypes,
                    getRepositoryFunc: x => x.ContactTypes);
            }
        }

    }
}
