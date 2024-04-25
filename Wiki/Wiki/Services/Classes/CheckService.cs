using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wiki.Model;
using Wiki.Services.Interfaces;
using Wiki.Context;

namespace Wiki.Services.Classes
{
    internal class CheckService : ICheckService
    {
        public bool CkeckCountryExist(string Name)
        {
            WikiDbContext context = new();
            var check = context.Country.Where(x => x.Name == Name).Select(x => x.Name);
            foreach (var item in check)
            {
                if (item == Name)
                {
                    MessageBox.Show($"{item} category already exist");
                    return false;
                }
            }

            return true;
        }
    }
}
