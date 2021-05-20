using Microsoft.AspNetCore.Mvc;
using Services;
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
		
		
		
		[HttpPost]
		[Route("login")]
		public string Login(string email,string password)
		{
			var userToAuth = _authService.AuthUser(email, password);
			_authService.UpdateStatus(userToAuth, UserStatus.Authed);

			var userJson = _userService.GetAsJson(userToAuth);
			Response.Cookies.Append("user",userJson);
			return userJson;
		}
	}
}