using System.Linq;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;
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

		[HttpGet("{id:int}")]
		public string Get(int id)
		{
			return _userService.GetAsJson(_userService.Get(id));
			//var users = _userService.GetAll();
			//UserModel user = _userService.GetAll().First();
			//return new FileContentResult(user.Image, "image/jpg");
		}
		
		
		
		
		
		[HttpPut("{id:int}")]
		public void Put(int id,[FromQuery(Name =  "status")]int status)
		{
			var user = _userService.Get(id);
			user.Status = (UserStatus)status;
			_userService.Update(user);
		}
		
		[HttpPost]
		[Route("login")]
		public string Login(string email,string password)
		{
			var userToAuth = _authService.AuthUser(email, password);
			
			_authService.UpdateStatus(userToAuth,UserStatus.Authed);
			return _userService.GetAsJson(userToAuth);
		}
		
		
		
		
	}
}