﻿
namespace Marys_Auto
{
    partial class mainUserInputForm
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.customerInfoBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.streetAdressBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trimBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.makeBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.issueBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.estimatedPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.actualPriceBox = new System.Windows.Forms.TextBox();
            this.customerInfoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(103, 21);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(81, 20);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // customerInfoBox
            // 
            this.customerInfoBox.Controls.Add(this.phoneNumberBox);
            this.customerInfoBox.Controls.Add(this.label11);
            this.customerInfoBox.Controls.Add(this.stateBox);
            this.customerInfoBox.Controls.Add(this.lastNameBox);
            this.customerInfoBox.Controls.Add(this.label3);
            this.customerInfoBox.Controls.Add(this.streetAdressBox);
            this.customerInfoBox.Controls.Add(this.firstNameBox);
            this.customerInfoBox.Controls.Add(this.label1);
            this.customerInfoBox.Controls.Add(this.cityBox);
            this.customerInfoBox.Controls.Add(this.label2);
            this.customerInfoBox.Controls.Add(this.label4);
            this.customerInfoBox.Controls.Add(this.label5);
            this.customerInfoBox.Location = new System.Drawing.Point(9, 10);
            this.customerInfoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerInfoBox.Name = "customerInfoBox";
            this.customerInfoBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerInfoBox.Size = new System.Drawing.Size(192, 176);
            this.customerInfoBox.TabIndex = 0;
            this.customerInfoBox.TabStop = false;
            this.customerInfoBox.Text = "Customer Info";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(103, 67);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(81, 20);
            this.phoneNumberBox.TabIndex = 3;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phone Number";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(103, 138);
            this.stateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(81, 20);
            this.stateBox.TabIndex = 6;
            this.stateBox.TextChanged += new System.EventHandler(this.stateBox_TextChanged);
            // 
            // streetAdressBox
            // 
            this.streetAdressBox.Location = new System.Drawing.Point(103, 91);
            this.streetAdressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.streetAdressBox.Name = "streetAdressBox";
            this.streetAdressBox.Size = new System.Drawing.Size(81, 20);
            this.streetAdressBox.TabIndex = 4;
            this.streetAdressBox.TextChanged += new System.EventHandler(this.streetAdressBox_TextChanged);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(103, 44);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(81, 20);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Street Adress";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(103, 114);
            this.cityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(81, 20);
            this.cityBox.TabIndex = 5;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "City";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trimBox);
            this.groupBox1.Controls.Add(this.yearBox);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.makeBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.vinBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(223, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(192, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Info";
            // 
            // trimBox
            // 
            this.trimBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimBox.FormattingEnabled = true;
            this.trimBox.Items.AddRange(new object[] {
            "Trim 1 Example",
            "Trim 2 Example",
            "Trim 3 Example",
            "Trim 4 Example",
            "Trim 5 Example",
            "Etc edit later"});
            this.trimBox.Location = new System.Drawing.Point(65, 72);
            this.trimBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trimBox.Name = "trimBox";
            this.trimBox.Size = new System.Drawing.Size(119, 21);
            this.trimBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.yearBox.Location = new System.Drawing.Point(65, 124);
            this.yearBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(119, 21);
            this.yearBox.TabIndex = 19;
            // 
            // modelBox
            // 
            this.modelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "Model 1 Example",
            "Model 2 Example",
            "Model 3 Example",
            "Model 4 Example",
            "Model 5 Example",
            "Etc edit later"});
            this.modelBox.Location = new System.Drawing.Point(65, 46);
            this.modelBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(119, 21);
            this.modelBox.TabIndex = 18;
            // 
            // makeBox
            // 
            this.makeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeBox.FormattingEnabled = true;
            this.makeBox.Items.AddRange(new object[] {
            "Make 1 Example",
            "Make 2 Example",
            "Make 3 Example",
            "Make 4 Example",
            "Make 5 Example",
            "Etc edit later"});
            this.makeBox.Location = new System.Drawing.Point(65, 17);
            this.makeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(119, 21);
            this.makeBox.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 124);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Year";
            // 
            // vinBox
            // 
            this.vinBox.Location = new System.Drawing.Point(65, 96);
            this.vinBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vinBox.Name = "vinBox";
            this.vinBox.Size = new System.Drawing.Size(119, 20);
            this.vinBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "VIN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Make";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Trim";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 203);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Issue";
            // 
            // issueBox
            // 
            this.issueBox.Location = new System.Drawing.Point(87, 203);
            this.issueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issueBox.Name = "issueBox";
            this.issueBox.Size = new System.Drawing.Size(300, 20);
            this.issueBox.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(158, 340);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 19);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(223, 340);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(56, 19);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(134, 261);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Estimated Price";
            // 
            // estimatedPriceBox
            // 
            this.estimatedPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estimatedPriceBox.Location = new System.Drawing.Point(225, 261);
            this.estimatedPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.estimatedPriceBox.Name = "estimatedPriceBox";
            this.estimatedPriceBox.Size = new System.Drawing.Size(64, 20);
            this.estimatedPriceBox.TabIndex = 13;
            this.estimatedPriceBox.Text = "$0.00";
            this.estimatedPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Actual Price";
            // 
            // actualPriceBox
            // 
            this.actualPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actualPriceBox.Location = new System.Drawing.Point(225, 286);
            this.actualPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actualPriceBox.Name = "actualPriceBox";
            this.actualPriceBox.Size = new System.Drawing.Size(64, 20);
            this.actualPriceBox.TabIndex = 14;
            this.actualPriceBox.Text = "$0.00";
            this.actualPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainUserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 369);
            this.Controls.Add(this.actualPriceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estimatedPriceBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.issueBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerInfoBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainUserInputForm";
            this.Text = "Mary\'s Auto";
            this.customerInfoBox.ResumeLayout(false);
            this.customerInfoBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.GroupBox customerInfoBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox streetAdressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox issueBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox estimatedPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox actualPriceBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox makeBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox trimBox;
    }
}

