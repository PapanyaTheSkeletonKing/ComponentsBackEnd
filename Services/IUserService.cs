using Entities;
using Model;

namespace Services
{
	public interface IUserService : IService<UserModel>
	{
		string GetAsJson(UserModel entity);
	}
}