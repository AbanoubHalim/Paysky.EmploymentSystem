using System.Linq.Expressions;

namespace Paysky.APIServices.IRepositories
{
	public interface IBaseRepository<T> where T : class
	{
		T GetById(Guid id);
		T GetById(int id);
		List<T> GetAll();
		T Add(T entity);
		T Update(T entity);
		T SoftDelete(int iD, bool isActive, string columnName);

	}
}
