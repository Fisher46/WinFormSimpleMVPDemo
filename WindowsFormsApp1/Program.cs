using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new Repository.CustomerRepository(Application.StartupPath);

            var view = new View.Customerform();

            var presenter = new Presenter.CustomerPresenter(view,repository);

            Application.Run(view);
        }
    }
}
