using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    public class Cook
    {
        public readonly Qualification Qualification_;

        public readonly Specialization Specialization_;

        public DateTime EndOfWorkTime { get; private set; }

        public List<Dish> Queue { get; private set; } = new List<Dish>();
        public Cook(Qualification qualification, Specialization spec)
        {
            Qualification_ = qualification;
            Specialization_ = spec;
            EndOfWorkTime = DateTime.Now;
        }

        private bool CanCookDish(Dish dish)
        {
            if (dish.Cuisine == this.Specialization_)
                return true;
            else
                return false;
        }

        public DateTime CookDish(Dish dish)
        {
            if (CanCookDish(dish))
            {
                double QualificationBonus = (int)((Qualification)Enum.Parse(typeof(Qualification), Qualification_.ToString())) / (double)100;
                TimeSpan CookingTimeWithBonus = dish.CookingTime - TimeSpan.FromTicks((long)(dish.CookingTime.Ticks * QualificationBonus));

                if (EndOfWorkTime < DateTime.Now)
                    EndOfWorkTime = DateTime.Now + CookingTimeWithBonus;
                else
                    EndOfWorkTime += CookingTimeWithBonus;
                dish.CookedAt = EndOfWorkTime;
                Queue.Add(dish);
                return EndOfWorkTime;
            }
            else
                throw new Exception("Cook doesn't have specialization for this dish");

        }
    }
}
