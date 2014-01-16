using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CounterReceipt.Models
{
    public class Receipt
    {
        // Fält för klassen.
        private double _subtotal;

        // Egenskaper för klassen.
        public double Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public double DiscountRate { get; private set; }
        public double MoneyOff { get; private set; }
        public double Total { get; private set; }

        // Metoder för klassen.
        public void Calculate(double subtotal)
        {

        }

        // Konstruktorer för klassen.
        public Receipt(double subtotal)
        {

        }
    }
}