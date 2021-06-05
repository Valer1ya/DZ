using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DZ.Models;
using System.Linq;
using DZ.ViewModels;
using System.Threading.Tasks;

namespace DZ.Controllers
{
    public class HomeController : Controller
    {
        private UserContext _context;
        public HomeController(UserContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            ViewBag.Detachments = _context.DetachmentsModels.ToArray();
            return View();
        }

        public IActionResult AddDett()
        {
            ViewBag.University = _context.UniversityModels.ToArray();
            ViewBag.Profile = _context.ProfileModels.ToArray();
            return View();
        }

        [HttpPost]
        public IActionResult AddDett(DetachmentRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                DetachmentsModel dm = _context.DetachmentsModels.FirstOrDefault(d => d.Name == model.Name);
                if (dm == null)
                {
                    dm = new DetachmentsModel { Name = model.Name, StartDate = model.StarDate};
                    ProfileModel pf = _context.ProfileModels.FirstOrDefault(p => p.Name == model.Profile);
                    dm.Profile = pf;
                    UniversityModel um = _context.UniversityModels.FirstOrDefault(u => u.Name == model.University);
                    dm.University = um;
                    _context.DetachmentsModels.Add(dm);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные данные");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AddOtr()
        {
            ViewBag.Detachment = _context.DetachmentsModels.ToArray();
            ViewBag.Position = _context.PositionsModels.ToArray();
            return View();
        }
        [HttpPost]
        public IActionResult AddOtr(OtryadnikRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                    Otryadnik o = new Otryadnik { Name = model.Name, DateOfBirth = model.DateOfBirth, Surname = model.Surname };
                    PositionsModel p = _context.PositionsModels.FirstOrDefault(p => p.PositionName == model.Position);
                    o.Position = p;
                    DetachmentsModel dm = _context.DetachmentsModels.FirstOrDefault(u => u.Name == model.Detachment);
                    o.Detachment = dm;
                    _context.Otryadniks.Add(o);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}