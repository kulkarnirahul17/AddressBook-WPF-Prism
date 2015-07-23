using AddressBook.Data;
using AddressBook.Data.Repository;
using AddressBook.Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.WindowsUI.Services
{
	public class PeopleService: IPeopleService
	{
		IPeopleRepository _repository;
		public PeopleService(IPeopleRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<Person> GetAll()
		{
			return _repository.GetAll();
		}
	}
}
