using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    interface IView
    {
        void Show();
        void ShowMessage(string message, MessageType type);
    }
}
