using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Model;

namespace Wiki.Services.Interfaces
{
    internal interface ICheckService
    {
        public bool CkeckCountryExist(string Name);
    }
}
