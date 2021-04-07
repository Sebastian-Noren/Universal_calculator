namespace Assignment3GVG
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMIbox = new System.Windows.Forms.GroupBox();
            this.radioUnit = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.calculateBMIbtn = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.labelWeigh = new System.Windows.Forms.Label();
            this.heighTextBox = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupboxBMI = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.resultWeightLabel = new System.Windows.Forms.Label();
            this.resultLabelBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currOdoReadTextfield = new System.Windows.Forms.TextBox();
            this.prevOdoReadTextfield = new System.Windows.Forms.TextBox();
            this.fuelTankTextfield = new System.Windows.Forms.TextBox();
            this.gasPriceTextfield = new System.Windows.Forms.TextBox();
            this.fuelBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCostKM = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelFuelLitToSWE = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelFuelLitMetric = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelFuelLitToKm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelFuelKMtoLit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.listBUnselectBtb = new System.Windows.Forms.Button();
            this.BmrBox = new System.Windows.Forms.ListBox();
            this.calcBmrBtn = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioExtraActive = new System.Windows.Forms.RadioButton();
            this.radioVeryActive = new System.Windows.Forms.RadioButton();
            this.radioModerately = new System.Windows.Forms.RadioButton();
            this.radioLight = new System.Windows.Forms.RadioButton();
            this.radioSedentary = new System.Windows.Forms.RadioButton();
            this.BMIbox.SuspendLayout();
            this.groupboxBMI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMIbox
            // 
            this.BMIbox.Controls.Add(this.radioUnit);
            this.BMIbox.Controls.Add(this.radioMetric);
            this.BMIbox.Controls.Add(this.calculateBMIbtn);
            this.BMIbox.Controls.Add(this.weightTextBox);
            this.BMIbox.Controls.Add(this.labelWeigh);
            this.BMIbox.Controls.Add(this.heighTextBox);
            this.BMIbox.Controls.Add(this.labelHeight);
            this.BMIbox.Controls.Add(this.label1);
            this.BMIbox.Controls.Add(this.nameTextBox);
            this.BMIbox.Controls.Add(this.groupboxBMI);
            this.BMIbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BMIbox.Location = new System.Drawing.Point(478, 14);
            this.BMIbox.Name = "BMIbox";
            this.BMIbox.Size = new System.Drawing.Size(556, 423);
            this.BMIbox.TabIndex = 0;
            this.BMIbox.TabStop = false;
            this.BMIbox.Text = "BMI";
            // 
            // radioUnit
            // 
            this.radioUnit.AutoSize = true;
            this.radioUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioUnit.Location = new System.Drawing.Point(370, 98);
            this.radioUnit.Name = "radioUnit";
            this.radioUnit.Size = new System.Drawing.Size(149, 24);
            this.radioUnit.TabIndex = 9;
            this.radioUnit.Text = "US unit (lb, feet)";
            this.radioUnit.UseVisualStyleBackColor = true;
            this.radioUnit.CheckedChanged += new System.EventHandler(this.radioUnit_CheckedChanged);
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Checked = true;
            this.radioMetric.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioMetric.Location = new System.Drawing.Point(370, 65);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(170, 24);
            this.radioMetric.TabIndex = 8;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric Unit (kg, cm)";
            this.radioMetric.UseVisualStyleBackColor = true;
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // calculateBMIbtn
            // 
            this.calculateBMIbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calculateBMIbtn.Location = new System.Drawing.Point(242, 158);
            this.calculateBMIbtn.Name = "calculateBMIbtn";
            this.calculateBMIbtn.Size = new System.Drawing.Size(148, 35);
            this.calculateBMIbtn.TabIndex = 7;
            this.calculateBMIbtn.Text = "Calculate";
            this.calculateBMIbtn.UseVisualStyleBackColor = true;
            this.calculateBMIbtn.Click += new System.EventHandler(this.calculateBMIbtn_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(165, 92);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weightTextBox.Size = new System.Drawing.Size(100, 26);
            this.weightTextBox.TabIndex = 6;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWeigh
            // 
            this.labelWeigh.AutoSize = true;
            this.labelWeigh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWeigh.Location = new System.Drawing.Point(28, 95);
            this.labelWeigh.Name = "labelWeigh";
            this.labelWeigh.Size = new System.Drawing.Size(90, 20);
            this.labelWeigh.TabIndex = 5;
            this.labelWeigh.Text = "Weight (kg)";
            // 
            // heighTextBox
            // 
            this.heighTextBox.Location = new System.Drawing.Point(165, 62);
            this.heighTextBox.Name = "heighTextBox";
            this.heighTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heighTextBox.Size = new System.Drawing.Size(100, 26);
            this.heighTextBox.TabIndex = 4;
            this.heighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelHeight.Location = new System.Drawing.Point(28, 65);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(91, 20);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(374, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // groupboxBMI
            // 
            this.groupboxBMI.Controls.Add(this.label22);
            this.groupboxBMI.Controls.Add(this.resultWeightLabel);
            this.groupboxBMI.Controls.Add(this.resultLabelBMI);
            this.groupboxBMI.Controls.Add(this.label5);
            this.groupboxBMI.Controls.Add(this.label4);
            this.groupboxBMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupboxBMI.Location = new System.Drawing.Point(18, 192);
            this.groupboxBMI.Name = "groupboxBMI";
            this.groupboxBMI.Size = new System.Drawing.Size(522, 225);
            this.groupboxBMI.TabIndex = 0;
            this.groupboxBMI.TabStop = false;
            this.groupboxBMI.Text = "Results for";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(195, 162);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(313, 22);
            this.label22.TabIndex = 4;
            this.label22.Text = "Normal BMI is between 18.5 and 24.9.";
            // 
            // resultWeightLabel
            // 
            this.resultWeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultWeightLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultWeightLabel.Location = new System.Drawing.Point(248, 80);
            this.resultWeightLabel.Name = "resultWeightLabel";
            this.resultWeightLabel.Padding = new System.Windows.Forms.Padding(2);
            this.resultWeightLabel.Size = new System.Drawing.Size(255, 26);
            this.resultWeightLabel.TabIndex = 3;
            this.resultWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultLabelBMI
            // 
            this.resultLabelBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabelBMI.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultLabelBMI.Location = new System.Drawing.Point(418, 45);
            this.resultLabelBMI.Name = "resultLabelBMI";
            this.resultLabelBMI.Padding = new System.Windows.Forms.Padding(2);
            this.resultLabelBMI.Size = new System.Drawing.Size(85, 26);
            this.resultLabelBMI.TabIndex = 2;
            this.resultLabelBMI.Text = "0.00";
            this.resultLabelBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your BMI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.currOdoReadTextfield);
            this.groupBox2.Controls.Add(this.prevOdoReadTextfield);
            this.groupBox2.Controls.Add(this.fuelTankTextfield);
            this.groupBox2.Controls.Add(this.gasPriceTextfield);
            this.groupBox2.Controls.Add(this.fuelBtn);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(24, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Price per liter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(24, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Current amount of fuel tanked (liters)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(24, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Previous odometer reading (km)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Current odometer reading (km)";
            // 
            // currOdoReadTextfield
            // 
            this.currOdoReadTextfield.Location = new System.Drawing.Point(285, 29);
            this.currOdoReadTextfield.Name = "currOdoReadTextfield";
            this.currOdoReadTextfield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currOdoReadTextfield.Size = new System.Drawing.Size(140, 26);
            this.currOdoReadTextfield.TabIndex = 12;
            this.currOdoReadTextfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prevOdoReadTextfield
            // 
            this.prevOdoReadTextfield.Location = new System.Drawing.Point(285, 62);
            this.prevOdoReadTextfield.Name = "prevOdoReadTextfield";
            this.prevOdoReadTextfield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prevOdoReadTextfield.Size = new System.Drawing.Size(140, 26);
            this.prevOdoReadTextfield.TabIndex = 11;
            this.prevOdoReadTextfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fuelTankTextfield
            // 
            this.fuelTankTextfield.Location = new System.Drawing.Point(326, 94);
            this.fuelTankTextfield.Name = "fuelTankTextfield";
            this.fuelTankTextfield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fuelTankTextfield.Size = new System.Drawing.Size(100, 26);
            this.fuelTankTextfield.TabIndex = 10;
            this.fuelTankTextfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gasPriceTextfield
            // 
            this.gasPriceTextfield.Location = new System.Drawing.Point(326, 126);
            this.gasPriceTextfield.Name = "gasPriceTextfield";
            this.gasPriceTextfield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gasPriceTextfield.Size = new System.Drawing.Size(100, 26);
            this.gasPriceTextfield.TabIndex = 9;
            this.gasPriceTextfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fuelBtn
            // 
            this.fuelBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.fuelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fuelBtn.Location = new System.Drawing.Point(128, 158);
            this.fuelBtn.Name = "fuelBtn";
            this.fuelBtn.Size = new System.Drawing.Size(148, 35);
            this.fuelBtn.TabIndex = 8;
            this.fuelBtn.Text = "Calculate";
            this.fuelBtn.UseVisualStyleBackColor = false;
            this.fuelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCostKM);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.labelFuelLitToSWE);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.labelFuelLitMetric);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.labelFuelLitToKm);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.labelFuelKMtoLit);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 225);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // labelCostKM
            // 
            this.labelCostKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCostKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostKM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCostKM.Location = new System.Drawing.Point(326, 175);
            this.labelCostKM.Name = "labelCostKM";
            this.labelCostKM.Padding = new System.Windows.Forms.Padding(2);
            this.labelCostKM.Size = new System.Drawing.Size(94, 26);
            this.labelCostKM.TabIndex = 23;
            this.labelCostKM.Text = "0.0";
            this.labelCostKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(18, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Cost per Kilometer";
            // 
            // labelFuelLitToSWE
            // 
            this.labelFuelLitToSWE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelLitToSWE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLitToSWE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFuelLitToSWE.Location = new System.Drawing.Point(326, 142);
            this.labelFuelLitToSWE.Name = "labelFuelLitToSWE";
            this.labelFuelLitToSWE.Padding = new System.Windows.Forms.Padding(2);
            this.labelFuelLitToSWE.Size = new System.Drawing.Size(94, 26);
            this.labelFuelLitToSWE.TabIndex = 21;
            this.labelFuelLitToSWE.Text = "0.0";
            this.labelFuelLitToSWE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(18, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Fuel consumption (lit/Swe mil)";
            // 
            // labelFuelLitMetric
            // 
            this.labelFuelLitMetric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelLitMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLitMetric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFuelLitMetric.Location = new System.Drawing.Point(326, 105);
            this.labelFuelLitMetric.Name = "labelFuelLitMetric";
            this.labelFuelLitMetric.Padding = new System.Windows.Forms.Padding(2);
            this.labelFuelLitMetric.Size = new System.Drawing.Size(94, 26);
            this.labelFuelLitMetric.TabIndex = 19;
            this.labelFuelLitMetric.Text = "0.0";
            this.labelFuelLitMetric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(18, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(239, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Fuel consumption (lit/metric mile)";
            // 
            // labelFuelLitToKm
            // 
            this.labelFuelLitToKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelLitToKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLitToKm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFuelLitToKm.Location = new System.Drawing.Point(326, 69);
            this.labelFuelLitToKm.Name = "labelFuelLitToKm";
            this.labelFuelLitToKm.Padding = new System.Windows.Forms.Padding(2);
            this.labelFuelLitToKm.Size = new System.Drawing.Size(94, 26);
            this.labelFuelLitToKm.TabIndex = 17;
            this.labelFuelLitToKm.Text = "0.0";
            this.labelFuelLitToKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(18, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Fuel consumption (lit/km)";
            // 
            // labelFuelKMtoLit
            // 
            this.labelFuelKMtoLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelKMtoLit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelKMtoLit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFuelKMtoLit.Location = new System.Drawing.Point(326, 34);
            this.labelFuelKMtoLit.Name = "labelFuelKMtoLit";
            this.labelFuelKMtoLit.Padding = new System.Windows.Forms.Padding(2);
            this.labelFuelKMtoLit.Size = new System.Drawing.Size(94, 26);
            this.labelFuelKMtoLit.TabIndex = 15;
            this.labelFuelKMtoLit.Text = "0.0";
            this.labelFuelKMtoLit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(18, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fuel Consumption (km/lit)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSelectedItem);
            this.groupBox4.Controls.Add(this.listBUnselectBtb);
            this.groupBox4.Controls.Add(this.BmrBox);
            this.groupBox4.Controls.Add(this.calcBmrBtn);
            this.groupBox4.Controls.Add(this.ageTextBox);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.radioMale);
            this.groupBox4.Controls.Add(this.radioFemale);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1022, 426);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BMR";
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSelectedItem.Location = new System.Drawing.Point(412, 375);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(152, 20);
            this.labelSelectedItem.TabIndex = 14;
            this.labelSelectedItem.Text = "Selected Item: none";
            // 
            // listBUnselectBtb
            // 
            this.listBUnselectBtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBUnselectBtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBUnselectBtb.Location = new System.Drawing.Point(902, 375);
            this.listBUnselectBtb.Name = "listBUnselectBtb";
            this.listBUnselectBtb.Size = new System.Drawing.Size(90, 31);
            this.listBUnselectBtb.TabIndex = 13;
            this.listBUnselectBtb.Text = "Unselect";
            this.listBUnselectBtb.UseVisualStyleBackColor = true;
            this.listBUnselectBtb.Click += new System.EventHandler(this.listBUnselectBtb_Click);
            // 
            // BmrBox
            // 
            this.BmrBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmrBox.FormattingEnabled = true;
            this.BmrBox.ItemHeight = 18;
            this.BmrBox.Location = new System.Drawing.Point(416, 26);
            this.BmrBox.Name = "BmrBox";
            this.BmrBox.Size = new System.Drawing.Size(601, 328);
            this.BmrBox.TabIndex = 12;
            this.BmrBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // calcBmrBtn
            // 
            this.calcBmrBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.calcBmrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcBmrBtn.Location = new System.Drawing.Point(128, 331);
            this.calcBmrBtn.Name = "calcBmrBtn";
            this.calcBmrBtn.Size = new System.Drawing.Size(148, 35);
            this.calcBmrBtn.TabIndex = 11;
            this.calcBmrBtn.Text = "Calculate";
            this.calcBmrBtn.UseVisualStyleBackColor = false;
            this.calcBmrBtn.Click += new System.EventHandler(this.calcBmrBtn_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(326, 60);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ageTextBox.Size = new System.Drawing.Size(62, 26);
            this.ageTextBox.TabIndex = 10;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 20);
            this.label23.TabIndex = 4;
            this.label23.Text = "Age";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(178, 25);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(68, 24);
            this.radioMale.TabIndex = 3;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Checked = true;
            this.radioFemale.Location = new System.Drawing.Point(28, 26);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(87, 24);
            this.radioFemale.TabIndex = 2;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioExtraActive);
            this.groupBox5.Controls.Add(this.radioVeryActive);
            this.groupBox5.Controls.Add(this.radioModerately);
            this.groupBox5.Controls.Add(this.radioLight);
            this.groupBox5.Controls.Add(this.radioSedentary);
            this.groupBox5.Location = new System.Drawing.Point(6, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 195);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Activity level per week";
            // 
            // radioExtraActive
            // 
            this.radioExtraActive.AutoSize = true;
            this.radioExtraActive.Location = new System.Drawing.Point(22, 162);
            this.radioExtraActive.Name = "radioExtraActive";
            this.radioExtraActive.Size = new System.Drawing.Size(273, 24);
            this.radioExtraActive.TabIndex = 7;
            this.radioExtraActive.Text = "Extra active, hard exercises or job.";
            this.radioExtraActive.UseVisualStyleBackColor = true;
            // 
            // radioVeryActive
            // 
            this.radioVeryActive.AutoSize = true;
            this.radioVeryActive.Location = new System.Drawing.Point(22, 131);
            this.radioVeryActive.Name = "radioVeryActive";
            this.radioVeryActive.Size = new System.Drawing.Size(211, 24);
            this.radioVeryActive.TabIndex = 6;
            this.radioVeryActive.Text = "Very active (6 to 7 times).";
            this.radioVeryActive.UseVisualStyleBackColor = true;
            // 
            // radioModerately
            // 
            this.radioModerately.AutoSize = true;
            this.radioModerately.Location = new System.Drawing.Point(22, 102);
            this.radioModerately.Name = "radioModerately";
            this.radioModerately.Size = new System.Drawing.Size(257, 24);
            this.radioModerately.TabIndex = 5;
            this.radioModerately.Text = "Moderately active (3 to 5 times).";
            this.radioModerately.UseVisualStyleBackColor = true;
            // 
            // radioLight
            // 
            this.radioLight.AutoSize = true;
            this.radioLight.Location = new System.Drawing.Point(22, 71);
            this.radioLight.Name = "radioLight";
            this.radioLight.Size = new System.Drawing.Size(220, 24);
            this.radioLight.TabIndex = 4;
            this.radioLight.Text = "Light activity (1 to 3 times).";
            this.radioLight.UseVisualStyleBackColor = true;
            // 
            // radioSedentary
            // 
            this.radioSedentary.AutoSize = true;
            this.radioSedentary.Checked = true;
            this.radioSedentary.Location = new System.Drawing.Point(22, 42);
            this.radioSedentary.Name = "radioSedentary";
            this.radioSedentary.Size = new System.Drawing.Size(255, 24);
            this.radioSedentary.TabIndex = 3;
            this.radioSedentary.TabStop = true;
            this.radioSedentary.Text = "Sedentary (little or no excercie).";
            this.radioSedentary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1042, 905);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BMIbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BMIbox.ResumeLayout(false);
            this.BMIbox.PerformLayout();
            this.groupboxBMI.ResumeLayout(false);
            this.groupboxBMI.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BMIbox;
        private System.Windows.Forms.GroupBox groupboxBMI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label labelWeigh;
        private System.Windows.Forms.TextBox heighTextBox;
        private System.Windows.Forms.RadioButton radioUnit;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.Button calculateBMIbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabelBMI;
        private System.Windows.Forms.Label resultWeightLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox currOdoReadTextfield;
        private System.Windows.Forms.TextBox prevOdoReadTextfield;
        private System.Windows.Forms.TextBox fuelTankTextfield;
        private System.Windows.Forms.TextBox gasPriceTextfield;
        private System.Windows.Forms.Button fuelBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCostKM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelFuelLitToSWE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelFuelLitMetric;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelFuelLitToKm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelFuelKMtoLit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton radioExtraActive;
        private System.Windows.Forms.RadioButton radioVeryActive;
        private System.Windows.Forms.RadioButton radioModerately;
        private System.Windows.Forms.RadioButton radioLight;
        private System.Windows.Forms.RadioButton radioSedentary;
        private System.Windows.Forms.Button listBUnselectBtb;
        private System.Windows.Forms.ListBox BmrBox;
        private System.Windows.Forms.Button calcBmrBtn;
        private System.Windows.Forms.Label labelSelectedItem;
    }
}

