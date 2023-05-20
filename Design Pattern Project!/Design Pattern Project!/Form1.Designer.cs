namespace Design_Pattern_Project_
{
    partial class Form1
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
            this.Snack = new System.Windows.Forms.Label();
            this.Drink = new System.Windows.Forms.Label();
            this.Pastris = new System.Windows.Forms.Label();
            this.comboBoxSnack = new System.Windows.Forms.ComboBox();
            this.comboBoxPastris = new System.Windows.Forms.ComboBox();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.comboBoxCupDrink = new System.Windows.Forms.ComboBox();
            this.CupDrink = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.getMoreItems = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.giftButton = new System.Windows.Forms.RadioButton();
            this.bagButton = new System.Windows.Forms.RadioButton();
            this.cashButton = new System.Windows.Forms.RadioButton();
            this.cardButton = new System.Windows.Forms.RadioButton();
            this.toPayLabel = new System.Windows.Forms.Label();
            this.selasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Snack
            // 
            this.Snack.AutoSize = true;
            this.Snack.Enabled = false;
            this.Snack.Location = new System.Drawing.Point(47, 53);
            this.Snack.Name = "Snack";
            this.Snack.Size = new System.Drawing.Size(56, 20);
            this.Snack.TabIndex = 1;
            this.Snack.Text = "חטיפים";
            // 
            // Drink
            // 
            this.Drink.AutoSize = true;
            this.Drink.Enabled = false;
            this.Drink.Location = new System.Drawing.Point(192, 53);
            this.Drink.Name = "Drink";
            this.Drink.Size = new System.Drawing.Size(46, 20);
            this.Drink.TabIndex = 2;
            this.Drink.Text = "שתיה";
            // 
            // Pastris
            // 
            this.Pastris.AutoSize = true;
            this.Pastris.Enabled = false;
            this.Pastris.Location = new System.Drawing.Point(339, 52);
            this.Pastris.Name = "Pastris";
            this.Pastris.Size = new System.Drawing.Size(52, 20);
            this.Pastris.TabIndex = 3;
            this.Pastris.Text = "מאפים";
            // 
            // comboBoxSnack
            // 
            this.comboBoxSnack.DisplayMember = "Snack";
            this.comboBoxSnack.Enabled = false;
            this.comboBoxSnack.FormattingEnabled = true;
            this.comboBoxSnack.Items.AddRange(new object[] {
            "תפוצ\'יפס טבעי",
            "תפוצ\'יפס שמנת בצל",
            "דוריטוס טבעי",
            "דוריטוס חמוץ חריף",
            "דוריטוס חריף אש",
            "צ\'יטוס קטשופ",
            "צ\'יטוס פיצה",
            "פריכיות אורז בשוקולד",
            "נשנושים",
            "שוגי",
            "פסק זמן",
            "שוקולד חלבי עילית"});
            this.comboBoxSnack.Location = new System.Drawing.Point(12, 76);
            this.comboBoxSnack.Name = "comboBoxSnack";
            this.comboBoxSnack.Size = new System.Drawing.Size(129, 28);
            this.comboBoxSnack.TabIndex = 6;
            this.comboBoxSnack.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPastris
            // 
            this.comboBoxPastris.Enabled = false;
            this.comboBoxPastris.FormattingEnabled = true;
            this.comboBoxPastris.Items.AddRange(new object[] {
            "בורקס תפו\'א",
            "בורקס גבינה",
            "פיציה",
            "רוגלה",
            "סופלה",
            "בגט גבינה",
            "מלווח",
            "בייגל בצל",
            "קרואוסון",
            "סמבוסק"});
            this.comboBoxPastris.Location = new System.Drawing.Point(304, 76);
            this.comboBoxPastris.Name = "comboBoxPastris";
            this.comboBoxPastris.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPastris.TabIndex = 7;
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.Enabled = false;
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Items.AddRange(new object[] {
            "סודה",
            "מים מינרלים",
            "מים בטעמים-תפוח",
            "מים בטעמים-ענבים",
            "בירה",
            "פפסי",
            "מירינדה",
            "ג\'אמפ מנגו",
            "ג\'אמפ תות בננה",
            "ספרייט",
            "קוקה קולה דיאט",
            "קוקה קולה"});
            this.comboBoxDrink.Location = new System.Drawing.Point(147, 76);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDrink.TabIndex = 8;
            // 
            // comboBoxCupDrink
            // 
            this.comboBoxCupDrink.Enabled = false;
            this.comboBoxCupDrink.FormattingEnabled = true;
            this.comboBoxCupDrink.Items.AddRange(new object[] {
            "אקספרסו",
            "שייק פירות",
            "ברד פטל",
            "ברד ענבים",
            "אייס וניל",
            "אייס פסיפלורה",
            "אייס אגוזים",
            "אייס קפה",
            "קפה הפוך",
            "קפה נמס",
            "קפה שחור",
            "צ\'וקולטה"});
            this.comboBoxCupDrink.Location = new System.Drawing.Point(461, 75);
            this.comboBoxCupDrink.Name = "comboBoxCupDrink";
            this.comboBoxCupDrink.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCupDrink.TabIndex = 9;
            // 
            // CupDrink
            // 
            this.CupDrink.AutoSize = true;
            this.CupDrink.Enabled = false;
            this.CupDrink.Location = new System.Drawing.Point(493, 52);
            this.CupDrink.Name = "CupDrink";
            this.CupDrink.Size = new System.Drawing.Size(72, 20);
            this.CupDrink.TabIndex = 10;
            this.CupDrink.Text = "כוס שתיה";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(257, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 34);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "לחץ להתחלה";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // getMoreItems
            // 
            this.getMoreItems.Enabled = false;
            this.getMoreItems.Location = new System.Drawing.Point(633, 110);
            this.getMoreItems.Name = "getMoreItems";
            this.getMoreItems.Size = new System.Drawing.Size(155, 40);
            this.getMoreItems.TabIndex = 12;
            this.getMoreItems.Text = "בחירת מוצר נוסף";
            this.getMoreItems.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            this.paymentButton.Enabled = false;
            this.paymentButton.Location = new System.Drawing.Point(633, 156);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(155, 36);
            this.paymentButton.TabIndex = 13;
            this.paymentButton.Text = "תשלום";
            this.paymentButton.UseVisualStyleBackColor = true;
            // 
            // giftButton
            // 
            this.giftButton.AutoSize = true;
            this.giftButton.Enabled = false;
            this.giftButton.Location = new System.Drawing.Point(635, 217);
            this.giftButton.Name = "giftButton";
            this.giftButton.Size = new System.Drawing.Size(109, 24);
            this.giftButton.TabIndex = 14;
            this.giftButton.TabStop = true;
            this.giftButton.Text = "אריזת מתנה";
            this.giftButton.UseVisualStyleBackColor = true;
            // 
            // bagButton
            // 
            this.bagButton.AutoSize = true;
            this.bagButton.Enabled = false;
            this.bagButton.Location = new System.Drawing.Point(635, 247);
            this.bagButton.Name = "bagButton";
            this.bagButton.Size = new System.Drawing.Size(71, 24);
            this.bagButton.TabIndex = 15;
            this.bagButton.TabStop = true;
            this.bagButton.Text = "שקית ";
            this.bagButton.UseVisualStyleBackColor = true;
            // 
            // cashButton
            // 
            this.cashButton.AutoSize = true;
            this.cashButton.Enabled = false;
            this.cashButton.Location = new System.Drawing.Point(635, 327);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(121, 24);
            this.cashButton.TabIndex = 16;
            this.cashButton.TabStop = true;
            this.cashButton.Text = "תשלום במזומן";
            this.cashButton.UseVisualStyleBackColor = true;
            // 
            // cardButton
            // 
            this.cardButton.AutoSize = true;
            this.cardButton.Enabled = false;
            this.cardButton.Location = new System.Drawing.Point(635, 297);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(132, 24);
            this.cardButton.TabIndex = 17;
            this.cardButton.TabStop = true;
            this.cardButton.Text = "תשלום באשראי";
            this.cardButton.UseVisualStyleBackColor = true;
            // 
            // toPayLabel
            // 
            this.toPayLabel.AutoSize = true;
            this.toPayLabel.Enabled = false;
            this.toPayLabel.Location = new System.Drawing.Point(667, 75);
            this.toPayLabel.Name = "toPayLabel";
            this.toPayLabel.Size = new System.Drawing.Size(100, 20);
            this.toPayLabel.TabIndex = 18;
            this.toPayLabel.Text = "סה\"כ לתשלום";
            // 
            // selasLabel
            // 
            this.selasLabel.AutoSize = true;
            this.selasLabel.Location = new System.Drawing.Point(238, 421);
            this.selasLabel.Name = "selasLabel";
            this.selasLabel.Size = new System.Drawing.Size(311, 20);
            this.selasLabel.TabIndex = 19;
            this.selasLabel.Text = "שמחים שבחרת להשתמש במוצרינו,קניה מהנה!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selasLabel);
            this.Controls.Add(this.toPayLabel);
            this.Controls.Add(this.cardButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.bagButton);
            this.Controls.Add(this.giftButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.getMoreItems);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.CupDrink);
            this.Controls.Add(this.comboBoxCupDrink);
            this.Controls.Add(this.comboBoxDrink);
            this.Controls.Add(this.comboBoxPastris);
            this.Controls.Add(this.comboBoxSnack);
            this.Controls.Add(this.Pastris);
            this.Controls.Add(this.Drink);
            this.Controls.Add(this.Snack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label Snack;
        public Label Drink;
        public Label Pastris;
        public ComboBox comboBoxSnack;
        public ComboBox comboBoxPastris;
        public ComboBox comboBoxDrink;
        public ComboBox comboBoxCupDrink;
        public Label CupDrink;
        public Button startButton;
        public Button getMoreItems;
        public Button paymentButton;
        public RadioButton giftButton;
        public RadioButton bagButton;
        public RadioButton cashButton;
        public RadioButton cardButton;
        public Label toPayLabel;
        public Label selasLabel;
    }
}