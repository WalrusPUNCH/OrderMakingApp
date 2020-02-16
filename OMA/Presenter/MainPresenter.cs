using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    class MainPresenter : IPresenter
    {
        IMainView view;
        IModel model;
        public MainPresenter(IMainView _view, IModel _model)
        {
            view = _view;
            model = _model;

            view.Init += View_Init;
            view.OrderWasMade += view_OrderWasMade;
            model.OrderConfirmed += Model_OrderConfirmed;
        }

        private string FormResponse(Order order)
        {
            string response = String.Format("Ваше замовлення буде готове о {0}\n", order.ServingTime.ToShortTimeString());
            foreach (Dish dish in order.OrderedDishes)
                response += String.Format("Страва {0} буде готова о {1} \n", dish.Name, dish.CookedAt.ToShortTimeString());
            return response;
        }
        private void Model_OrderConfirmed(object sender, OrderEventArgs e)
        {
            if (e.ConfirmedOrder.ServingTime == DateTime.MinValue)
                view.ShowMessage("Не можливо виконати замовлення", MessageType.Error);
            else
            {
                string response = FormResponse(e.ConfirmedOrder);
                view.ShowMessage(response, MessageType.Information);
            }
        }

        private void View_Init(object sender, EventArgs e)
        {
            view.LoadMenu(model.GetMenu());
        }

        private void view_OrderWasMade(object sender, OrderedDishesEventArgs e)
        {
            model.ConfirmOrder(e.OrderedDishesName);
        }

        public void Run()
        {
            view.Show();
        }
    }
}
