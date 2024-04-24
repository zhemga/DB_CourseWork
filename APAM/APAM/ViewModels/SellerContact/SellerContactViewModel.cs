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
    /// Represents the single SellerContact object view model.
    /// </summary>
    public partial class SellerContactViewModel : SingleObjectViewModel<SellerContact, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SellerContactViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SellerContactViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SellerContactViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SellerContactViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SellerContactViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SellerContactViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SellerContacts, x => x.Value) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ContactTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ContactType> LookUpContactTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerContactViewModel x) => x.LookUpContactTypes,
                    getRepositoryFunc: x => x.ContactTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sellers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Seller> LookUpSellers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SellerContactViewModel x) => x.LookUpSellers,
                    getRepositoryFunc: x => x.Sellers);
            }
        }

    }
}
