using Mellim_birin_ozunun_isleyin_bizde_oyrenek.DAL;
using Mellim_birin_ozunun_isleyin_bizde_oyrenek.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mellim_birin_ozunun_isleyin_bizde_oyrenek.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
           List<Explore> explores=_dbContext.Explores.ToList();
            return View(explores);
        }

        
    }
}
