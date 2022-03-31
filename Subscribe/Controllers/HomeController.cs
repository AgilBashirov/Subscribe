using Microsoft.AspNetCore.Mvc;
using Subscribe.Data;
using Subscribe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscribe.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> addSubscriber(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                return Json(400);
            }
            Subscriber subscribe = new Subscriber
            {
                Email = email
            };

            await _dbContext.Subscribers.AddAsync(subscribe);
            await _dbContext.SaveChangesAsync();

            return Json(200);
        }
    }
}
