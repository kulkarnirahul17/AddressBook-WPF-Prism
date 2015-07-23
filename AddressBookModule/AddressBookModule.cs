using AddressBook.Data;
using AddressBook.Data.Repository;
using AddressBook.Infrastructure;
using AddressBook.WindowsUI.Services;
using AddressBook.WindowsUI.ViewModels;
using AddressBook.WindowsUI.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;

namespace AddressBook.WindowsUI
{
	public class AddressBookModule : IModule
	{
		IUnityContainer _container;
		IRegionManager _regionManager;

		public AddressBookModule(IUnityContainer container, IRegionManager regionManager)
		{
			_container = container;
			_regionManager = regionManager;
		}

		public void Initialize()
		{
			_container.RegisterType<IView, AddressBookPeopleView>();
			_container.RegisterType<IAddressBookViewModel, AddressBookViewModel>();
			_container.RegisterType<IPeopleRepository, PeopleRepository>();
			//_container.RegisterType<IPeopleService, PeopleService>(new ContainerControlledLifetimeManager());

			var vm = _container.Resolve<IAddressBookViewModel>();

			IRegion region = _regionManager.Regions[RegionNames.CONTENT_REGION_LEFT];
			if (region == null)
				throw new ArgumentNullException(string.Format("Region {0} could not be found"));

			region.Add(vm.View);
		}
	}
}
