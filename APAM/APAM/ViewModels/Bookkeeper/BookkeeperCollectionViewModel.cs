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
    /// Represents the Bookkeepers collection view model.
    /// </summary>
    public partial class BookkeeperCollectionViewModel : CollectionViewModel<Bookkeeper, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BookkeeperCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BookkeeperCollectionViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BookkeeperCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BookkeeperCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BookkeeperCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BookkeeperCollectionViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Bookkeepers) {
        }
    }
}