using Model;
using Utils;

namespace Services
{
	public interface IAuthService
	{
		UserModel AuthUser(string email, string password);
		void UpdateStatus(UserModel user, UserStatus status);
	}
}