using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TriadGroup.CDP.ASPNETDemo.Web.Models;
using TriadGroup.CDP.ASPNETDemo.Web.Repositories;

namespace TriadGroup.CDP.ASPNETDemo.Web.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmsRepository Repository = new FilmsRepository();

        // GET: Film
        public ActionResult Index()
        {
            IEnumerable<Film> films = this.Repository.GetFilms();
            return View(films);
        }
    }
}