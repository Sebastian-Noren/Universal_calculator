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
    class BMICalc
    {
        private double result = 0.0;
        private string[] BMIdef = new string[] { "Underweight", "Normal weight", "Overweight", "Obesity class 1", "Obesity class 2", "Obesity class 3", };
        private string weightCategory;

        public double GetResult()
        {
            return result;
        }

        public void SetResult(double value)
        {
            result = value;
        }

        public string GetWeightCategory()
        {
            return weightCategory;
        }

        public void SetWeightCategory(string value)
        {
            weightCategory = value;
        }

        public string ReadName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                return name = "noName";
            }
            else
            {
                return name;
            }
        }

        public void BMIFormula(string vHeight, string vWeight, RadioButton radioMetric)
        {
            double weight = 0.0, height = 0.0;
            if (string.IsNullOrEmpty(vHeight) || string.IsNullOrEmpty(vWeight))
            {
                MessageBox.Show("Must fill in both field.");
            }
            else
            {
                weight = ReadWeight(vWeight);
                height = ReadHeight(vHeight);
                if (weight > 0 && height > 0)
                {
                    if (radioMetric.Checked)
                    {
                        height = height / 100;
                        result = weight / (height * height);
                        SetResult(result);
                    }
                    else
                    {
                        height = height * 12;
                        result = (weight / (height * height)) * 703;
                        SetResult(result);
                    }
                    SetWeightClass();
                }
            }
        }

        public double ReadHeight(string strHeight)
        {
            double temp;
            if (!string.IsNullOrEmpty(strHeight))
            {
                if (double.TryParse(strHeight, out temp) && temp > 0.0)
                {

                    return temp;
                }
                else
                {
                    MessageBox.Show("Height must be a number above 0.");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Must fill in Height.");
                return 0;
            }
        }

        public double ReadWeight(string strWeight)
        {
            double temp;
            if (!string.IsNullOrEmpty(strWeight))
            {
                if (double.TryParse(strWeight, out temp) && temp > 0.0)
                {

                    return temp;
                }
                else
                {
                    MessageBox.Show("Weight must be a number above 0.");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Must fill in Weight.");
                return 0;
            }
        }

        private void SetWeightClass()
        {
            if (GetResult() < 18.5)
            {
                SetWeightCategory(BMIdef[0]);
            }
            else if (GetResult() > 18.5 && GetResult() < 24.9)
            {
                SetWeightCategory(BMIdef[1]);
            }
            else if (GetResult() > 25.0 && GetResult() < 29.9)
            {
                SetWeightCategory(BMIdef[2]);
            }
            else if (GetResult() > 30.0 && GetResult() < 34.9)
            {
                SetWeightCategory(BMIdef[3]);
            }
            else if (GetResult() > 35.0 && GetResult() < 39.9)
            {
                SetWeightCategory(BMIdef[4]);
            }
            else if (GetResult() > 40)
            {
                SetWeightCategory(BMIdef[5]);
            }

        }
    }
}
