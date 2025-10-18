namespace _3_PizzaProject
{
    partial class frmPizza
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLargeSize = new System.Windows.Forms.RadioButton();
            this.rbMediumSize = new System.Windows.Forms.RadioButton();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbServiceType = new System.Windows.Forms.GroupBox();
            this.rbTakeOutServiceType = new System.Windows.Forms.RadioButton();
            this.rbEatInServiceType = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceOrderSummary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServiceTypeOrderSummary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCrustTypeOrderSummary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToppingsOrderSummary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSizeOrderSummary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppersTopping = new System.Windows.Forms.CheckBox();
            this.chkTomatoesTopping = new System.Windows.Forms.CheckBox();
            this.chkOlivesTopping = new System.Windows.Forms.CheckBox();
            this.chkMashroomsTopping = new System.Windows.Forms.CheckBox();
            this.chkOnionTopping = new System.Windows.Forms.CheckBox();
            this.chkExtraCheeseTopping = new System.Windows.Forms.CheckBox();
            this.gbPizzaSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbServiceType.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(290, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(599, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Make Your Pizza";
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.Controls.Add(this.rbLargeSize);
            this.gbPizzaSize.Controls.Add(this.rbMediumSize);
            this.gbPizzaSize.Controls.Add(this.rbSmallSize);
            this.gbPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.Location = new System.Drawing.Point(34, 158);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(230, 189);
            this.gbPizzaSize.TabIndex = 1;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbLargeSize
            // 
            this.rbLargeSize.AutoSize = true;
            this.rbLargeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLargeSize.Location = new System.Drawing.Point(32, 126);
            this.rbLargeSize.Name = "rbLargeSize";
            this.rbLargeSize.Size = new System.Drawing.Size(75, 24);
            this.rbLargeSize.TabIndex = 2;
            this.rbLargeSize.Tag = "20";
            this.rbLargeSize.Text = "Large";
            this.rbLargeSize.UseVisualStyleBackColor = true;
            this.rbLargeSize.CheckedChanged += new System.EventHandler(this.rbLargeSize_CheckedChanged);
            // 
            // rbMediumSize
            // 
            this.rbMediumSize.AutoSize = true;
            this.rbMediumSize.Checked = true;
            this.rbMediumSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumSize.Location = new System.Drawing.Point(32, 85);
            this.rbMediumSize.Name = "rbMediumSize";
            this.rbMediumSize.Size = new System.Drawing.Size(90, 24);
            this.rbMediumSize.TabIndex = 1;
            this.rbMediumSize.TabStop = true;
            this.rbMediumSize.Tag = "15";
            this.rbMediumSize.Text = "Medium";
            this.rbMediumSize.UseVisualStyleBackColor = true;
            this.rbMediumSize.CheckedChanged += new System.EventHandler(this.rbMediumSize_CheckedChanged);
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallSize.Location = new System.Drawing.Point(32, 45);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(73, 24);
            this.rbSmallSize.TabIndex = 0;
            this.rbSmallSize.Tag = "10";
            this.rbSmallSize.Text = "Small";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(34, 399);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(230, 141);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(32, 85);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(71, 24);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.Tag = "5";
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(32, 45);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(64, 24);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbServiceType
            // 
            this.gbServiceType.Controls.Add(this.rbTakeOutServiceType);
            this.gbServiceType.Controls.Add(this.rbEatInServiceType);
            this.gbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServiceType.Location = new System.Drawing.Point(361, 399);
            this.gbServiceType.Name = "gbServiceType";
            this.gbServiceType.Size = new System.Drawing.Size(294, 93);
            this.gbServiceType.TabIndex = 3;
            this.gbServiceType.TabStop = false;
            this.gbServiceType.Text = "Where To Eat";
            // 
            // rbTakeOutServiceType
            // 
            this.rbTakeOutServiceType.AutoSize = true;
            this.rbTakeOutServiceType.Checked = true;
            this.rbTakeOutServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOutServiceType.Location = new System.Drawing.Point(161, 45);
            this.rbTakeOutServiceType.Name = "rbTakeOutServiceType";
            this.rbTakeOutServiceType.Size = new System.Drawing.Size(99, 24);
            this.rbTakeOutServiceType.TabIndex = 1;
            this.rbTakeOutServiceType.TabStop = true;
            this.rbTakeOutServiceType.Text = "Take Out";
            this.rbTakeOutServiceType.UseVisualStyleBackColor = true;
            this.rbTakeOutServiceType.CheckedChanged += new System.EventHandler(this.rbTakeOutServiceType_CheckedChanged);
            // 
            // rbEatInServiceType
            // 
            this.rbEatInServiceType.AutoSize = true;
            this.rbEatInServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatInServiceType.Location = new System.Drawing.Point(32, 45);
            this.rbEatInServiceType.Name = "rbEatInServiceType";
            this.rbEatInServiceType.Size = new System.Drawing.Size(75, 24);
            this.rbEatInServiceType.TabIndex = 0;
            this.rbEatInServiceType.Text = "Eat in";
            this.rbEatInServiceType.UseVisualStyleBackColor = true;
            this.rbEatInServiceType.CheckedChanged += new System.EventHandler(this.rbEatInServiceType_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(361, 567);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(111, 65);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(500, 567);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(111, 65);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(200)))));
            this.gbOrderSummary.Controls.Add(this.lblTotalPriceOrderSummary);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.lblServiceTypeOrderSummary);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lblCrustTypeOrderSummary);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblToppingsOrderSummary);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.lblSizeOrderSummary);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(746, 128);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(381, 519);
            this.gbOrderSummary.TabIndex = 3;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPriceOrderSummary
            // 
            this.lblTotalPriceOrderSummary.AutoSize = true;
            this.lblTotalPriceOrderSummary.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceOrderSummary.Location = new System.Drawing.Point(79, 411);
            this.lblTotalPriceOrderSummary.Name = "lblTotalPriceOrderSummary";
            this.lblTotalPriceOrderSummary.Size = new System.Drawing.Size(96, 84);
            this.lblTotalPriceOrderSummary.TabIndex = 22;
            this.lblTotalPriceOrderSummary.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total Price :";
            // 
            // lblServiceTypeOrderSummary
            // 
            this.lblServiceTypeOrderSummary.AutoSize = true;
            this.lblServiceTypeOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTypeOrderSummary.Location = new System.Drawing.Point(187, 298);
            this.lblServiceTypeOrderSummary.Name = "lblServiceTypeOrderSummary";
            this.lblServiceTypeOrderSummary.Size = new System.Drawing.Size(0, 25);
            this.lblServiceTypeOrderSummary.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Service Type :";
            // 
            // lblCrustTypeOrderSummary
            // 
            this.lblCrustTypeOrderSummary.AutoSize = true;
            this.lblCrustTypeOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeOrderSummary.Location = new System.Drawing.Point(166, 245);
            this.lblCrustTypeOrderSummary.Name = "lblCrustTypeOrderSummary";
            this.lblCrustTypeOrderSummary.Size = new System.Drawing.Size(0, 25);
            this.lblCrustTypeOrderSummary.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Crust Type :";
            // 
            // lblToppingsOrderSummary
            // 
            this.lblToppingsOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsOrderSummary.Location = new System.Drawing.Point(17, 154);
            this.lblToppingsOrderSummary.Name = "lblToppingsOrderSummary";
            this.lblToppingsOrderSummary.Size = new System.Drawing.Size(358, 64);
            this.lblToppingsOrderSummary.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Toppings :\r\n";
            // 
            // lblSizeOrderSummary
            // 
            this.lblSizeOrderSummary.AutoSize = true;
            this.lblSizeOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeOrderSummary.Location = new System.Drawing.Point(108, 59);
            this.lblSizeOrderSummary.Name = "lblSizeOrderSummary";
            this.lblSizeOrderSummary.Size = new System.Drawing.Size(0, 25);
            this.lblSizeOrderSummary.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Size : ";
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppersTopping);
            this.gbToppings.Controls.Add(this.chkTomatoesTopping);
            this.gbToppings.Controls.Add(this.chkOlivesTopping);
            this.gbToppings.Controls.Add(this.chkMashroomsTopping);
            this.gbToppings.Controls.Add(this.chkOnionTopping);
            this.gbToppings.Controls.Add(this.chkExtraCheeseTopping);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(325, 158);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(395, 189);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppersTopping
            // 
            this.chkGreenPeppersTopping.AutoSize = true;
            this.chkGreenPeppersTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppersTopping.Location = new System.Drawing.Point(200, 126);
            this.chkGreenPeppersTopping.Name = "chkGreenPeppersTopping";
            this.chkGreenPeppersTopping.Size = new System.Drawing.Size(143, 24);
            this.chkGreenPeppersTopping.TabIndex = 11;
            this.chkGreenPeppersTopping.Tag = "2";
            this.chkGreenPeppersTopping.Text = "Green Peppers";
            this.chkGreenPeppersTopping.UseVisualStyleBackColor = true;
            this.chkGreenPeppersTopping.CheckedChanged += new System.EventHandler(this.chkGreenPeppersTopping_CheckedChanged);
            // 
            // chkTomatoesTopping
            // 
            this.chkTomatoesTopping.AutoSize = true;
            this.chkTomatoesTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoesTopping.Location = new System.Drawing.Point(32, 126);
            this.chkTomatoesTopping.Name = "chkTomatoesTopping";
            this.chkTomatoesTopping.Size = new System.Drawing.Size(106, 24);
            this.chkTomatoesTopping.TabIndex = 8;
            this.chkTomatoesTopping.Tag = "2";
            this.chkTomatoesTopping.Text = "Tomatoes";
            this.chkTomatoesTopping.UseVisualStyleBackColor = true;
            this.chkTomatoesTopping.CheckedChanged += new System.EventHandler(this.chkTomatoesTopping_CheckedChanged);
            // 
            // chkOlivesTopping
            // 
            this.chkOlivesTopping.AutoSize = true;
            this.chkOlivesTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlivesTopping.Location = new System.Drawing.Point(200, 85);
            this.chkOlivesTopping.Name = "chkOlivesTopping";
            this.chkOlivesTopping.Size = new System.Drawing.Size(77, 24);
            this.chkOlivesTopping.TabIndex = 10;
            this.chkOlivesTopping.Tag = "2";
            this.chkOlivesTopping.Text = "Olives";
            this.chkOlivesTopping.UseVisualStyleBackColor = true;
            this.chkOlivesTopping.CheckedChanged += new System.EventHandler(this.chkOlivesTopping_CheckedChanged);
            // 
            // chkMashroomsTopping
            // 
            this.chkMashroomsTopping.AutoSize = true;
            this.chkMashroomsTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMashroomsTopping.Location = new System.Drawing.Point(32, 85);
            this.chkMashroomsTopping.Name = "chkMashroomsTopping";
            this.chkMashroomsTopping.Size = new System.Drawing.Size(118, 24);
            this.chkMashroomsTopping.TabIndex = 7;
            this.chkMashroomsTopping.Tag = "2";
            this.chkMashroomsTopping.Text = "Mashrooms";
            this.chkMashroomsTopping.UseVisualStyleBackColor = true;
            this.chkMashroomsTopping.CheckedChanged += new System.EventHandler(this.chkMashroomsTopping_CheckedChanged);
            // 
            // chkOnionTopping
            // 
            this.chkOnionTopping.AutoSize = true;
            this.chkOnionTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnionTopping.Location = new System.Drawing.Point(200, 44);
            this.chkOnionTopping.Name = "chkOnionTopping";
            this.chkOnionTopping.Size = new System.Drawing.Size(77, 24);
            this.chkOnionTopping.TabIndex = 9;
            this.chkOnionTopping.Tag = "2";
            this.chkOnionTopping.Text = "Onion";
            this.chkOnionTopping.UseVisualStyleBackColor = true;
            this.chkOnionTopping.CheckedChanged += new System.EventHandler(this.chkOnionTopping_CheckedChanged);
            // 
            // chkExtraCheeseTopping
            // 
            this.chkExtraCheeseTopping.AutoSize = true;
            this.chkExtraCheeseTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheeseTopping.Location = new System.Drawing.Point(32, 44);
            this.chkExtraCheeseTopping.Name = "chkExtraCheeseTopping";
            this.chkExtraCheeseTopping.Size = new System.Drawing.Size(131, 24);
            this.chkExtraCheeseTopping.TabIndex = 6;
            this.chkExtraCheeseTopping.Tag = "2";
            this.chkExtraCheeseTopping.Text = "Extra Cheese";
            this.chkExtraCheeseTopping.UseVisualStyleBackColor = true;
            this.chkExtraCheeseTopping.CheckedChanged += new System.EventHandler(this.chkExtraCheeseTopping_CheckedChanged);
            // 
            // frmPizza
            // 
            this.AcceptButton = this.btnOrderPizza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 694);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbServiceType);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPizza";
            this.Text = "Order Pizza";
            this.Load += new System.EventHandler(this.frmPizza_Load);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbServiceType.ResumeLayout(false);
            this.gbServiceType.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbLargeSize;
        private System.Windows.Forms.RadioButton rbMediumSize;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbServiceType;
        private System.Windows.Forms.RadioButton rbTakeOutServiceType;
        private System.Windows.Forms.RadioButton rbEatInServiceType;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblSizeOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToppingsOrderSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCrustTypeOrderSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPriceOrderSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblServiceTypeOrderSummary;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppersTopping;
        private System.Windows.Forms.CheckBox chkTomatoesTopping;
        private System.Windows.Forms.CheckBox chkOlivesTopping;
        private System.Windows.Forms.CheckBox chkMashroomsTopping;
        private System.Windows.Forms.CheckBox chkOnionTopping;
        private System.Windows.Forms.CheckBox chkExtraCheeseTopping;
    }
}

