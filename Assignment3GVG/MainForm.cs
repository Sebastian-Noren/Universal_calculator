using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 */
namespace Assignment3GVG
{
    public partial class MainForm : Form
    {
        private BMICalc bMICalc;
        private FuelCalculator fuelCalculator;
        private BMRCalc bmrCalc;
        public MainForm()
        {
            InitializeComponent();
            //My code from here
            InitializeGUI();
        }
        //My own
        private void InitializeGUI()
        {
            this.Text = "Universal calculator";
            bMICalc = new BMICalc();
            fuelCalculator = new FuelCalculator();
            bmrCalc = new BMRCalc();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currOdo = currOdoReadTextfield.Text.Trim().ToString();
            string prevOdo = prevOdoReadTextfield.Text.Trim().ToString();
            string fuelAmount = fuelTankTextfield.Text.Trim().ToString();
            string gasPrice = gasPriceTextfield.Text.Trim().ToString();

            fuelCalculator.ReadData(currOdo, prevOdo, fuelAmount, gasPrice);

            if (!string.IsNullOrEmpty(currOdo) && !string.IsNullOrEmpty(prevOdo) &&
          !string.IsNullOrEmpty(fuelAmount) && !string.IsNullOrEmpty(gasPrice))
            {
                labelFuelKMtoLit.Text = fuelCalculator.CalcKmPerLiter().ToString("0.00");
                labelFuelLitToKm.Text = fuelCalculator.CalcLitPerKm().ToString("0.00");
                labelFuelLitMetric.Text = fuelCalculator.CalcLitPerMileFactor().ToString("0.00");
                labelFuelLitToSWE.Text = fuelCalculator.CalcLiterPerSwedMil().ToString("0.00");
                labelCostKM.Text = fuelCalculator.CalcCostPerKm().ToString("0.00");
            }
        }

        private void calculateBMIbtn_Click(object sender, EventArgs e)
        {
           bMICalc.BMIFormula(heighTextBox.Text.Trim().ToString(), weightTextBox.Text.Trim().ToString(),radioMetric);
            groupboxBMI.Text ="Results for " + bMICalc.ReadName(nameTextBox.Text.Trim().ToString());
            resultLabelBMI.Text = bMICalc.GetResult().ToString("0.00");
            resultWeightLabel.Text = bMICalc.GetWeightCategory();

        }

        private void radioUnit_CheckedChanged(object sender, EventArgs e)
        {
            labelHeight.Text = "Height(feet)";
            labelWeigh.Text = "Weight (lb)";
            ClearBMI();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelHeight.Text = "Height(cm)";
            labelWeigh.Text = "Weight (kg)";
            ClearBMI();
        }

        private void ClearBMI()
        {
            resultWeightLabel.Text = "";
            resultLabelBMI.Text = "0.00";
            bMICalc.SetResult(0.00);
            bMICalc.SetWeightCategory("");
            heighTextBox.Clear();
            weightTextBox.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BmrBox.SelectedIndex > -1)
            {
                labelSelectedItem.Text = "Selected: " + (BmrBox.SelectedIndex+1);
            }
        }

        private void listBUnselectBtb_Click(object sender, EventArgs e)
        {
            BmrBox.SelectedItems.Clear();
            labelSelectedItem.Text = "Selected item: ";
        }

        private void calcBmrBtn_Click(object sender, EventArgs e)
        {
            BmrBox.Items.Clear();
            string ageField = ageTextBox.Text.Trim().ToString();
            string heightField = heighTextBox.Text.Trim().ToString();
            string weightFIeld = weightTextBox.Text.Trim().ToString();
            bmrCalc.diffineBMR(radioFemale, ageField, heightField,weightFIeld);
            bmrCalc.SetFactorClass(radioSedentary, radioLight, radioModerately, radioVeryActive, radioExtraActive);

            if (!string.IsNullOrEmpty(ageField) && !string.IsNullOrEmpty(heightField) && !string.IsNullOrEmpty(weightFIeld))
            {
                displayBMR();
            }
        }

        private void displayBMR()
        {
            string format = "{0,-45}{1,6:f1}";
            BmrBox.Items.Add("BMR RESULTS for " + bMICalc.ReadName(nameTextBox.Text.Trim().ToString()));
            BmrBox.Items.Add("");
            BmrBox.Items.Add(string.Format(format, "Your BMR calories/day", bmrCalc.CalcBMR()));
            BmrBox.Items.Add(string.Format(format, "Calories to maintain your weight", bmrCalc.CalcKeepCurrentWeight()));
            BmrBox.Items.Add(string.Format(format, "Calories to lose 0,5 kg per week", bmrCalc.CalcLose500()));
            BmrBox.Items.Add(string.Format(format, "Calories to lose 1 kg per week", bmrCalc.CalcLose1000()));
            BmrBox.Items.Add(string.Format(format, "Calories to gain 0,5 kg per week", bmrCalc.CalcGain500()));
            BmrBox.Items.Add(string.Format(format, "Calories to gain 1 kg per week", bmrCalc.CalcGain1000()));
            BmrBox.Items.Add("");
            BmrBox.Items.Add("Losing more than 1000 calories per day is to be avoided");
        }
    }
}
