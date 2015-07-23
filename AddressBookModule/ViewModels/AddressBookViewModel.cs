using AddressBook.Data;
using AddressBook.Data.Repository;
using AddressBook.Entities;
using AddressBook.WindowsUI.Services;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.WindowsUI.ViewModels
{
	public class AddressBookViewModel : BindableBase, IAddressBookViewModel
	{
		//IPeopleService _peopleService;

		public AddressBookViewModel(IPeopleRepository repository, Infrastructure.IView view)
		{
			//_peopleService = peopleService;
			//this.People = _peopleService.GetAll().ToList();
			var people = repository.GetAll().ToList();
			_people = people;
			View = view;
			View.ViewModel = this;


		}

		public Infrastructure.IView View { get; set; }

		private List<Person> _people;
		public List<Person> People
		{
			get { return _people; }
			set
			{
				SetProperty(ref _people, People);
			}
		}

		private Person _selectedPerson;
		public Person SelectedPerson
		{
			get { return _selectedPerson; }
			set { _selectedPerson = value; }
		}



	}
}
