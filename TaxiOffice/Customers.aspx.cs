using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaxiOffice
{
    public partial class Customers : System.Web.UI.Page
    {
        DataLayer.Classes.Data db = new DataLayer.Classes.Data();

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomersGridView.DataBind();
        }

        private void ResetTextboxes()
        {
            tbCustomerName.Text = string.Empty;
            tbPaymentMethod.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbZip.Text = string.Empty;
            tbCity.Text = string.Empty;
            tbDefaultPickupAddress.Text = string.Empty; 
        }

        protected void CustomersGridView_DataBinding(object sender, EventArgs e)
        {
            CustomersGridView.DataSource = db.SelectAllCustomers();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            db.InsertCustomer(tbCustomerName.Text, tbPaymentMethod.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text, tbZip.Text, tbCity.Text, tbDefaultPickupAddress.Text);

            CustomersGridView.DataBind();

            ResetTextboxes();
        }
    }
}