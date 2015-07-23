using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.Data
{
	public interface IRepository<TKey, TEntity> : IDisposable
		where TEntity : class
		where TKey : struct
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetByID(TKey id);
		void Add(TEntity item);
		void Delete(TEntity item);
		void SaveChanges();
	}
}
