using AddressBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddressBook.Data.Repository;

namespace AddressBook.Data.Repository
{
	public interface IPeopleRepository : IRepository<int, Person>		
	{
		
	}
}
