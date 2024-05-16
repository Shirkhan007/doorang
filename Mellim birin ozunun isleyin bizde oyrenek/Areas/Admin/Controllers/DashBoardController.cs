using Microsoft.AspNetCore.Mvc;

namespace Mellim_birin_ozunun_isleyin_bizde_oyrenek.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
