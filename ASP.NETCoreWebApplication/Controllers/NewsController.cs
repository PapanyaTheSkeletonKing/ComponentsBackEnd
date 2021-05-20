using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NewsController : ControllerBase
	{
		[HttpGet]
		public string Get()
		{
			return "{\"1\": \"note\"}";
		}
	}
}