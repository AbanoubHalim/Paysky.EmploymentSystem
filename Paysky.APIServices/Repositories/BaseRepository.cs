using Microsoft.EntityFrameworkCore;
using Paysky.APIServices.IRepositories;
using Paysky.Entities.Models.DataBase;

namespace Paysky.APIServices.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

		public T Add(T entity)
		{
			throw new NotImplementedException();
		}

		public List<T> GetAll()
		{
			throw new NotImplementedException();
		}

		public T GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public T GetById(int id)
		{
			throw new NotImplementedException();
		}

		public T SoftDelete(int iD, bool isActive, string columnName)
		{
			throw new NotImplementedException();
		}

		public T Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
