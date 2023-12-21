using MainApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MainApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("app/react")]
        public IActionResult ReactApp()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
