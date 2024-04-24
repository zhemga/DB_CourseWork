using APAM;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APAM.APAM_DBEntitiesDataModel {

    /// <summary>
    /// A APAM_DBEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the IAPAM_DBEntitiesUnitOfWork interface.
    /// </summary>
    public class APAM_DBEntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, IAPAM_DBEntitiesUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the APAM_DBEntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public APAM_DBEntitiesDesignTimeUnitOfWork() {
        }

        IRepository<Address, int> IAPAM_DBEntitiesUnitOfWork.Addresses {
            get { return GetRepository((Address x) => x.AdressId); }
        }

        IRepository<Administrator, int> IAPAM_DBEntitiesUnitOfWork.Administrators {
            get { return GetRepository((Administrator x) => x.AdministratorId); }
        }

        IRepository<AdministratorContact, int> IAPAM_DBEntitiesUnitOfWork.AdministratorContacts {
            get { return GetRepository((AdministratorContact x) => x.AdministratorContactId); }
        }

        IRepository<AdministratorSalary, int> IAPAM_DBEntitiesUnitOfWork.AdministratorSalaries {
            get { return GetRepository((AdministratorSalary x) => x.AdministratorSalaryId); }
        }

        IRepository<AdministratorType, int> IAPAM_DBEntitiesUnitOfWork.AdministratorTypes {
            get { return GetRepository((AdministratorType x) => x.AdministratorTypeId); }
        }

        IRepository<AutoPart, int> IAPAM_DBEntitiesUnitOfWork.AutoParts {
            get { return GetRepository((AutoPart x) => x.AutoPartId); }
        }

        IRepository<AutoPartCarModel, int> IAPAM_DBEntitiesUnitOfWork.AutoPartCarModels {
            get { return GetRepository((AutoPartCarModel x) => x.AutoPartCarModelId); }
        }

        IRepository<AutoPartCategory, int> IAPAM_DBEntitiesUnitOfWork.AutoPartCategories {
            get { return GetRepository((AutoPartCategory x) => x.AutoPartCategoryId); }
        }

        IRepository<AutoPartManufacturer, int> IAPAM_DBEntitiesUnitOfWork.AutoPartManufacturers {
            get { return GetRepository((AutoPartManufacturer x) => x.AutoPartManufacturerId); }
        }

        IRepository<Bookkeeper, int> IAPAM_DBEntitiesUnitOfWork.Bookkeepers {
            get { return GetRepository((Bookkeeper x) => x.BookkeeperId); }
        }

        IRepository<BookkeeperContact, int> IAPAM_DBEntitiesUnitOfWork.BookkeeperContacts {
            get { return GetRepository((BookkeeperContact x) => x.BookkeeperContactId); }
        }

        IRepository<BookkeeperSalary, int> IAPAM_DBEntitiesUnitOfWork.BookkeeperSalaries {
            get { return GetRepository((BookkeeperSalary x) => x.BookkeeperSalaryId); }
        }

        IRepository<ContactType, int> IAPAM_DBEntitiesUnitOfWork.ContactTypes {
            get { return GetRepository((ContactType x) => x.ContactTypeId); }
        }

        IRepository<Customer, int> IAPAM_DBEntitiesUnitOfWork.Customers {
            get { return GetRepository((Customer x) => x.CustomerId); }
        }

        IRepository<CustomerContact, int> IAPAM_DBEntitiesUnitOfWork.CustomerContacts {
            get { return GetRepository((CustomerContact x) => x.CusomerContactId); }
        }

        IRepository<Order, int> IAPAM_DBEntitiesUnitOfWork.Orders {
            get { return GetRepository((Order x) => x.OrderId); }
        }

        IRepository<OrderStatu, int> IAPAM_DBEntitiesUnitOfWork.OrderStatus {
            get { return GetRepository((OrderStatu x) => x.OrderStatusId); }
        }

        IRepository<Seller, int> IAPAM_DBEntitiesUnitOfWork.Sellers {
            get { return GetRepository((Seller x) => x.SellerId); }
        }

        IRepository<SellerContact, int> IAPAM_DBEntitiesUnitOfWork.SellerContacts {
            get { return GetRepository((SellerContact x) => x.SellerContactId); }
        }

        IRepository<SellerSalary, int> IAPAM_DBEntitiesUnitOfWork.SellerSalaries {
            get { return GetRepository((SellerSalary x) => x.SellerSalaryId); }
        }
    }
}
