using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMakingApp
{
    static class Program
    {
        public static ApplicationContext _context = new ApplicationContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new Container();

            container.Register<IMainView, MainForm>();
            container.Register<IPresenter, MainPresenter>();
            container.Register<IModel, Kitchen>();
            container.Register<IDataLayer, DataLayer>();
            container.Register<ISerialize, JsonSerializer>();
            container.Register<IDeserialize, JsonSerializer>();

            container.Create<IPresenter>().Run();
        }
    }
}
