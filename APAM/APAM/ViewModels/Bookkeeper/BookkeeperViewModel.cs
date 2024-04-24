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
    /// Represents the single Bookkeeper object view model.
    /// </summary>
    public partial class BookkeeperViewModel : SingleObjectViewModel<Bookkeeper, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BookkeeperViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BookkeeperViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BookkeeperViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BookkeeperViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BookkeeperViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BookkeeperViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Bookkeepers, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BookkeeperContacts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BookkeeperContact> LookUpBookkeeperContacts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BookkeeperViewModel x) => x.LookUpBookkeeperContacts,
                    getRepositoryFunc: x => x.BookkeeperContacts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of BookkeeperSalaries for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BookkeeperSalary> LookUpBookkeeperSalaries {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BookkeeperViewModel x) => x.LookUpBookkeeperSalaries,
                    getRepositoryFunc: x => x.BookkeeperSalaries);
            }
        }


        /// <summary>
        /// The view model for the BookkeeperBookkeeperContacts detail collection.
        /// </summary>
        public CollectionViewModelBase<BookkeeperContact, BookkeeperContact, int, IAPAM_DBEntitiesUnitOfWork> BookkeeperBookkeeperContactsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BookkeeperViewModel x) => x.BookkeeperBookkeeperContactsDetails,
                    getRepositoryFunc: x => x.BookkeeperContacts,
                    foreignKeyExpression: x => x.BookkeeperId,
                    navigationExpression: x => x.Bookkeeper);
            }
        }

        /// <summary>
        /// The view model for the BookkeeperBookkeeperSalaries detail collection.
        /// </summary>
        public CollectionViewModelBase<BookkeeperSalary, BookkeeperSalary, int, IAPAM_DBEntitiesUnitOfWork> BookkeeperBookkeeperSalariesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BookkeeperViewModel x) => x.BookkeeperBookkeeperSalariesDetails,
                    getRepositoryFunc: x => x.BookkeeperSalaries,
                    foreignKeyExpression: x => x.BookkeeperId,
                    navigationExpression: x => x.Bookkeeper);
            }
        }
    }
}
