using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;

namespace WindowsFormsApp1.View
{
    public partial class Customerform : Form
    {
        public Customerform()
        {
            InitializeComponent();
        }

        public IList<string> CustomerList
        {
            get { return (IList<string>)this.listBox1.DataSource; }
            set { this.listBox1.DataSource = value; }
        }


        public string Address
        {
            get { return addressTextBox.Text; }
            set { addressTextBox.Text = value; }
        }
        public string FullName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }
        public string Email
        {
            get { return emailTextBox.Text; }
            set { emailTextBox.Text = value; }
        }

        public CustomerPresenter customerPresenter { get; set; }

    }
}
