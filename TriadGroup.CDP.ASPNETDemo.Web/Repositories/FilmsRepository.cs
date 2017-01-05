using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TriadGroup.CDP.ASPNETDemo.Web.Models;

namespace TriadGroup.CDP.ASPNETDemo.Web.Repositories
{
    public class FilmsRepository : IFilmsRepository
    {
        public IEnumerable<Film> GetFilms()
        {
            List<Film> result = new List<Film>();
            result.Add(new Film { Id = 1, Title = "Star Wars: Rogue One", Classification = "12A", Cast = new string[] { "Felicity Jones", "Diego Luna", "Forest Whitaker" }, Year = 2016 });
            result.Add(new Film { Id = 2, Title = "Fantastic Beasts and Where to Find Them", Classification = "12A", Cast = new string[] { "Eddie Redmayne", "Samantha Morton", "Colin Farrell" }, Year = 2016 });

            return result;
        }
    }
}