using System.Collections.Generic;

namespace Repositories.Abstractions
{
	public interface IRepository<T>
	{
		void Add(T obj);
		void Update(T obj);
		List<T> GetAll();

		T GetById(int id);

		void Delete(int id);
	}
}