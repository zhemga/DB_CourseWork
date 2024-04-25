using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using APAM.Localization;
using APAM.APAM_DBEntitiesDataModel;
using APAM.Common;

namespace APAM.ViewModels
{
    /// <summary>
    /// Represents the root POCO view model for the APAM_DBEntities data model.
    /// </summary>
    public partial class APAM_DBEntitiesViewModel : DocumentsViewModel<APAM_DBEntitiesModuleDescription, IAPAM_DBEntitiesUnitOfWork>
    {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";
        INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        /// <summary>
        /// Creates a new instance of APAM_DBEntitiesViewModel as a POCO view model.
        /// </summary>
        public static APAM_DBEntitiesViewModel Create()
        {
            return ViewModelSource.Create(() => new APAM_DBEntitiesViewModel());
        }

        static APAM_DBEntitiesViewModel()
        {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<APAM_DBEntitiesMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the APAM_DBEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the APAM_DBEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected APAM_DBEntitiesViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
        }

        protected override APAM_DBEntitiesModuleDescription[] CreateModules()
        {
            var modules = new List<APAM_DBEntitiesModuleDescription>();
            
            if (UserData.IsAdmin || UserData.IsBookkeeper)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AddressPlural, "AddressCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Addresses)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AdministratorPlural, "AdministratorCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Administrators)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AdministratorContactPlural, "AdministratorContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AdministratorContacts)));
            if (UserData.IsAdmin || UserData.IsBookkeeper)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AdministratorSalaryPlural, "AdministratorSalaryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AdministratorSalaries)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AdministratorTypePlural, "AdministratorTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AdministratorTypes)));
            if (UserData.IsAdmin || UserData.IsBookkeeper || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AutoPartPlural, "AutoPartCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AutoParts)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AutoPartCarModelPlural, "AutoPartCarModelCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AutoPartCarModels)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AutoPartCategoryPlural, "AutoPartCategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AutoPartCategories)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.AutoPartManufacturerPlural, "AutoPartManufacturerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.AutoPartManufacturers)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.BookkeeperPlural, "BookkeeperCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Bookkeepers)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.BookkeeperContactPlural, "BookkeeperContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.BookkeeperContacts)));
            if (UserData.IsAdmin || UserData.IsBookkeeper)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.BookkeeperSalaryPlural, "BookkeeperSalaryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.BookkeeperSalaries)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.ContactTypePlural, "ContactTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ContactTypes)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.CustomerPlural, "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.CustomerContactPlural, "CustomerContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomerContacts)));
            if (UserData.IsAdmin || UserData.IsBookkeeper || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.OrderPlural, "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders)));
            if (UserData.IsAdmin)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.OrderStatuPlural, "OrderStatuCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.OrderStatus)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.SellerPlural, "SellerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Sellers)));
            if (UserData.IsAdmin || UserData.IsManager)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.SellerContactPlural, "SellerContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.SellerContacts)));
            if (UserData.IsAdmin || UserData.IsBookkeeper)
                modules.Add(new APAM_DBEntitiesModuleDescription(APAM_DBEntitiesResources.SellerSalaryPlural, "SellerSalaryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.SellerSalaries)));

            return modules.ToArray();
        }
        protected override void OnActiveModuleChanged(APAM_DBEntitiesModuleDescription oldModule)
        {
            if (ActiveModule != null && NavigationService != null)
            {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
    }

    public partial class APAM_DBEntitiesModuleDescription : ModuleDescription<APAM_DBEntitiesModuleDescription>
    {
        public APAM_DBEntitiesModuleDescription(string title, string documentType, string group, Func<APAM_DBEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory)
        {
        }
    }
}