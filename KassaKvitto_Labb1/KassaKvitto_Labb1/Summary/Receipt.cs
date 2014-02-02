using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KassaKvitto_Labb1.Summary
{

    public class Receipt
    {
        // fält
        private double _subtotal;

        // egenskaper
        public double DiscountRate
        {
            get;
            private set;
        }

        public double MoneyOff
        {
            get;
            private set;
        }

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
                    throw new ArgumentException();
                }
                _subtotal = value;

            }
        }

        public double Total
        {
            get;
            private set;
        }

        //metoder
        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

            //Rabatt 0 %
            if (subtotal < 500)
            {
                DiscountRate = 0;
            }
            //Rabatt 5%
            else if (subtotal < 1000)
            {
                DiscountRate = 0.05;
            }
            //Rabatt 10%
            else if (subtotal < 5000)
            {
                DiscountRate = 0.10;
            }
            //Rabatt 15%
            else
            {
                DiscountRate = 0.15;
            }


            MoneyOff = Subtotal * DiscountRate;

            // TotalSumman med rabatt avdragen
            Total = subtotal - MoneyOff;


        }
        
        public Receipt(double subtotal)
        {
            
            Calculate(subtotal);

        }
    }
}