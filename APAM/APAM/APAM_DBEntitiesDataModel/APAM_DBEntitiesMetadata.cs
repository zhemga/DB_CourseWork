using APAM;
using APAM.Localization;
using DevExpress.Mvvm.DataAnnotations;

namespace APAM.APAM_DBEntitiesDataModel {

    public class APAM_DBEntitiesMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Address> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Address);
						builder.Property(x => x.AdressId).DisplayName(APAM_DBEntitiesResources.Address_AdressId);
						builder.Property(x => x.Street).DisplayName(APAM_DBEntitiesResources.Address_Street);
						builder.Property(x => x.BuildingNumber).DisplayName(APAM_DBEntitiesResources.Address_BuildingNumber);
						builder.Property(x => x.BuildingLetter).DisplayName(APAM_DBEntitiesResources.Address_BuildingLetter);
						builder.Property(x => x.CorpusNumber).DisplayName(APAM_DBEntitiesResources.Address_CorpusNumber);
						builder.Property(x => x.ApartmentNumber).DisplayName(APAM_DBEntitiesResources.Address_ApartmentNumber);
						builder.Property(x => x.Settlement).DisplayName(APAM_DBEntitiesResources.Address_Settlement);
						builder.Property(x => x.District).DisplayName(APAM_DBEntitiesResources.Address_District);
						builder.Property(x => x.Region).DisplayName(APAM_DBEntitiesResources.Address_Region);
						builder.Property(x => x.PostalCode).DisplayName(APAM_DBEntitiesResources.Address_PostalCode);
			        }
		        public static void BuildMetadata(MetadataBuilder<Administrator> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Administrator);
						builder.Property(x => x.AdministratorId).DisplayName(APAM_DBEntitiesResources.Administrator_AdministratorId);
						builder.Property(x => x.Name).DisplayName(APAM_DBEntitiesResources.Administrator_Name);
						builder.Property(x => x.Surname).DisplayName(APAM_DBEntitiesResources.Administrator_Surname);
						builder.Property(x => x.MiddleName).DisplayName(APAM_DBEntitiesResources.Administrator_MiddleName);
						builder.Property(x => x.AdministratorType).DisplayName(APAM_DBEntitiesResources.Administrator_AdministratorType);
			        }
		        public static void BuildMetadata(MetadataBuilder<AdministratorContact> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AdministratorContact);
						builder.Property(x => x.AdministratorContactId).DisplayName(APAM_DBEntitiesResources.AdministratorContact_AdministratorContactId);
						builder.Property(x => x.Value).DisplayName(APAM_DBEntitiesResources.AdministratorContact_Value);
						builder.Property(x => x.Administrator).DisplayName(APAM_DBEntitiesResources.AdministratorContact_Administrator);
						builder.Property(x => x.ContactType).DisplayName(APAM_DBEntitiesResources.AdministratorContact_ContactType);
			        }
		        public static void BuildMetadata(MetadataBuilder<AdministratorSalary> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AdministratorSalary);
						builder.Property(x => x.AdministratorSalaryId).DisplayName(APAM_DBEntitiesResources.AdministratorSalary_AdministratorSalaryId);
						builder.Property(x => x.Salary).DisplayName(APAM_DBEntitiesResources.AdministratorSalary_Salary);
						builder.Property(x => x.IssueDate).DisplayName(APAM_DBEntitiesResources.AdministratorSalary_IssueDate);
						builder.Property(x => x.Administrator).DisplayName(APAM_DBEntitiesResources.AdministratorSalary_Administrator);
			        }
		        public static void BuildMetadata(MetadataBuilder<AdministratorType> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AdministratorType);
						builder.Property(x => x.AdministratorTypeId).DisplayName(APAM_DBEntitiesResources.AdministratorType_AdministratorTypeId);
						builder.Property(x => x.Type).DisplayName(APAM_DBEntitiesResources.AdministratorType_Type);
			        }
		        public static void BuildMetadata(MetadataBuilder<AutoPart> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AutoPart);
						builder.Property(x => x.AutoPartId).DisplayName(APAM_DBEntitiesResources.AutoPart_AutoPartId);
						builder.Property(x => x.Article).DisplayName(APAM_DBEntitiesResources.AutoPart_Article);
						builder.Property(x => x.ManufacturerPartCode).DisplayName(APAM_DBEntitiesResources.AutoPart_ManufacturerPartCode);
						builder.Property(x => x.Cost).DisplayName(APAM_DBEntitiesResources.AutoPart_Cost);
						builder.Property(x => x.AutoPartCarModel).DisplayName(APAM_DBEntitiesResources.AutoPart_AutoPartCarModel);
						builder.Property(x => x.AutoPartCategory).DisplayName(APAM_DBEntitiesResources.AutoPart_AutoPartCategory);
						builder.Property(x => x.AutoPartManufacturer).DisplayName(APAM_DBEntitiesResources.AutoPart_AutoPartManufacturer);
			        }
		        public static void BuildMetadata(MetadataBuilder<AutoPartCarModel> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AutoPartCarModel);
						builder.Property(x => x.AutoPartCarModelId).DisplayName(APAM_DBEntitiesResources.AutoPartCarModel_AutoPartCarModelId);
						builder.Property(x => x.Brand).DisplayName(APAM_DBEntitiesResources.AutoPartCarModel_Brand);
						builder.Property(x => x.Model).DisplayName(APAM_DBEntitiesResources.AutoPartCarModel_Model);
			        }
		        public static void BuildMetadata(MetadataBuilder<AutoPartCategory> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AutoPartCategory);
						builder.Property(x => x.AutoPartCategoryId).DisplayName(APAM_DBEntitiesResources.AutoPartCategory_AutoPartCategoryId);
						builder.Property(x => x.Category).DisplayName(APAM_DBEntitiesResources.AutoPartCategory_Category);
			        }
		        public static void BuildMetadata(MetadataBuilder<AutoPartManufacturer> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.AutoPartManufacturer);
						builder.Property(x => x.AutoPartManufacturerId).DisplayName(APAM_DBEntitiesResources.AutoPartManufacturer_AutoPartManufacturerId);
						builder.Property(x => x.Manufacturer).DisplayName(APAM_DBEntitiesResources.AutoPartManufacturer_Manufacturer);
			        }
		        public static void BuildMetadata(MetadataBuilder<Bookkeeper> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Bookkeeper);
						builder.Property(x => x.BookkeeperId).DisplayName(APAM_DBEntitiesResources.Bookkeeper_BookkeeperId);
						builder.Property(x => x.Name).DisplayName(APAM_DBEntitiesResources.Bookkeeper_Name);
						builder.Property(x => x.Surname).DisplayName(APAM_DBEntitiesResources.Bookkeeper_Surname);
						builder.Property(x => x.MiddleName).DisplayName(APAM_DBEntitiesResources.Bookkeeper_MiddleName);
			        }
		        public static void BuildMetadata(MetadataBuilder<BookkeeperContact> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.BookkeeperContact);
						builder.Property(x => x.BookkeeperContactId).DisplayName(APAM_DBEntitiesResources.BookkeeperContact_BookkeeperContactId);
						builder.Property(x => x.Value).DisplayName(APAM_DBEntitiesResources.BookkeeperContact_Value);
						builder.Property(x => x.Bookkeeper).DisplayName(APAM_DBEntitiesResources.BookkeeperContact_Bookkeeper);
						builder.Property(x => x.ContactType).DisplayName(APAM_DBEntitiesResources.BookkeeperContact_ContactType);
			        }
		        public static void BuildMetadata(MetadataBuilder<BookkeeperSalary> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.BookkeeperSalary);
						builder.Property(x => x.BookkeeperSalaryId).DisplayName(APAM_DBEntitiesResources.BookkeeperSalary_BookkeeperSalaryId);
						builder.Property(x => x.Salary).DisplayName(APAM_DBEntitiesResources.BookkeeperSalary_Salary);
						builder.Property(x => x.IssueDate).DisplayName(APAM_DBEntitiesResources.BookkeeperSalary_IssueDate);
						builder.Property(x => x.Bookkeeper).DisplayName(APAM_DBEntitiesResources.BookkeeperSalary_Bookkeeper);
			        }
		        public static void BuildMetadata(MetadataBuilder<ContactType> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.ContactType);
						builder.Property(x => x.ContactTypeId).DisplayName(APAM_DBEntitiesResources.ContactType_ContactTypeId);
						builder.Property(x => x.Type).DisplayName(APAM_DBEntitiesResources.ContactType_Type);
			        }
		        public static void BuildMetadata(MetadataBuilder<Customer> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Customer);
						builder.Property(x => x.CustomerId).DisplayName(APAM_DBEntitiesResources.Customer_CustomerId);
						builder.Property(x => x.Name).DisplayName(APAM_DBEntitiesResources.Customer_Name);
						builder.Property(x => x.Surname).DisplayName(APAM_DBEntitiesResources.Customer_Surname);
						builder.Property(x => x.MiddleName).DisplayName(APAM_DBEntitiesResources.Customer_MiddleName);
						builder.Property(x => x.BirthDate).DisplayName(APAM_DBEntitiesResources.Customer_BirthDate);
			        }
		        public static void BuildMetadata(MetadataBuilder<CustomerContact> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.CustomerContact);
						builder.Property(x => x.CusomerContactId).DisplayName(APAM_DBEntitiesResources.CustomerContact_CusomerContactId);
						builder.Property(x => x.Value).DisplayName(APAM_DBEntitiesResources.CustomerContact_Value);
						builder.Property(x => x.ContactType).DisplayName(APAM_DBEntitiesResources.CustomerContact_ContactType);
						builder.Property(x => x.Customer).DisplayName(APAM_DBEntitiesResources.CustomerContact_Customer);
			        }
		        public static void BuildMetadata(MetadataBuilder<Order> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Order);
						builder.Property(x => x.OrderId).DisplayName(APAM_DBEntitiesResources.Order_OrderId);
						builder.Property(x => x.Date).DisplayName(APAM_DBEntitiesResources.Order_Date);
						builder.Property(x => x.OrderCreatedDateTime).DisplayName(APAM_DBEntitiesResources.Order_OrderCreatedDateTime);
						builder.Property(x => x.OrderFinishedDateTime).DisplayName(APAM_DBEntitiesResources.Order_OrderFinishedDateTime);
						builder.Property(x => x.Address).DisplayName(APAM_DBEntitiesResources.Order_Address);
						builder.Property(x => x.Address1).DisplayName(APAM_DBEntitiesResources.Order_Address1);
						builder.Property(x => x.AutoPart).DisplayName(APAM_DBEntitiesResources.Order_AutoPart);
						builder.Property(x => x.Customer).DisplayName(APAM_DBEntitiesResources.Order_Customer);
						builder.Property(x => x.OrderStatu).DisplayName(APAM_DBEntitiesResources.Order_OrderStatu);
						builder.Property(x => x.Seller).DisplayName(APAM_DBEntitiesResources.Order_Seller);
			        }
		        public static void BuildMetadata(MetadataBuilder<OrderStatu> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.OrderStatu);
						builder.Property(x => x.OrderStatusId).DisplayName(APAM_DBEntitiesResources.OrderStatu_OrderStatusId);
						builder.Property(x => x.Status).DisplayName(APAM_DBEntitiesResources.OrderStatu_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Seller> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.Seller);
						builder.Property(x => x.SellerId).DisplayName(APAM_DBEntitiesResources.Seller_SellerId);
						builder.Property(x => x.Name).DisplayName(APAM_DBEntitiesResources.Seller_Name);
						builder.Property(x => x.Surname).DisplayName(APAM_DBEntitiesResources.Seller_Surname);
						builder.Property(x => x.MiddleName).DisplayName(APAM_DBEntitiesResources.Seller_MiddleName);
			        }
		        public static void BuildMetadata(MetadataBuilder<SellerContact> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.SellerContact);
						builder.Property(x => x.SellerContactId).DisplayName(APAM_DBEntitiesResources.SellerContact_SellerContactId);
						builder.Property(x => x.Value).DisplayName(APAM_DBEntitiesResources.SellerContact_Value);
						builder.Property(x => x.ContactType).DisplayName(APAM_DBEntitiesResources.SellerContact_ContactType);
						builder.Property(x => x.Seller).DisplayName(APAM_DBEntitiesResources.SellerContact_Seller);
			        }
		        public static void BuildMetadata(MetadataBuilder<SellerSalary> builder) {
			builder.DisplayName(APAM_DBEntitiesResources.SellerSalary);
						builder.Property(x => x.SellerSalaryId).DisplayName(APAM_DBEntitiesResources.SellerSalary_SellerSalaryId);
						builder.Property(x => x.Salary).DisplayName(APAM_DBEntitiesResources.SellerSalary_Salary);
						builder.Property(x => x.IssueDate).DisplayName(APAM_DBEntitiesResources.SellerSalary_IssueDate);
						builder.Property(x => x.Seller).DisplayName(APAM_DBEntitiesResources.SellerSalary_Seller);
			        }
		    }
}