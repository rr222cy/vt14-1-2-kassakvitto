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
                // Om alla fält validerar så anropas min metod för att beräkna rabatt, sedan formateras strängar och skrivs ut i rätt labelkontroll.
                Receipt counterReceipt = new Receipt(Double.Parse(totalCost.Text));
                labelSubtotal.Text = String.Format("{0:c}", counterReceipt.Subtotal);
                labelDiscountRate.Text = String.Format("{0} %", counterReceipt.DiscountRate*100);
                labelMoneyOff.Text = String.Format("{0:c}", counterReceipt.MoneyOff);
                labelTotal.Text = String.Format("{0:c}", counterReceipt.Total);
            }
            else
            {
                throw new ArgumentException("Fältet innehåller inte det förväntade värdet!");
            }
        }
    }
}