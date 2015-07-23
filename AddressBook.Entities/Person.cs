using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.Entities
{
	public class Person
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleInitial { get; set; }
		public string PhoneNumber { get; set; }
		//public virtual List<Address> Addresses { get; set; }
	}
}
