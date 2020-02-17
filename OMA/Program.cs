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
            var presenter = new MainPresenter(new MainForm(), new Kitchen(new DataBase()));
            presenter.Run();
            //Application.Run(new MainForm());
        }
    }
}
