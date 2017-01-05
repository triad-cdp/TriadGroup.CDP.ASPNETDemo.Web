using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriadGroup.CDP.ASPNETDemo.Web.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Classification { get; set; }
        public int Year { get; set; }
        public IEnumerable<string> Cast { get; set; }
    }
}