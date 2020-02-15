using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    interface IDataBase
    {
        List<Cook> GetCooks();
        List<Dish> GetMenu();
    }
}
