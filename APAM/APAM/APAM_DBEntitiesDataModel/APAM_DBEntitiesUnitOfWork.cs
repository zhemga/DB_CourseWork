using APAM;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APAM.APAM_DBEntitiesDataModel {

    /// <summary>
    /// A APAM_DBEntitiesUnitOfWork instance that represents the run-time implementation of the IAPAM_DBEntitiesUnitOfWork interface.
    /// </summary>
    public class APAM_DBEntitiesUnitOfWork : DbUnitOfWork<APAM_DBEntities>, IAPAM_DBEntitiesUnitOfWork {

        public APAM_DBEntitiesUnitOfWork(Func<APAM_DBEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Address, int> IAPAM_DBEntitiesUnitOfWork.Addresses {
            get { return GetRepository(x => x.Set<Address>(), (Address x) => x.AdressId); }
        }

        IRepository<Administrator, int> IAPAM_DBEntitiesUnitOfWork.Administrators {
            get { return GetRepository(x => x.Set<Administrator>(), (Administrator x) => x.AdministratorId); }
        }

        IRepository<AdministratorContact, int> IAPAM_DBEntitiesUnitOfWork.AdministratorContacts {
            get { return GetRepository(x => x.Set<AdministratorContact>(), (AdministratorContact x) => x.AdministratorContactId); }
        }

        IRepository<AdministratorSalary, int> IAPAM_DBEntitiesUnitOfWork.AdministratorSalaries {
            get { return GetRepository(x => x.Set<AdministratorSalary>(), (AdministratorSalary x) => x.AdministratorSalaryId); }
        }

        IRepository<AdministratorType, int> IAPAM_DBEntitiesUnitOfWork.AdministratorTypes {
            get { return GetRepository(x => x.Set<AdministratorType>(), (AdministratorType x) => x.AdministratorTypeId); }
        }

        IRepository<AutoPart, int> IAPAM_DBEntitiesUnitOfWork.AutoParts {
            get { return GetRepository(x => x.Set<AutoPart>(), (AutoPart x) => x.AutoPartId); }
        }

        IRepository<AutoPartCarModel, int> IAPAM_DBEntitiesUnitOfWork.AutoPartCarModels {
            get { return GetRepository(x => x.Set<AutoPartCarModel>(), (AutoPartCarModel x) => x.AutoPartCarModelId); }
        }

        IRepository<AutoPartCategory, int> IAPAM_DBEntitiesUnitOfWork.AutoPartCategories {
            get { return GetRepository(x => x.Set<AutoPartCategory>(), (AutoPartCategory x) => x.AutoPartCategoryId); }
        }

        IRepository<AutoPartManufacturer, int> IAPAM_DBEntitiesUnitOfWork.AutoPartManufacturers {
            get { return GetRepository(x => x.Set<AutoPartManufacturer>(), (AutoPartManufacturer x) => x.AutoPartManufacturerId); }
        }

        IRepository<Bookkeeper, int> IAPAM_DBEntitiesUnitOfWork.Bookkeepers {
            get { return GetRepository(x => x.Set<Bookkeeper>(), (Bookkeeper x) => x.BookkeeperId); }
        }

        IRepository<BookkeeperContact, int> IAPAM_DBEntitiesUnitOfWork.BookkeeperContacts {
            get { return GetRepository(x => x.Set<BookkeeperContact>(), (BookkeeperContact x) => x.BookkeeperContactId); }
        }

        IRepository<BookkeeperSalary, int> IAPAM_DBEntitiesUnitOfWork.BookkeeperSalaries {
            get { return GetRepository(x => x.Set<BookkeeperSalary>(), (BookkeeperSalary x) => x.BookkeeperSalaryId); }
        }

        IRepository<ContactType, int> IAPAM_DBEntitiesUnitOfWork.ContactTypes {
            get { return GetRepository(x => x.Set<ContactType>(), (ContactType x) => x.ContactTypeId); }
        }

        IRepository<Customer, int> IAPAM_DBEntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.CustomerId); }
        }

        IRepository<CustomerContact, int> IAPAM_DBEntitiesUnitOfWork.CustomerContacts {
            get { return GetRepository(x => x.Set<CustomerContact>(), (CustomerContact x) => x.CusomerContactId); }
        }

        IRepository<Order, int> IAPAM_DBEntitiesUnitOfWork.Orders {
            get { return GetRepository(x => x.Set<Order>(), (Order x) => x.OrderId); }
        }

        IRepository<OrderStatu, int> IAPAM_DBEntitiesUnitOfWork.OrderStatus {
            get { return GetRepository(x => x.Set<OrderStatu>(), (OrderStatu x) => x.OrderStatusId); }
        }

        IRepository<Seller, int> IAPAM_DBEntitiesUnitOfWork.Sellers {
            get { return GetRepository(x => x.Set<Seller>(), (Seller x) => x.SellerId); }
        }

        IRepository<SellerContact, int> IAPAM_DBEntitiesUnitOfWork.SellerContacts {
            get { return GetRepository(x => x.Set<SellerContact>(), (SellerContact x) => x.SellerContactId); }
        }

        IRepository<SellerSalary, int> IAPAM_DBEntitiesUnitOfWork.SellerSalaries {
            get { return GetRepository(x => x.Set<SellerSalary>(), (SellerSalary x) => x.SellerSalaryId); }
        }
    }
}
