using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    public class Kitchen
    {
        private readonly IDataBase @base;
        List<Cook> Cooks = new List<Cook>();
        public readonly List<Dish> Menu = new List<Dish>();
        public Kitchen()
        {
            @base = new DataBase(); // як правильно?????????????????????????????????????????????????????????????????????????????????????????7
            Cooks = @base.GetCooks();
            Menu = @base.GetMenu();
        }

        public Order ConfirmOrder(List<string> DishNamesToCook)
        {
            List<Dish> DishesToCook = ConvertNamesToRealDishes(DishNamesToCook);

            DateTime ServingTime = DateTime.Now;
            foreach (Dish dish in DishesToCook)
            {
                List<Cook> AvaliableCooks = Cooks.Where(cook => cook.Specialization_ == dish.Cuisine).ToList();
                AvaliableCooks = AvaliableCooks.OrderBy(cook => cook.EndOfWorkTime).ThenByDescending(cook => (int)((Qualification)Enum.Parse(typeof(Qualification), cook.Qualification_.ToString()))).ToList();
                try
                {
                    DateTime DishReadyTime = AvaliableCooks.First().CookDish(dish);
                    if (DishReadyTime > ServingTime)
                        ServingTime = DishReadyTime;
                }
                catch (NullReferenceException)
                {
                    return new Order(DishesToCook, DateTime.MinValue);
                }
            }
            return new Order(DishesToCook, ServingTime);
        }

        private List<Dish> ConvertNamesToRealDishes(List<string> DishNames)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (string dishName in DishNames)
                dishes.Add(Menu.Where(dish => dish.Name == dishName).First());
            return dishes;
        }
    }
}
