using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Presenter;

namespace WindowsFormsApp1.View
{
    public interface ICustomerView
    {

        IList<string> CustomerList { get; set; }
        int SelectedCustomer { get; set; }
        string Address { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        CustomerPresenter customerPresenter { get; set; }

    }
}
