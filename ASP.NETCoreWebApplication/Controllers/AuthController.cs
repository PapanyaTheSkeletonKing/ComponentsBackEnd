using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Mappers;
using Utils;

namespace ASP.NETCoreWebApplication.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly IAuthService _authService;

		public AuthController(IUserService userService,IAuthService authService)
		{
			_userService = userService;
			_authService = authService;
		}
		//auth/me => залогінений юзер в json
		[HttpGet]
		[Route("me")]
		public string Me()
		{
			string value  = "{}";
			Request.Cookies.TryGetValue("user", out value);
			return value;
		}
		//auth/login?email=choto&password=choto => залогіниться і вернуть юзера в json
		[HttpPost]
		[Route("login")]
		public string Login(string email,string password)
		{
			var userToAuth = _authService.AuthUser(email, password);
			_authService.UpdateStatus(userToAuth, UserStatus.Authed);

			var userJson = userToAuth.AsJson();
			Response.Cookies.Delete("user");
			Response.Cookies.Append("user",userJson);
			return userJson;
		}
	}
}