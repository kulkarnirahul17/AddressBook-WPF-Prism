using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AddressBook.Data.Repository
{
	public class EntityFrameworkRepository<TKey, TEntity> : IRepository<TKey, TEntity>
		where TEntity : class
		where TKey : struct
	{
		public DbContext _context;
		IDbSet<TEntity> _dbSet;

		public EntityFrameworkRepository() : this(new AddressBookContext())
		{

		}

		public EntityFrameworkRepository(DbContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet;
		}

		public TEntity GetByID(TKey id)
		{
			return _dbSet.Find(id);
		}

		public void Add(TEntity item)
		{
			_dbSet.Add(item);
			_context.SaveChanges();
		}

		public void Delete(TEntity item)
		{
			_dbSet.Remove(item);
			_context.SaveChanges();
		}

		public void Dispose()
		{
			if (_context != null)
				_context.Dispose();
		}

		/// <summary>
		/// Saves the repository changes
		/// </summary>
		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}

}
