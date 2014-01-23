using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class Receipt
    {
        private double _subtotal;

        public double DiscountRate { get; private set; }

        public double MoneyOff { get; private set; }

        public double Subtotal
        {
            get
            {
                return _subtotal;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _subtotal = value;
                }
            }
        }

        public double Total { get; private set; }

        public Receipt(double subtotal)
        {
            Calculate(subtotal);
        }

        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

            if (Subtotal > 0 && Subtotal <= 499)
            {
                DiscountRate = 0;
                MoneyOff = 0;
                Total = Subtotal;
            }

            else if (Subtotal >= 500 && Subtotal <= 999)
            {
                DiscountRate = 0.05;
                MoneyOff = Subtotal * 0.05;
                Total = Subtotal - MoneyOff;
            }

            else if (Subtotal >= 1000 && Subtotal <= 4999)
            {
                DiscountRate = 0.10;
                MoneyOff = Subtotal * 0.10;
                Total = Subtotal - MoneyOff;
            }

            else if (Subtotal >= 5000)
            {
                DiscountRate = 0.15;
                MoneyOff = Subtotal * 0.15;
                Total = Subtotal - MoneyOff;
            }
        }
    }
}