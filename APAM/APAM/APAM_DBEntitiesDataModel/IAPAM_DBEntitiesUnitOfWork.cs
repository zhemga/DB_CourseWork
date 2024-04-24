using APAM;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APAM.APAM_DBEntitiesDataModel {

    /// <summary>
    /// IAPAM_DBEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IAPAM_DBEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Address entities repository.
        /// </summary>
		IRepository<Address, int> Addresses { get; }
        
        /// <summary>
        /// The Administrator entities repository.
        /// </summary>
		IRepository<Administrator, int> Administrators { get; }
        
        /// <summary>
        /// The AdministratorContact entities repository.
        /// </summary>
		IRepository<AdministratorContact, int> AdministratorContacts { get; }
        
        /// <summary>
        /// The AdministratorSalary entities repository.
        /// </summary>
		IRepository<AdministratorSalary, int> AdministratorSalaries { get; }
        
        /// <summary>
        /// The AdministratorType entities repository.
        /// </summary>
		IRepository<AdministratorType, int> AdministratorTypes { get; }
        
        /// <summary>
        /// The AutoPart entities repository.
        /// </summary>
		IRepository<AutoPart, int> AutoParts { get; }
        
        /// <summary>
        /// The AutoPartCarModel entities repository.
        /// </summary>
		IRepository<AutoPartCarModel, int> AutoPartCarModels { get; }
        
        /// <summary>
        /// The AutoPartCategory entities repository.
        /// </summary>
		IRepository<AutoPartCategory, int> AutoPartCategories { get; }
        
        /// <summary>
        /// The AutoPartManufacturer entities repository.
        /// </summary>
		IRepository<AutoPartManufacturer, int> AutoPartManufacturers { get; }
        
        /// <summary>
        /// The Bookkeeper entities repository.
        /// </summary>
		IRepository<Bookkeeper, int> Bookkeepers { get; }
        
        /// <summary>
        /// The BookkeeperContact entities repository.
        /// </summary>
		IRepository<BookkeeperContact, int> BookkeeperContacts { get; }
        
        /// <summary>
        /// The BookkeeperSalary entities repository.
        /// </summary>
		IRepository<BookkeeperSalary, int> BookkeeperSalaries { get; }
        
        /// <summary>
        /// The ContactType entities repository.
        /// </summary>
		IRepository<ContactType, int> ContactTypes { get; }
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, int> Customers { get; }
        
        /// <summary>
        /// The CustomerContact entities repository.
        /// </summary>
		IRepository<CustomerContact, int> CustomerContacts { get; }
        
        /// <summary>
        /// The Order entities repository.
        /// </summary>
		IRepository<Order, int> Orders { get; }
        
        /// <summary>
        /// The OrderStatu entities repository.
        /// </summary>
		IRepository<OrderStatu, int> OrderStatus { get; }
        
        /// <summary>
        /// The Seller entities repository.
        /// </summary>
		IRepository<Seller, int> Sellers { get; }
        
        /// <summary>
        /// The SellerContact entities repository.
        /// </summary>
		IRepository<SellerContact, int> SellerContacts { get; }
        
        /// <summary>
        /// The SellerSalary entities repository.
        /// </summary>
		IRepository<SellerSalary, int> SellerSalaries { get; }
    }
}
