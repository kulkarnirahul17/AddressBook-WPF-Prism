using AddressBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace AddressBook.Data.Repository.Mappings
{
	internal class PersonConfigMap : EntityTypeConfiguration<Person>
	{
		public PersonConfigMap()
		{
			ToTable("People");
			Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.FirstName).HasMaxLength(25);
			Property(p => p.MiddleInitial).HasMaxLength(1);
			Property(p => p.LastName).HasMaxLength(25);
			Property(p => p.PhoneNumber).HasMaxLength(10);
			//Property(p => p.Addresses);

		}
	}
}
