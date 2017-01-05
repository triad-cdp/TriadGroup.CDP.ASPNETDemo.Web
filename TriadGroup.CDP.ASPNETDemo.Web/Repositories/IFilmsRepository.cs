using System.Collections.Generic;
using TriadGroup.CDP.ASPNETDemo.Web.Models;

namespace TriadGroup.CDP.ASPNETDemo.Web.Repositories
{
    public interface IFilmsRepository
    {
        IEnumerable<Film> GetFilms();
    }
}