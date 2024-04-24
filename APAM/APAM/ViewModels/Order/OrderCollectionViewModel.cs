﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using APAM.APAM_DBEntitiesDataModel;
using APAM.Common;
using APAM;

namespace APAM.ViewModels {

    /// <summary>
    /// Represents the Orders collection view model.
    /// </summary>
    public partial class OrderCollectionViewModel : CollectionViewModel<Order, int, IAPAM_DBEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderCollectionViewModel Create(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderCollectionViewModel(IUnitOfWorkFactory<IAPAM_DBEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders) {
        }
    }
}