namespace DrinkMachine
{
    partial class drinkMachineScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ctnDrinks = new System.Windows.Forms.GroupBox();
            this.btnGrapeJuice = new System.Windows.Forms.Button();
            this.btnOrangeJuice = new System.Windows.Forms.Button();
            this.btnGuarana = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.ctnSize = new System.Windows.Forms.GroupBox();
            this.btnSize700ml = new System.Windows.Forms.Button();
            this.btnSize500ml = new System.Windows.Forms.Button();
            this.btnSize300ml = new System.Windows.Forms.Button();
            this.ctnAdditional = new System.Windows.Forms.GroupBox();
            this.btnNoIce = new System.Windows.Forms.Button();
            this.btnIce = new System.Windows.Forms.Button();
            this.ctnPlaceToEat = new System.Windows.Forms.GroupBox();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.ctnOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblCupLidSelected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIceQuantitySelected = new System.Windows.Forms.Label();
            this.lblCupTypeSelected = new System.Windows.Forms.Label();
            this.lblSizeSelected = new System.Windows.Forms.Label();
            this.lblDrinkSelected = new System.Windows.Forms.Label();
            this.lblPlaceToEatSelected = new System.Windows.Forms.Label();
            this.lblIceQuantity = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblPlaceToEat = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.ctnDrinks.SuspendLayout();
            this.ctnSize.SuspendLayout();
            this.ctnAdditional.SuspendLayout();
            this.ctnPlaceToEat.SuspendLayout();
            this.ctnOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(14, 16);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(86, 48);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(106, 16);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 48);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ctnDrinks
            // 
            this.ctnDrinks.Controls.Add(this.btnGrapeJuice);
            this.ctnDrinks.Controls.Add(this.btnOrangeJuice);
            this.ctnDrinks.Controls.Add(this.btnGuarana);
            this.ctnDrinks.Controls.Add(this.btnCoke);
            this.ctnDrinks.Enabled = false;
            this.ctnDrinks.Location = new System.Drawing.Point(14, 215);
            this.ctnDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnDrinks.Name = "ctnDrinks";
            this.ctnDrinks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnDrinks.Size = new System.Drawing.Size(497, 140);
            this.ctnDrinks.TabIndex = 2;
            this.ctnDrinks.TabStop = false;
            this.ctnDrinks.Text = "Select Drink";
            // 
            // btnGrapeJuice
            // 
            this.btnGrapeJuice.Location = new System.Drawing.Point(371, 32);
            this.btnGrapeJuice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrapeJuice.Name = "btnGrapeJuice";
            this.btnGrapeJuice.Size = new System.Drawing.Size(89, 85);
            this.btnGrapeJuice.TabIndex = 0;
            this.btnGrapeJuice.Text = "Grape Juice";
            this.btnGrapeJuice.UseVisualStyleBackColor = true;
            this.btnGrapeJuice.Click += new System.EventHandler(this.selectDrink_Click);
            // 
            // btnOrangeJuice
            // 
            this.btnOrangeJuice.Location = new System.Drawing.Point(265, 32);
            this.btnOrangeJuice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrangeJuice.Name = "btnOrangeJuice";
            this.btnOrangeJuice.Size = new System.Drawing.Size(89, 85);
            this.btnOrangeJuice.TabIndex = 0;
            this.btnOrangeJuice.Text = "Orange Juice";
            this.btnOrangeJuice.UseVisualStyleBackColor = true;
            this.btnOrangeJuice.Click += new System.EventHandler(this.selectDrink_Click);
            // 
            // btnGuarana
            // 
            this.btnGuarana.Location = new System.Drawing.Point(154, 32);
            this.btnGuarana.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuarana.Name = "btnGuarana";
            this.btnGuarana.Size = new System.Drawing.Size(89, 85);
            this.btnGuarana.TabIndex = 0;
            this.btnGuarana.Text = "Guarana";
            this.btnGuarana.UseVisualStyleBackColor = true;
            this.btnGuarana.Click += new System.EventHandler(this.selectDrink_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.Location = new System.Drawing.Point(46, 32);
            this.btnCoke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(89, 85);
            this.btnCoke.TabIndex = 0;
            this.btnCoke.Text = "Coke";
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.selectDrink_Click);
            // 
            // ctnSize
            // 
            this.ctnSize.Controls.Add(this.btnSize700ml);
            this.ctnSize.Controls.Add(this.btnSize500ml);
            this.ctnSize.Controls.Add(this.btnSize300ml);
            this.ctnSize.Enabled = false;
            this.ctnSize.Location = new System.Drawing.Point(14, 384);
            this.ctnSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnSize.Name = "ctnSize";
            this.ctnSize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnSize.Size = new System.Drawing.Size(497, 119);
            this.ctnSize.TabIndex = 2;
            this.ctnSize.TabStop = false;
            this.ctnSize.Text = "Select Size";
            // 
            // btnSize700ml
            // 
            this.btnSize700ml.Location = new System.Drawing.Point(319, 24);
            this.btnSize700ml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSize700ml.Name = "btnSize700ml";
            this.btnSize700ml.Size = new System.Drawing.Size(86, 81);
            this.btnSize700ml.TabIndex = 0;
            this.btnSize700ml.Text = "700ml";
            this.btnSize700ml.UseVisualStyleBackColor = true;
            this.btnSize700ml.Click += new System.EventHandler(this.selectSize_Click);
            // 
            // btnSize500ml
            // 
            this.btnSize500ml.Location = new System.Drawing.Point(202, 24);
            this.btnSize500ml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSize500ml.Name = "btnSize500ml";
            this.btnSize500ml.Size = new System.Drawing.Size(86, 81);
            this.btnSize500ml.TabIndex = 0;
            this.btnSize500ml.Text = "500ml";
            this.btnSize500ml.UseVisualStyleBackColor = true;
            this.btnSize500ml.Click += new System.EventHandler(this.selectSize_Click);
            // 
            // btnSize300ml
            // 
            this.btnSize300ml.Location = new System.Drawing.Point(88, 24);
            this.btnSize300ml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSize300ml.Name = "btnSize300ml";
            this.btnSize300ml.Size = new System.Drawing.Size(86, 81);
            this.btnSize300ml.TabIndex = 0;
            this.btnSize300ml.Text = "300ml";
            this.btnSize300ml.UseVisualStyleBackColor = true;
            this.btnSize300ml.Click += new System.EventHandler(this.selectSize_Click);
            // 
            // ctnAdditional
            // 
            this.ctnAdditional.Controls.Add(this.btnNoIce);
            this.ctnAdditional.Controls.Add(this.btnIce);
            this.ctnAdditional.Enabled = false;
            this.ctnAdditional.Location = new System.Drawing.Point(14, 531);
            this.ctnAdditional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnAdditional.Name = "ctnAdditional";
            this.ctnAdditional.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnAdditional.Size = new System.Drawing.Size(497, 111);
            this.ctnAdditional.TabIndex = 2;
            this.ctnAdditional.TabStop = false;
            this.ctnAdditional.Text = "Select Additional";
            // 
            // btnNoIce
            // 
            this.btnNoIce.Location = new System.Drawing.Point(247, 25);
            this.btnNoIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNoIce.Name = "btnNoIce";
            this.btnNoIce.Size = new System.Drawing.Size(86, 73);
            this.btnNoIce.TabIndex = 0;
            this.btnNoIce.Text = "No Ice";
            this.btnNoIce.UseVisualStyleBackColor = true;
            this.btnNoIce.Click += new System.EventHandler(this.selectIceQuantity_Click);
            // 
            // btnIce
            // 
            this.btnIce.Location = new System.Drawing.Point(136, 25);
            this.btnIce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(86, 73);
            this.btnIce.TabIndex = 0;
            this.btnIce.Text = "Ice";
            this.btnIce.UseVisualStyleBackColor = true;
            this.btnIce.Click += new System.EventHandler(this.selectIceQuantity_Click);
            // 
            // ctnPlaceToEat
            // 
            this.ctnPlaceToEat.Controls.Add(this.btnTakeOut);
            this.ctnPlaceToEat.Controls.Add(this.btnEatIn);
            this.ctnPlaceToEat.Enabled = false;
            this.ctnPlaceToEat.Location = new System.Drawing.Point(14, 95);
            this.ctnPlaceToEat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnPlaceToEat.Name = "ctnPlaceToEat";
            this.ctnPlaceToEat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnPlaceToEat.Size = new System.Drawing.Size(497, 99);
            this.ctnPlaceToEat.TabIndex = 2;
            this.ctnPlaceToEat.TabStop = false;
            this.ctnPlaceToEat.Text = "Select Place to Eat";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Location = new System.Drawing.Point(247, 23);
            this.btnTakeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(86, 61);
            this.btnTakeOut.TabIndex = 0;
            this.btnTakeOut.Text = "Take Out";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.Click += new System.EventHandler(this.selectPlaceToEat_Click);
            // 
            // btnEatIn
            // 
            this.btnEatIn.Location = new System.Drawing.Point(136, 23);
            this.btnEatIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(86, 61);
            this.btnEatIn.TabIndex = 0;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.Click += new System.EventHandler(this.selectPlaceToEat_Click);
            // 
            // ctnOrderSummary
            // 
            this.ctnOrderSummary.Controls.Add(this.lblCupLidSelected);
            this.ctnOrderSummary.Controls.Add(this.label2);
            this.ctnOrderSummary.Controls.Add(this.lblIceQuantitySelected);
            this.ctnOrderSummary.Controls.Add(this.lblCupTypeSelected);
            this.ctnOrderSummary.Controls.Add(this.lblSizeSelected);
            this.ctnOrderSummary.Controls.Add(this.lblDrinkSelected);
            this.ctnOrderSummary.Controls.Add(this.lblPlaceToEatSelected);
            this.ctnOrderSummary.Controls.Add(this.lblIceQuantity);
            this.ctnOrderSummary.Controls.Add(this.lblSize);
            this.ctnOrderSummary.Controls.Add(this.label1);
            this.ctnOrderSummary.Controls.Add(this.lblDrink);
            this.ctnOrderSummary.Controls.Add(this.lblPlaceToEat);
            this.ctnOrderSummary.Location = new System.Drawing.Point(541, 96);
            this.ctnOrderSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnOrderSummary.Name = "ctnOrderSummary";
            this.ctnOrderSummary.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctnOrderSummary.Size = new System.Drawing.Size(245, 196);
            this.ctnOrderSummary.TabIndex = 2;
            this.ctnOrderSummary.TabStop = false;
            this.ctnOrderSummary.Text = "Order Summary";
            // 
            // lblCupLidSelected
            // 
            this.lblCupLidSelected.AutoSize = true;
            this.lblCupLidSelected.Location = new System.Drawing.Point(147, 55);
            this.lblCupLidSelected.Name = "lblCupLidSelected";
            this.lblCupLidSelected.Size = new System.Drawing.Size(45, 20);
            this.lblCupLidSelected.TabIndex = 11;
            this.lblCupLidSelected.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cup lid: ";
            // 
            // lblIceQuantitySelected
            // 
            this.lblIceQuantitySelected.AutoSize = true;
            this.lblIceQuantitySelected.Location = new System.Drawing.Point(147, 153);
            this.lblIceQuantitySelected.Name = "lblIceQuantitySelected";
            this.lblIceQuantitySelected.Size = new System.Drawing.Size(45, 20);
            this.lblIceQuantitySelected.TabIndex = 9;
            this.lblIceQuantitySelected.Text = "None";
            // 
            // lblCupTypeSelected
            // 
            this.lblCupTypeSelected.AutoSize = true;
            this.lblCupTypeSelected.Location = new System.Drawing.Point(147, 103);
            this.lblCupTypeSelected.Name = "lblCupTypeSelected";
            this.lblCupTypeSelected.Size = new System.Drawing.Size(45, 20);
            this.lblCupTypeSelected.TabIndex = 8;
            this.lblCupTypeSelected.Text = "None";
            // 
            // lblSizeSelected
            // 
            this.lblSizeSelected.AutoSize = true;
            this.lblSizeSelected.Location = new System.Drawing.Point(147, 129);
            this.lblSizeSelected.Name = "lblSizeSelected";
            this.lblSizeSelected.Size = new System.Drawing.Size(45, 20);
            this.lblSizeSelected.TabIndex = 7;
            this.lblSizeSelected.Text = "None";
            // 
            // lblDrinkSelected
            // 
            this.lblDrinkSelected.AutoSize = true;
            this.lblDrinkSelected.Location = new System.Drawing.Point(147, 79);
            this.lblDrinkSelected.Name = "lblDrinkSelected";
            this.lblDrinkSelected.Size = new System.Drawing.Size(45, 20);
            this.lblDrinkSelected.TabIndex = 6;
            this.lblDrinkSelected.Text = "None";
            // 
            // lblPlaceToEatSelected
            // 
            this.lblPlaceToEatSelected.AutoSize = true;
            this.lblPlaceToEatSelected.Location = new System.Drawing.Point(147, 31);
            this.lblPlaceToEatSelected.Name = "lblPlaceToEatSelected";
            this.lblPlaceToEatSelected.Size = new System.Drawing.Size(45, 20);
            this.lblPlaceToEatSelected.TabIndex = 5;
            this.lblPlaceToEatSelected.Text = "None";
            // 
            // lblIceQuantity
            // 
            this.lblIceQuantity.AutoSize = true;
            this.lblIceQuantity.Location = new System.Drawing.Point(8, 153);
            this.lblIceQuantity.Name = "lblIceQuantity";
            this.lblIceQuantity.Size = new System.Drawing.Size(89, 20);
            this.lblIceQuantity.TabIndex = 4;
            this.lblIceQuantity.Text = "Ice quantity:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(8, 130);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cup type:";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(8, 79);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(47, 20);
            this.lblDrink.TabIndex = 1;
            this.lblDrink.Text = "Drink:";
            // 
            // lblPlaceToEat
            // 
            this.lblPlaceToEat.AutoSize = true;
            this.lblPlaceToEat.Location = new System.Drawing.Point(8, 31);
            this.lblPlaceToEat.Name = "lblPlaceToEat";
            this.lblPlaceToEat.Size = new System.Drawing.Size(90, 20);
            this.lblPlaceToEat.TabIndex = 0;
            this.lblPlaceToEat.Text = "Place to eat:";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(541, 300);
            this.btnCompleteOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(245, 55);
            this.btnCompleteOrder.TabIndex = 3;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // drinkMachineScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 687);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.ctnOrderSummary);
            this.Controls.Add(this.ctnPlaceToEat);
            this.Controls.Add(this.ctnAdditional);
            this.Controls.Add(this.ctnSize);
            this.Controls.Add(this.ctnDrinks);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "drinkMachineScreen";
            this.Text = "Drink Machine";
            this.ctnDrinks.ResumeLayout(false);
            this.ctnSize.ResumeLayout(false);
            this.ctnAdditional.ResumeLayout(false);
            this.ctnPlaceToEat.ResumeLayout(false);
            this.ctnOrderSummary.ResumeLayout(false);
            this.ctnOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox ctnDrinks;
        private System.Windows.Forms.GroupBox ctnSize;
        private System.Windows.Forms.GroupBox ctnAdditional;
        private System.Windows.Forms.GroupBox ctnPlaceToEat;
        private System.Windows.Forms.GroupBox ctnOrderSummary;
        private System.Windows.Forms.Button btnGrapeJuice;
        private System.Windows.Forms.Button btnOrangeJuice;
        private System.Windows.Forms.Button btnGuarana;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnSize700ml;
        private System.Windows.Forms.Button btnSize500ml;
        private System.Windows.Forms.Button btnSize300ml;
        private System.Windows.Forms.Button btnNoIce;
        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblPlaceToEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCupTypeSelected;
        private System.Windows.Forms.Label lblSizeSelected;
        private System.Windows.Forms.Label lblDrinkSelected;
        private System.Windows.Forms.Label lblPlaceToEatSelected;
        private System.Windows.Forms.Label lblIceQuantity;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblIceQuantitySelected;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCupLidSelected;
    }
}

