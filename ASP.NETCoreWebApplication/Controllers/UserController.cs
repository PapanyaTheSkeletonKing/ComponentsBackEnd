using System.Linq;using Entities;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;
using Services.Mappers;
using Utils;



namespace ASP.NETCoreWebApplication.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly IAuthService _authService;

		public UserController(IUserService userService,IAuthService authService)
		{
			_userService = userService;
			_authService = authService;
		}
		//user/id => user json
		[HttpGet("{id:int}")]
		public string Get(int id)
		{
			return _userService.Get(id).AsJson();
			//var users = _userService.GetAll();
			//UserModel user = _userService.GetAll().First();
			//return new FileContentResult(user.Image, "image/jpg");
		}
		//user/follow?userId=
		[HttpGet("follow")]
		public string Follow(int userId) => _userService.Get(1)
				.Followers.First()
				.AsJson();
			//var users = _userService.GetAll();
			//UserModel user = _userService.GetAll().First();
			//return new FileContentResult(user.Image, "image/jpg");
		//user/id?status=choto
		[HttpPut("{id:int}")] 
		public void Put(int id,[FromQuery(Name =  "status")]int status)
		{
			var user = _userService.Get(id);
			user.Status = (UserStatus)status;
			_userService.Update(user);
		}
	}
}