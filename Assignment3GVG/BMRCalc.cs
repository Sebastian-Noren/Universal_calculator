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
    class BMRCalc
    {
        private double BMR;
        private double factor;
        double maintainWeightCalories;
        private double[] factorValue = new double[] { 1.2, 1.375, 1.550, 1.725, 1.9 };
        private BMICalc bmiFormula = new BMICalc();

        public void diffineBMR(RadioButton radioFemale, string strAge, string strHeight, string strWeight)
        {
            double weight = bmiFormula.ReadWeight(strWeight);
            double height = bmiFormula.ReadHeight(strHeight);
            int age = ReadAge(strAge);

            if (age > 0 && weight > 0 && height > 0)
            {
                BMR = (10 * weight) + (6.25 * height) - (5 * age);

                if (radioFemale.Checked)
                {
                    BMR -= 161;
                }
                else
                {
                    BMR += 5;
                }
            }
        }

        private int ReadAge(string strAge)
        {
            int temp;
            if (!string.IsNullOrEmpty(strAge))
            {
                if (int.TryParse(strAge, out temp) && temp > 0)
                {
                    return temp;
                }
                else
                {
                    MessageBox.Show("Age must be a number.");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Must fill in Age.");
                return 0;
            }
        }


        public double CalcBMR()
        {
            return BMR;
        }

        public double CalcKeepCurrentWeight()
        {
            maintainWeightCalories = BMR * GetFactor();
            return maintainWeightCalories;
        }

        public double CalcLose500()
        {
            return maintainWeightCalories - 500;
        }

        public double CalcLose1000()
        {
            return maintainWeightCalories - 1000;
        }

        public double CalcGain500()
        {
            return maintainWeightCalories + 500;
        }

        public double CalcGain1000()
        {
            return maintainWeightCalories + 1000;
        }

        public void SetFactorClass(RadioButton radioSedentary, RadioButton radioLight,
            RadioButton radioMod, RadioButton radioVery, RadioButton radioExtra)
        {
            if (radioSedentary.Checked)
            {
                SetFactor(factorValue[0]);
            }
            else if (radioLight.Checked)
            {
                SetFactor(factorValue[1]);
            }
            else if (radioMod.Checked)
            {
                SetFactor(factorValue[2]);
            }
            else if (radioVery.Checked)
            {
                SetFactor(factorValue[3]);
            }
            else if (radioExtra.Checked)
            {
                SetFactor(factorValue[4]);
            }

        }

        private double GetFactor()
        {
            return factor;
        }

        private void SetFactor(double value)
        {
            factor = value;
        }

    }

}
