using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * @author Sebastian Norén <s.norén@gmail.com>
 */

namespace Assignment3GVG
{

    class FuelCalculator
    {
        private double currentReading = 0.00, fuelAmount = 0.00, prevReading = 0.00, unitPrice = 0.00;
        private double km = 0.0, litPerKm = 0.0;


        public void ReadData(string strCurrOdd, string strPrevOdd, string strFuel, string strPrice)
        {
            double temp1, temp2, temp3, temp4;
            if (!string.IsNullOrEmpty(strCurrOdd) && !string.IsNullOrEmpty(strPrevOdd) &&
                !string.IsNullOrEmpty(strFuel) && !string.IsNullOrEmpty(strPrice))
            {
                bool ok1 = double.TryParse(strCurrOdd, out temp1);
                bool ok2 = double.TryParse(strPrevOdd, out temp2);
                bool ok3 = double.TryParse(strFuel, out temp3);
                bool ok4 = double.TryParse(strPrice, out temp4);
                if (ok1 && temp1 >= 0.0 && ok2 && temp2 >= 0.0 && ok3 && temp3 >= 0.0 && ok4 && temp4 > 0.0)
                {
                    SetCurrentReading(temp1);
                    SetPrevReading(temp2);
                    SetFuelAmount(temp3);
                    SetUnitPrice(temp4);
                    CalcBase();
                }
                else
                {
                    if (temp4 <= 0.0)
                    {
                        MessageBox.Show("Gas price can´t be free in this world.");
                    }
                    else
                    {
                        MessageBox.Show("Must be a number.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Must fill in all fields.");
            }
        }

        private void CalcBase()
        {
            km = GetCurrentReading() - GetPrevReading();
            litPerKm = GetFuelAmount() / km;
        }

        public double CalcKmPerLiter()
        {
            double kmPerLit = km / GetFuelAmount(); ;
            return kmPerLit;
        }

        public double CalcLitPerKm()
        {
            return litPerKm;
        }

        public double CalcLitPerMileFactor()
        {
            double kmToMileFactir = 0.621371192;
            double litPerMetricMile = litPerKm / kmToMileFactir;
            return litPerMetricMile;
        }

        public double CalcLiterPerSwedMil()
        {
            double literPerSwedMil = litPerKm * 10;
            return literPerSwedMil;
        }

        public double CalcCostPerKm()
        {
            double costPerkm = litPerKm * GetUnitPrice();
            return costPerkm;
        }

        public double GetCurrentReading()
        {
            return currentReading;
        }

        public void SetCurrentReading(double value)
        {
            currentReading = value;
        }

        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        public void SetFuelAmount(double value)
        {
            fuelAmount = value;
        }

        public double GetPrevReading()
        {
            return prevReading;
        }

        public void SetPrevReading(double value)
        {
            prevReading = value;
        }

        public double GetUnitPrice()
        {
            return unitPrice;
        }

        public void SetUnitPrice(double value)
        {
            unitPrice = value;
        }

    }
}
