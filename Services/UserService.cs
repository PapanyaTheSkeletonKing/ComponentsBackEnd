using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using DAL;
using Entities;
using Model;
using Models;
using Services.Mappers;

namespace Services
{
	public class UserService : IUserService
	{
		private readonly IUnitOfWork _unitOfWork;

		public UserService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public UserModel Get(int id)
		{
			var users = _unitOfWork.Users.GetAll();
			var chel = _unitOfWork.Followings.GetAll();
			
			var user = _unitOfWork.Users.GetById(id).ToModel();
			return user;
		}

		public List<UserModel> GetAll()
		{
			var users = _unitOfWork.Users.GetAll()
				.Select(user => user.ToModel())
				.ToList();
			return users;
		}

		public void Add(UserModel model)
		{
			_unitOfWork.Users.Add(model.ToEntity());
			_unitOfWork.SaveChanges();
		}
		
		public void Update(UserModel entity)
		{
			_unitOfWork.Users.Update(entity.ToEntity());
			_unitOfWork.SaveChanges();
		}
		
		public void Delete(UserModel entity)
		{
			_unitOfWork.Users.Delete(entity.Id);
			_unitOfWork.SaveChanges();
		}
		


	}
}