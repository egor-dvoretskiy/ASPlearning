using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_site_1.Service
{
    public static class Extensions
    {
        public static string CutController(this string str)
        {
            return str.Replace("HomeController", string.Empty);
        }
    }
}
