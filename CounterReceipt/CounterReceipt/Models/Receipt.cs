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
            get 
            { 
                return _subtotal; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Värdet är mindre än 0!");
                }
                else
                {
                    _subtotal = value;
                }
            }
        }

        // Autoimplementerade egenskaper.
        public double DiscountRate { get; private set; }
        public double MoneyOff { get; private set; }
        public double Total { get; private set; }

        // Metoder för klassen.

        // Metod för att beräkna rabatt.
        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

            if(Subtotal <= 499)
            {
                Total = Subtotal * 1;
            }
            else if(Subtotal >= 500 && Subtotal <= 999)
            {
                Total = Subtotal * 0.95;
            }
            else if (Subtotal >= 1000 && Subtotal <= 4999)
            {
                Total = Subtotal * 0.90;
            }
            else if (Subtotal >= 5000)
            {
                Total = Subtotal * 0.85;
            }
        }

        // Överskuggar här ToString för att kunna kasta ut ett välformaterat resultat på beräkningen.
        public override string ToString()
        {
            return String.Format("Att betala: {0:c}", Total);
        }

        // Konstruktorer för klassen.
        public Receipt(double subtotal)
        {
            // Anropar Calculatemetoden för att beräkna rabatten.
            Calculate(subtotal);
        }
    }
}