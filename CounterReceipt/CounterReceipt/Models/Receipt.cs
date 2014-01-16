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
                DiscountRate = 0.0;
                MoneyOff = Subtotal * DiscountRate;
                Total = Subtotal - MoneyOff;
            }
            else if(Subtotal >= 500 && Subtotal <= 999)
            {
                DiscountRate = 0.05;
                MoneyOff = Subtotal * DiscountRate;
                Total = Subtotal - MoneyOff;
            }
            else if (Subtotal >= 1000 && Subtotal <= 4999)
            {
                DiscountRate = 0.10;
                MoneyOff = Subtotal * DiscountRate;
                Total = Subtotal - MoneyOff;
            }
            else if (Subtotal >= 5000)
            {
                DiscountRate = 0.15;
                MoneyOff = Subtotal * DiscountRate;
                Total = Subtotal - MoneyOff;
            }
        }

        // Överskuggar här ToString för att kunna kasta ut ett välformaterat resultat på beräkningen.
        public override string ToString()
        {
            return String.Format("Totalt: {0:c}\n\nRabattsats: {1} %\nRabatt: {2:c} Att betala: {3:c}", Subtotal, DiscountRate * 100, MoneyOff, Total);
        }

        // Konstruktorer för klassen.
        public Receipt(double subtotal)
        {
            // Anropar Calculatemetoden för att beräkna rabatten.
            Calculate(subtotal);
        }
    }
}