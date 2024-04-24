using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using APAM.APAM_DBEntitiesDataModel;
using APAM.Common;
using APAM;

namespace APAM.ViewModels {

    /// <summary>
    /// Represents the BookkeeperContacts collection view model.
    /// </summary>
    public partial class BookkeeperContactCollectionViewModel : CollectionViewModel<BookkeeperContact, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BookkeeperContactCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BookkeeperContactCollectionViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BookkeeperContactCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BookkeeperContactCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BookkeeperContactCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BookkeeperContactCollectionViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BookkeeperContacts) {
        }
    }
}