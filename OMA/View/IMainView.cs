using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    interface IMainView : IView
    {
        event EventHandler<OrderedDishesEventArgs> OrderWasMade;
        event EventHandler Init;
        void LoadMenu(List<Dish> menu);
    }
}
