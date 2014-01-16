using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CounterReceipt.Models;

namespace CounterReceipt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateDiscount_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Receipt counterReceipt = new Receipt(Double.Parse(totalCost.Text));
                Label1.Text = counterReceipt.ToString();
            }
            else
            {
                throw new ArgumentException("Fältet innehåller inte det förväntade värdet!");
            }
        }
    }
}