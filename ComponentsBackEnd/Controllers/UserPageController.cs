using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ComponentsBackEnd.Controllers
{
    public class UserPageController : Controller
    {

        private readonly UnitOfWork Data;
        
        public UserPageController(UnitOfWork data)
        {
            Data = data;
        }

        // GET: /page/
        public Task Index()
        {
            var userId = Convert.ToInt32(
                HttpUtility.ParseQueryString(Request.QueryString.ToString())
                .Get("Id"));
            UserEntity user = Data.Users.GetById(userId);
            var jsonString = "{\"foo\":1,\"bar\":false}";
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            Response.ContentType = "application/json";
            await Response.Body.WriteAsync(data, 0, data.Length);
        }
        }
    }
}