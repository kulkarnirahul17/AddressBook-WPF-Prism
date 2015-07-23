using AddressBook.Data.Repository.Mappings;
using AddressBook.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AddressBook.Data.Repository
{
	public class AddressBookContext : DbContext
	{
		public AddressBookContext()
			:base("master")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new PersonConfigMap());

		}

		IDbSet<Person> People { get; set; }
	}
}
