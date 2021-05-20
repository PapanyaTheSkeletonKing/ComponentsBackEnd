using DAL;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using Model;
using Services.Mappers;
using Utils;

namespace Services
{
	public class AuthService : IAuthService
	{
		private readonly IUnitOfWork _unitOfWork;
		public AuthService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public UserModel AuthUser(string email, string password) => 
			_unitOfWork.Users
				.GetAll()
				.Find(user => 
					user.Email == email && user.Password == password)
				.ToModel();

		public void UpdateStatus(UserModel user, UserStatus status)
		{
			user.Status = status;
			_unitOfWork.Users.Update(user.ToEntity());
			_unitOfWork.SaveChanges();
		}
	}
}