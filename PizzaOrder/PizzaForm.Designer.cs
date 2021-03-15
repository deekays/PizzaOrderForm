namespace PizzaOrder
{
    partial class PizzaForm
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
            this.pnlPizzaNumber = new System.Windows.Forms.Panel();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.txtPizzaNumber = new System.Windows.Forms.TextBox();
            this.lblPizzas = new System.Windows.Forms.Label();
            this.pnlPizzas = new System.Windows.Forms.Panel();
            this.pnlToppings = new System.Windows.Forms.Panel();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.rdbCheeseHeavy = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNormal = new System.Windows.Forms.RadioButton();
            this.rdbCheeseLight = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNone = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkOlivesGreen = new System.Windows.Forms.CheckBox();
            this.chkOlivesBlack = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grbSauce = new System.Windows.Forms.GroupBox();
            this.rdbSauceHeavy = new System.Windows.Forms.RadioButton();
            this.rdbSauceNormal = new System.Windows.Forms.RadioButton();
            this.rdbSauceLight = new System.Windows.Forms.RadioButton();
            this.rdbSauceNone = new System.Windows.Forms.RadioButton();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblOrderHeader = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlPizzaNumber.SuspendLayout();
            this.pnlToppings.SuspendLayout();
            this.grbCheese.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbSauce.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPizzaNumber
            // 
            this.pnlPizzaNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzaNumber.Controls.Add(this.btnStartOrder);
            this.pnlPizzaNumber.Controls.Add(this.txtPizzaNumber);
            this.pnlPizzaNumber.Controls.Add(this.lblPizzas);
            this.pnlPizzaNumber.Location = new System.Drawing.Point(12, 12);
            this.pnlPizzaNumber.Name = "pnlPizzaNumber";
            this.pnlPizzaNumber.Size = new System.Drawing.Size(219, 88);
            this.pnlPizzaNumber.TabIndex = 0;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Location = new System.Drawing.Point(80, 47);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(75, 23);
            this.btnStartOrder.TabIndex = 2;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // txtPizzaNumber
            // 
            this.txtPizzaNumber.Location = new System.Drawing.Point(128, 21);
            this.txtPizzaNumber.MaxLength = 1;
            this.txtPizzaNumber.Name = "txtPizzaNumber";
            this.txtPizzaNumber.Size = new System.Drawing.Size(27, 20);
            this.txtPizzaNumber.TabIndex = 1;
            // 
            // lblPizzas
            // 
            this.lblPizzas.AutoSize = true;
            this.lblPizzas.Location = new System.Drawing.Point(18, 24);
            this.lblPizzas.Name = "lblPizzas";
            this.lblPizzas.Size = new System.Drawing.Size(95, 13);
            this.lblPizzas.TabIndex = 0;
            this.lblPizzas.Text = "How many pizzas?";
            // 
            // pnlPizzas
            // 
            this.pnlPizzas.AutoScroll = true;
            this.pnlPizzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzas.Location = new System.Drawing.Point(12, 106);
            this.pnlPizzas.Name = "pnlPizzas";
            this.pnlPizzas.Size = new System.Drawing.Size(219, 503);
            this.pnlPizzas.TabIndex = 1;
            // 
            // pnlToppings
            // 
            this.pnlToppings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToppings.Controls.Add(this.lblSpecialInstructions);
            this.pnlToppings.Controls.Add(this.txtSpecialInstructions);
            this.pnlToppings.Controls.Add(this.btnCheckOut);
            this.pnlToppings.Controls.Add(this.grbCheese);
            this.pnlToppings.Controls.Add(this.grbToppings);
            this.pnlToppings.Controls.Add(this.grbSauce);
            this.pnlToppings.Enabled = false;
            this.pnlToppings.Location = new System.Drawing.Point(237, 12);
            this.pnlToppings.Name = "pnlToppings";
            this.pnlToppings.Size = new System.Drawing.Size(378, 597);
            this.pnlToppings.TabIndex = 2;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Location = new System.Drawing.Point(29, 367);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(102, 13);
            this.lblSpecialInstructions.TabIndex = 4;
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Location = new System.Drawing.Point(23, 383);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(318, 119);
            this.txtSpecialInstructions.TabIndex = 3;
            this.txtSpecialInstructions.TextChanged += new System.EventHandler(this.txtSpecialInstructions_TextChanged);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(22, 528);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(319, 41);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // grbCheese
            // 
            this.grbCheese.Controls.Add(this.rdbCheeseHeavy);
            this.grbCheese.Controls.Add(this.rdbCheeseNormal);
            this.grbCheese.Controls.Add(this.rdbCheeseLight);
            this.grbCheese.Controls.Add(this.rdbCheeseNone);
            this.grbCheese.Location = new System.Drawing.Point(22, 273);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Size = new System.Drawing.Size(318, 76);
            this.grbCheese.TabIndex = 1;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Cheese";
            // 
            // rdbCheeseHeavy
            // 
            this.rdbCheeseHeavy.AutoSize = true;
            this.rdbCheeseHeavy.Location = new System.Drawing.Point(237, 35);
            this.rdbCheeseHeavy.Name = "rdbCheeseHeavy";
            this.rdbCheeseHeavy.Size = new System.Drawing.Size(56, 17);
            this.rdbCheeseHeavy.TabIndex = 3;
            this.rdbCheeseHeavy.TabStop = true;
            this.rdbCheeseHeavy.Text = "Heavy";
            this.rdbCheeseHeavy.UseVisualStyleBackColor = true;
            this.rdbCheeseHeavy.Click += new System.EventHandler(this.Cheese_Click);
            // 
            // rdbCheeseNormal
            // 
            this.rdbCheeseNormal.AutoSize = true;
            this.rdbCheeseNormal.Location = new System.Drawing.Point(155, 35);
            this.rdbCheeseNormal.Name = "rdbCheeseNormal";
            this.rdbCheeseNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbCheeseNormal.TabIndex = 2;
            this.rdbCheeseNormal.TabStop = true;
            this.rdbCheeseNormal.Text = "Normal";
            this.rdbCheeseNormal.UseVisualStyleBackColor = true;
            this.rdbCheeseNormal.Click += new System.EventHandler(this.Cheese_Click);
            // 
            // rdbCheeseLight
            // 
            this.rdbCheeseLight.AutoSize = true;
            this.rdbCheeseLight.Location = new System.Drawing.Point(87, 35);
            this.rdbCheeseLight.Name = "rdbCheeseLight";
            this.rdbCheeseLight.Size = new System.Drawing.Size(48, 17);
            this.rdbCheeseLight.TabIndex = 1;
            this.rdbCheeseLight.TabStop = true;
            this.rdbCheeseLight.Text = "Light";
            this.rdbCheeseLight.UseVisualStyleBackColor = true;
            this.rdbCheeseLight.Click += new System.EventHandler(this.Cheese_Click);
            // 
            // rdbCheeseNone
            // 
            this.rdbCheeseNone.AutoSize = true;
            this.rdbCheeseNone.Location = new System.Drawing.Point(21, 35);
            this.rdbCheeseNone.Name = "rdbCheeseNone";
            this.rdbCheeseNone.Size = new System.Drawing.Size(51, 17);
            this.rdbCheeseNone.TabIndex = 0;
            this.rdbCheeseNone.TabStop = true;
            this.rdbCheeseNone.Text = "None";
            this.rdbCheeseNone.UseVisualStyleBackColor = true;
            this.rdbCheeseNone.Click += new System.EventHandler(this.Cheese_Click);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkOlivesGreen);
            this.grbToppings.Controls.Add(this.chkOlivesBlack);
            this.grbToppings.Controls.Add(this.chkSpinach);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkTomato);
            this.grbToppings.Controls.Add(this.chkPineapple);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkHam);
            this.grbToppings.Controls.Add(this.chkBacon);
            this.grbToppings.Controls.Add(this.chkPepperoni);
            this.grbToppings.Location = new System.Drawing.Point(22, 116);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(318, 137);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkOlivesGreen
            // 
            this.chkOlivesGreen.AutoSize = true;
            this.chkOlivesGreen.Location = new System.Drawing.Point(124, 100);
            this.chkOlivesGreen.Name = "chkOlivesGreen";
            this.chkOlivesGreen.Size = new System.Drawing.Size(90, 17);
            this.chkOlivesGreen.TabIndex = 9;
            this.chkOlivesGreen.Tag = "10";
            this.chkOlivesGreen.Text = "Olives, Green";
            this.chkOlivesGreen.UseVisualStyleBackColor = true;
            this.chkOlivesGreen.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkOlivesBlack
            // 
            this.chkOlivesBlack.AutoSize = true;
            this.chkOlivesBlack.Location = new System.Drawing.Point(21, 100);
            this.chkOlivesBlack.Name = "chkOlivesBlack";
            this.chkOlivesBlack.Size = new System.Drawing.Size(88, 17);
            this.chkOlivesBlack.TabIndex = 3;
            this.chkOlivesBlack.Tag = "9";
            this.chkOlivesBlack.Text = "Olives, Black";
            this.chkOlivesBlack.UseVisualStyleBackColor = true;
            this.chkOlivesBlack.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(229, 77);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(65, 17);
            this.chkSpinach.TabIndex = 8;
            this.chkSpinach.Tag = "8";
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(124, 77);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Tag = "7";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(21, 77);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 6;
            this.chkGreenPeppers.Tag = "6";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(229, 54);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(62, 17);
            this.chkTomato.TabIndex = 5;
            this.chkTomato.Tag = "5";
            this.chkTomato.Text = "Tomato";
            this.chkTomato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(124, 54);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 4;
            this.chkPineapple.Tag = "4";
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(21, 54);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 3;
            this.chkMushrooms.Tag = "3";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(229, 31);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(48, 17);
            this.chkHam.TabIndex = 2;
            this.chkHam.Tag = "2";
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(124, 31);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Tag = "1";
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(21, 31);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Tag = "0";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // grbSauce
            // 
            this.grbSauce.Controls.Add(this.rdbSauceHeavy);
            this.grbSauce.Controls.Add(this.rdbSauceNormal);
            this.grbSauce.Controls.Add(this.rdbSauceLight);
            this.grbSauce.Controls.Add(this.rdbSauceNone);
            this.grbSauce.Location = new System.Drawing.Point(22, 24);
            this.grbSauce.Name = "grbSauce";
            this.grbSauce.Size = new System.Drawing.Size(318, 74);
            this.grbSauce.TabIndex = 0;
            this.grbSauce.TabStop = false;
            this.grbSauce.Text = "Sauce";
            // 
            // rdbSauceHeavy
            // 
            this.rdbSauceHeavy.AutoSize = true;
            this.rdbSauceHeavy.Location = new System.Drawing.Point(237, 29);
            this.rdbSauceHeavy.Name = "rdbSauceHeavy";
            this.rdbSauceHeavy.Size = new System.Drawing.Size(56, 17);
            this.rdbSauceHeavy.TabIndex = 7;
            this.rdbSauceHeavy.TabStop = true;
            this.rdbSauceHeavy.Tag = "3";
            this.rdbSauceHeavy.Text = "Heavy";
            this.rdbSauceHeavy.UseVisualStyleBackColor = true;
            this.rdbSauceHeavy.Click += new System.EventHandler(this.Sauce_Click);
            // 
            // rdbSauceNormal
            // 
            this.rdbSauceNormal.AutoSize = true;
            this.rdbSauceNormal.Location = new System.Drawing.Point(155, 29);
            this.rdbSauceNormal.Name = "rdbSauceNormal";
            this.rdbSauceNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbSauceNormal.TabIndex = 6;
            this.rdbSauceNormal.TabStop = true;
            this.rdbSauceNormal.Tag = "2";
            this.rdbSauceNormal.Text = "Normal";
            this.rdbSauceNormal.UseVisualStyleBackColor = true;
            this.rdbSauceNormal.Click += new System.EventHandler(this.Sauce_Click);
            // 
            // rdbSauceLight
            // 
            this.rdbSauceLight.AutoSize = true;
            this.rdbSauceLight.Location = new System.Drawing.Point(87, 29);
            this.rdbSauceLight.Name = "rdbSauceLight";
            this.rdbSauceLight.Size = new System.Drawing.Size(48, 17);
            this.rdbSauceLight.TabIndex = 5;
            this.rdbSauceLight.TabStop = true;
            this.rdbSauceLight.Tag = "1";
            this.rdbSauceLight.Text = "Light";
            this.rdbSauceLight.UseVisualStyleBackColor = true;
            this.rdbSauceLight.Click += new System.EventHandler(this.Sauce_Click);
            // 
            // rdbSauceNone
            // 
            this.rdbSauceNone.AutoSize = true;
            this.rdbSauceNone.Location = new System.Drawing.Point(21, 29);
            this.rdbSauceNone.Name = "rdbSauceNone";
            this.rdbSauceNone.Size = new System.Drawing.Size(51, 17);
            this.rdbSauceNone.TabIndex = 4;
            this.rdbSauceNone.TabStop = true;
            this.rdbSauceNone.Tag = "0";
            this.rdbSauceNone.Text = "None";
            this.rdbSauceNone.UseVisualStyleBackColor = true;
            this.rdbSauceNone.Click += new System.EventHandler(this.Sauce_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.Location = new System.Drawing.Point(622, 106);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(345, 409);
            this.lblOrderSummary.TabIndex = 3;
            // 
            // lblOrderHeader
            // 
            this.lblOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHeader.Location = new System.Drawing.Point(622, 12);
            this.lblOrderHeader.Name = "lblOrderHeader";
            this.lblOrderHeader.Size = new System.Drawing.Size(345, 71);
            this.lblOrderHeader.TabIndex = 4;
            this.lblOrderHeader.Text = "Order Summary:";
            this.lblOrderHeader.Visible = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewOrder.Location = new System.Drawing.Point(628, 541);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(339, 41);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "Start New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Visible = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 621);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblOrderHeader);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.pnlToppings);
            this.Controls.Add(this.pnlPizzas);
            this.Controls.Add(this.pnlPizzaNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.pnlPizzaNumber.ResumeLayout(false);
            this.pnlPizzaNumber.PerformLayout();
            this.pnlToppings.ResumeLayout(false);
            this.pnlToppings.PerformLayout();
            this.grbCheese.ResumeLayout(false);
            this.grbCheese.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbSauce.ResumeLayout(false);
            this.grbSauce.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPizzaNumber;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.TextBox txtPizzaNumber;
        private System.Windows.Forms.Label lblPizzas;
        private System.Windows.Forms.Panel pnlPizzas;
        private System.Windows.Forms.Panel pnlToppings;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.GroupBox grbSauce;
        private System.Windows.Forms.RadioButton rdbCheeseHeavy;
        private System.Windows.Forms.RadioButton rdbCheeseNormal;
        private System.Windows.Forms.RadioButton rdbCheeseLight;
        private System.Windows.Forms.RadioButton rdbCheeseNone;
        private System.Windows.Forms.CheckBox chkOlivesGreen;
        private System.Windows.Forms.CheckBox chkOlivesBlack;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.RadioButton rdbSauceHeavy;
        private System.Windows.Forms.RadioButton rdbSauceNormal;
        private System.Windows.Forms.RadioButton rdbSauceLight;
        private System.Windows.Forms.RadioButton rdbSauceNone;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblOrderHeader;
        private System.Windows.Forms.Button btnNewOrder;
    }
}

