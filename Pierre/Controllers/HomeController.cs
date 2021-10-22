using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace Pierre.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierreContext _db;
      public HomeController(PierreContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        dynamic model = new ExpandoObject();
        model.Flavors = _db.Flavors.ToList();
        model.Treats = _db.Treats.ToList();
        return View(model);
      }

    }
}