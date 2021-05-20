using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using DAL;
using Entities;
using Model;
using Services.Mappers;

namespace Services
{
	public class UserService : IUserService
	{
		private readonly IUnitOfWork _appContext;

		public UserService(IUnitOfWork unitOfWork)
		{
			_appContext = unitOfWork;
		}

		public UserModel Get(int id)
		{
			var user = _appContext.Users.GetById(id).ToModel();
			return user;
		}

		public List<UserModel> GetAll()
		{
			var list = _appContext.Users.GetAll();
			return _appContext.Users.GetAll()
				.Select(user => user.ToModel())
				.ToList();
		}

		public void Add(UserModel entity)
		{
			_appContext.Users.Add(entity.ToEntity());
			_appContext.SaveChanges();
		}
		
		public void Update(UserModel entity)
		{
			_appContext.Users.Update(entity.ToEntity());
			_appContext.SaveChanges();
		}
		
		public void Delete(UserModel entity)
		{
			_appContext.Users.Delete(entity.Id);
			_appContext.SaveChanges();
		}

		public string GetAsJson(UserModel entity)
		{
			return JsonSerializer.Serialize(entity);	
		}


	}
}