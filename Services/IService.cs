using System.Collections.Generic;
using Entities;

namespace Services
{
	public interface IService<T>
		where T : class
	{
		T Get(int id);
		List<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(T id);
	}
}