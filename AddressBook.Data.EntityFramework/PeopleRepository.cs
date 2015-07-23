using AddressBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.Data.Repository
{
	public class PeopleRepository: EntityFrameworkRepository<int, Person>, IPeopleRepository
	{
		public PeopleRepository() : base()
		{

		}
	}
}
