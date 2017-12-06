using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Pharmacy.Models
{
    public class Auth
    {
        public Auth(bool isAuth)
        {
            this.isAuth = isAuth;
        }

        public bool isAuth { get; set; }

    }
}
