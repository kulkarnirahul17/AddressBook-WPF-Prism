using AddressBook.Data.Repository;
using AddressBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace AddressBook.WindowsUI.Services
{
	public interface IPeopleService
	{
		IEnumerable<Person> GetAll();
	}
}
