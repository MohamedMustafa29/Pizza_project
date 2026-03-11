namespace Pizza_project
{
    partial class PizzaOrder
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
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.grpWhere = new System.Windows.Forms.GroupBox();
            this.rdoTake = new System.Windows.Forms.RadioButton();
            this.rdoEat = new System.Windows.Forms.RadioButton();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizeAdded = new System.Windows.Forms.Label();
            this.lblToppingsoption = new System.Windows.Forms.Label();
            this.lblToppingsOptionAdded = new System.Windows.Forms.Label();
            this.lblWhere = new System.Windows.Forms.Label();
            this.lblWhereAdded = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblCrustAdded = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPriceAdded = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmall.ForeColor = System.Drawing.Color.Black;
            this.rdoSmall.Location = new System.Drawing.Point(30, 30);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(83, 29);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Tag = "30";
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.ForeColor = System.Drawing.Color.Black;
            this.rdoMedium.Location = new System.Drawing.Point(30, 72);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(106, 29);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Tag = "40";
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.ForeColor = System.Drawing.Color.Black;
            this.rdoLarge.Location = new System.Drawing.Point(30, 114);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(85, 29);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Tag = "50";
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoMedium);
            this.grpSize.Controls.Add(this.rdoSmall);
            this.grpSize.Controls.Add(this.rdoLarge);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpSize.Location = new System.Drawing.Point(29, 108);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(266, 189);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(275, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 73);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Make Your Pizza";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoThick);
            this.grpType.Controls.Add(this.rdoThin);
            this.grpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpType.Location = new System.Drawing.Point(29, 333);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(266, 189);
            this.grpType.TabIndex = 2;
            this.grpType.TabStop = false;
            this.grpType.Text = "Crust Type";
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThick.ForeColor = System.Drawing.Color.Black;
            this.rdoThick.Location = new System.Drawing.Point(30, 102);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(139, 29);
            this.rdoThick.TabIndex = 4;
            this.rdoThick.Tag = "40";
            this.rdoThick.Text = "Thick Crust";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Checked = true;
            this.rdoThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThin.ForeColor = System.Drawing.Color.Black;
            this.rdoThin.Location = new System.Drawing.Point(30, 56);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(129, 29);
            this.rdoThin.TabIndex = 3;
            this.rdoThin.TabStop = true;
            this.rdoThin.Tag = "30";
            this.rdoThin.Text = "Thin Crust";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToppings.Location = new System.Drawing.Point(362, 108);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(109, 25);
            this.lblToppings.TabIndex = 6;
            this.lblToppings.Text = "Toppings";
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(345, 151);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(149, 29);
            this.chkExtraChees.TabIndex = 4;
            this.chkExtraChees.Tag = "15";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(345, 206);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(143, 29);
            this.chkMushrooms.TabIndex = 5;
            this.chkMushrooms.Tag = "20";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(345, 268);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(126, 29);
            this.chkTomatoes.TabIndex = 6;
            this.chkTomatoes.Tag = "10";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(560, 151);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(88, 29);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Tag = "12";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(560, 206);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(91, 29);
            this.chkOlives.TabIndex = 8;
            this.chkOlives.Tag = "10";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(560, 268);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(176, 29);
            this.chkGreenPeppers.TabIndex = 9;
            this.chkGreenPeppers.Tag = "15";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // grpWhere
            // 
            this.grpWhere.Controls.Add(this.rdoTake);
            this.grpWhere.Controls.Add(this.rdoEat);
            this.grpWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpWhere.Location = new System.Drawing.Point(361, 351);
            this.grpWhere.Name = "grpWhere";
            this.grpWhere.Size = new System.Drawing.Size(272, 113);
            this.grpWhere.TabIndex = 3;
            this.grpWhere.TabStop = false;
            this.grpWhere.Text = "Where to Eat";
            // 
            // rdoTake
            // 
            this.rdoTake.AutoSize = true;
            this.rdoTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTake.ForeColor = System.Drawing.Color.Black;
            this.rdoTake.Location = new System.Drawing.Point(148, 38);
            this.rdoTake.Name = "rdoTake";
            this.rdoTake.Size = new System.Drawing.Size(118, 29);
            this.rdoTake.TabIndex = 12;
            this.rdoTake.Tag = "30";
            this.rdoTake.Text = "Take Out";
            this.rdoTake.UseVisualStyleBackColor = true;
            this.rdoTake.CheckedChanged += new System.EventHandler(this.rdoTake_CheckedChanged);
            // 
            // rdoEat
            // 
            this.rdoEat.AutoSize = true;
            this.rdoEat.Checked = true;
            this.rdoEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEat.ForeColor = System.Drawing.Color.Black;
            this.rdoEat.Location = new System.Drawing.Point(6, 38);
            this.rdoEat.Name = "rdoEat";
            this.rdoEat.Size = new System.Drawing.Size(85, 29);
            this.rdoEat.TabIndex = 11;
            this.rdoEat.TabStop = true;
            this.rdoEat.Tag = "30";
            this.rdoEat.Text = "Eat In";
            this.rdoEat.UseVisualStyleBackColor = true;
            this.rdoEat.CheckedChanged += new System.EventHandler(this.rdoEat_CheckedChanged);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSummary.Location = new System.Drawing.Point(773, 94);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(189, 25);
            this.lblSummary.TabIndex = 14;
            this.lblSummary.Text = "Order Summary :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(802, 138);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 25);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Size :";
            // 
            // lblSizeAdded
            // 
            this.lblSizeAdded.AutoSize = true;
            this.lblSizeAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeAdded.ForeColor = System.Drawing.Color.Black;
            this.lblSizeAdded.Location = new System.Drawing.Point(874, 138);
            this.lblSizeAdded.Name = "lblSizeAdded";
            this.lblSizeAdded.Size = new System.Drawing.Size(70, 25);
            this.lblSizeAdded.TabIndex = 16;
            this.lblSizeAdded.Text = "Small";
            // 
            // lblToppingsoption
            // 
            this.lblToppingsoption.AutoSize = true;
            this.lblToppingsoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsoption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToppingsoption.Location = new System.Drawing.Point(789, 182);
            this.lblToppingsoption.Name = "lblToppingsoption";
            this.lblToppingsoption.Size = new System.Drawing.Size(104, 24);
            this.lblToppingsoption.TabIndex = 17;
            this.lblToppingsoption.Text = "Toppings:";
            // 
            // lblToppingsOptionAdded
            // 
            this.lblToppingsOptionAdded.AutoSize = true;
            this.lblToppingsOptionAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsOptionAdded.Location = new System.Drawing.Point(806, 224);
            this.lblToppingsOptionAdded.Name = "lblToppingsOptionAdded";
            this.lblToppingsOptionAdded.Size = new System.Drawing.Size(45, 25);
            this.lblToppingsOptionAdded.TabIndex = 18;
            this.lblToppingsOptionAdded.Text = "No ";
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWhere.Location = new System.Drawing.Point(789, 351);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(143, 24);
            this.lblWhere.TabIndex = 4;
            this.lblWhere.Text = "Where to Eat :";
            // 
            // lblWhereAdded
            // 
            this.lblWhereAdded.AutoSize = true;
            this.lblWhereAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereAdded.ForeColor = System.Drawing.Color.Black;
            this.lblWhereAdded.Location = new System.Drawing.Point(938, 351);
            this.lblWhereAdded.Name = "lblWhereAdded";
            this.lblWhereAdded.Size = new System.Drawing.Size(63, 24);
            this.lblWhereAdded.TabIndex = 19;
            this.lblWhereAdded.Text = "Eat In";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCrustType.Location = new System.Drawing.Point(789, 273);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(123, 24);
            this.lblCrustType.TabIndex = 20;
            this.lblCrustType.Text = "Crust Type :";
            // 
            // lblCrustAdded
            // 
            this.lblCrustAdded.AutoSize = true;
            this.lblCrustAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustAdded.Location = new System.Drawing.Point(906, 270);
            this.lblCrustAdded.Name = "lblCrustAdded";
            this.lblCrustAdded.Size = new System.Drawing.Size(106, 24);
            this.lblCrustAdded.TabIndex = 21;
            this.lblCrustAdded.Text = "Thin Crust";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(803, 411);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 24);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 23;
            // 
            // lblPriceAdded
            // 
            this.lblPriceAdded.AutoSize = true;
            this.lblPriceAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPriceAdded.Location = new System.Drawing.Point(824, 454);
            this.lblPriceAdded.Name = "lblPriceAdded";
            this.lblPriceAdded.Size = new System.Drawing.Size(234, 108);
            this.lblPriceAdded.TabIndex = 24;
            this.lblPriceAdded.Text = "00 $";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Green;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(313, 513);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(213, 49);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResert
            // 
            this.btnResert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResert.ForeColor = System.Drawing.Color.Black;
            this.btnResert.Location = new System.Drawing.Point(560, 513);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(213, 49);
            this.btnResert.TabIndex = 14;
            this.btnResert.Text = "ResertForm";
            this.btnResert.UseVisualStyleBackColor = false;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click_1);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1118, 603);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.lblPriceAdded);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.chkOnion);
            this.Controls.Add(this.chkExtraChees);
            this.Controls.Add(this.chkMushrooms);
            this.Controls.Add(this.lblCrustAdded);
            this.Controls.Add(this.chkTomatoes);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.chkOlives);
            this.Controls.Add(this.lblWhereAdded);
            this.Controls.Add(this.chkGreenPeppers);
            this.Controls.Add(this.lblWhere);
            this.Controls.Add(this.lblToppingsOptionAdded);
            this.Controls.Add(this.lblToppingsoption);
            this.Controls.Add(this.lblSizeAdded);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.grpWhere);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpSize);
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpWhere.ResumeLayout(false);
            this.grpWhere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.GroupBox grpWhere;
        private System.Windows.Forms.RadioButton rdoTake;
        private System.Windows.Forms.RadioButton rdoEat;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeAdded;
        private System.Windows.Forms.Label lblToppingsoption;
        private System.Windows.Forms.Label lblToppingsOptionAdded;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblWhereAdded;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblCrustAdded;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPriceAdded;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnResert;
    }
}

