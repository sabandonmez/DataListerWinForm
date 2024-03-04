using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Windows.Forms;

namespace DataListerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
                var customerOrderDetails = customerManager.CustomerOrderDetail();
                dataLister.DataSource = customerOrderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataLister.DataSource = null;
        }
    }
}
