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
            Snack = new Button();
            Drink = new Button();
            Pastris = new Button();
            comboBoxSnack = new ComboBox();
            comboBoxPastris = new ComboBox();
            comboBoxDrink = new ComboBox();
            comboBoxCupDrink = new ComboBox();
            CupDrink = new Button();
            startButton = new Button();
            getMoreItems = new Button();
            paymentButton = new Button();
            giftButton = new RadioButton();
            bagButton = new RadioButton();
            cashButton = new RadioButton();
            cardButton = new RadioButton();
            toPayLabel = new Label();
            selasLabel = new Label();
            SuspendLayout();
            // 
            // Snack
            // 
            Snack.AutoSize = true;
            Snack.Enabled = false;
            Snack.Location = new Point(47, 53);
            Snack.Name = "Snack";
            Snack.Size = new Size(66, 33);
            Snack.TabIndex = 1;
            Snack.Text = "חטיפים";
            Snack.Click += Snack_Click;
            // 
            // Drink
            // 
            Drink.AutoSize = true;
            Drink.Enabled = false;
            Drink.Location = new Point(192, 53);
            Drink.Name = "Drink";
            Drink.Size = new Size(56, 33);
            Drink.TabIndex = 2;
            Drink.Text = "שתיה";
            Drink.Click += Drink_Click;
            // 
            // Pastris
            // 
            Pastris.AutoSize = true;
            Pastris.Enabled = false;
            Pastris.Location = new Point(339, 52);
            Pastris.Name = "Pastris";
            Pastris.Size = new Size(62, 33);
            Pastris.TabIndex = 3;
            Pastris.Text = "מאפים";
            Pastris.Click += Pastris_Click;
            // 
            // comboBoxSnack
            // 
            comboBoxSnack.DisplayMember = "Snack";
            comboBoxSnack.Enabled = false;
            comboBoxSnack.FormattingEnabled = true;
            comboBoxSnack.Items.AddRange(new object[] { "תפוצ'יפס טבעי", "תפוצ'יפס שמנת בצל", "דוריטוס טבעי", "דוריטוס חמוץ חריף", "דוריטוס חריף אש", "צ'יטוס קטשופ", "צ'יטוס פיצה", "פריכיות אורז בשוקולד", "נשנושים", "שוגי", "פסק זמן", "שוקולד חלבי עילית" });
            comboBoxSnack.Location = new Point(11, 97);
            comboBoxSnack.Name = "comboBoxSnack";
            comboBoxSnack.Size = new Size(129, 28);
            comboBoxSnack.TabIndex = 6;
            comboBoxSnack.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxPastris
            // 
            comboBoxPastris.Enabled = false;
            comboBoxPastris.FormattingEnabled = true;
            comboBoxPastris.Items.AddRange(new object[] { "בורקס תפו'א", "בורקס גבינה", "פיציה", "רוגלה", "סופלה", "בגט גבינה", "מלווח", "בייגל בצל", "קרואוסון", "סמבוסק" });
            comboBoxPastris.Location = new Point(303, 97);
            comboBoxPastris.Name = "comboBoxPastris";
            comboBoxPastris.Size = new Size(151, 28);
            comboBoxPastris.TabIndex = 7;
            // 
            // comboBoxDrink
            // 
            comboBoxDrink.Enabled = false;
            comboBoxDrink.FormattingEnabled = true;
            comboBoxDrink.Items.AddRange(new object[] { "סודה", "מים מינרלים", "מים בטעמים-תפוח", "מים בטעמים-ענבים", "בירה", "פפסי", "מירינדה", "ג'אמפ מנגו", "ג'אמפ תות בננה", "ספרייט", "קוקה קולה דיאט", "קוקה קולה" });
            comboBoxDrink.Location = new Point(145, 97);
            comboBoxDrink.Name = "comboBoxDrink";
            comboBoxDrink.Size = new Size(151, 28);
            comboBoxDrink.TabIndex = 8;
            // 
            // comboBoxCupDrink
            // 
            comboBoxCupDrink.Enabled = false;
            comboBoxCupDrink.FormattingEnabled = true;
            comboBoxCupDrink.Items.AddRange(new object[] { "אקספרסו", "שייק פירות", "ברד פטל", "ברד ענבים", "אייס וניל", "אייס פסיפלורה", "אייס אגוזים", "אייס קפה", "קפה הפוך", "קפה נמס", "קפה שחור", "צ'וקולטה" });
            comboBoxCupDrink.Location = new Point(461, 97);
            comboBoxCupDrink.Name = "comboBoxCupDrink";
            comboBoxCupDrink.Size = new Size(151, 28);
            comboBoxCupDrink.TabIndex = 9;
            // 
            // CupDrink
            // 
            CupDrink.AutoSize = true;
            CupDrink.Enabled = false;
            CupDrink.Location = new Point(493, 55);
            CupDrink.Margin = new Padding(3, 4, 3, 4);
            CupDrink.Name = "CupDrink";
            CupDrink.Size = new Size(82, 33);
            CupDrink.TabIndex = 10;
            CupDrink.Text = "כוס שתיה";
            CupDrink.Click += CupDrink_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(257, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(165, 35);
            startButton.TabIndex = 11;
            startButton.Text = "לחץ להתחלה";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // getMoreItems
            // 
            getMoreItems.Enabled = false;
            getMoreItems.Location = new Point(633, 109);
            getMoreItems.Name = "getMoreItems";
            getMoreItems.Size = new Size(155, 40);
            getMoreItems.TabIndex = 12;
            getMoreItems.Text = "בחירת מוצר נוסף";
            getMoreItems.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Enabled = false;
            paymentButton.Location = new Point(633, 156);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(155, 36);
            paymentButton.TabIndex = 13;
            paymentButton.Text = "תשלום";
            paymentButton.UseVisualStyleBackColor = true;
            // 
            // giftButton
            // 
            giftButton.AutoSize = true;
            giftButton.Enabled = false;
            giftButton.Location = new Point(635, 217);
            giftButton.Name = "giftButton";
            giftButton.Size = new Size(109, 24);
            giftButton.TabIndex = 14;
            giftButton.TabStop = true;
            giftButton.Text = "אריזת מתנה";
            giftButton.UseVisualStyleBackColor = true;
            // 
            // bagButton
            // 
            bagButton.AutoSize = true;
            bagButton.Enabled = false;
            bagButton.Location = new Point(635, 247);
            bagButton.Name = "bagButton";
            bagButton.Size = new Size(71, 24);
            bagButton.TabIndex = 15;
            bagButton.TabStop = true;
            bagButton.Text = "שקית ";
            bagButton.UseVisualStyleBackColor = true;
            // 
            // cashButton
            // 
            cashButton.AutoSize = true;
            cashButton.Enabled = false;
            cashButton.Location = new Point(635, 327);
            cashButton.Name = "cashButton";
            cashButton.Size = new Size(121, 24);
            cashButton.TabIndex = 16;
            cashButton.TabStop = true;
            cashButton.Text = "תשלום במזומן";
            cashButton.UseVisualStyleBackColor = true;
            // 
            // cardButton
            // 
            cardButton.AutoSize = true;
            cardButton.Enabled = false;
            cardButton.Location = new Point(635, 297);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(132, 24);
            cardButton.TabIndex = 17;
            cardButton.TabStop = true;
            cardButton.Text = "תשלום באשראי";
            cardButton.UseVisualStyleBackColor = true;
            // 
            // toPayLabel
            // 
            toPayLabel.AutoSize = true;
            toPayLabel.Enabled = false;
            toPayLabel.Location = new Point(667, 75);
            toPayLabel.Name = "toPayLabel";
            toPayLabel.Size = new Size(100, 20);
            toPayLabel.TabIndex = 18;
            toPayLabel.Text = "סה\"כ לתשלום";
            // 
            // selasLabel
            // 
            selasLabel.AutoSize = true;
            selasLabel.Location = new Point(238, 421);
            selasLabel.Name = "selasLabel";
            selasLabel.Size = new Size(311, 20);
            selasLabel.TabIndex = 19;
            selasLabel.Text = "שמחים שבחרת להשתמש במוצרינו,קניה מהנה!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(selasLabel);
            Controls.Add(toPayLabel);
            Controls.Add(cardButton);
            Controls.Add(cashButton);
            Controls.Add(bagButton);
            Controls.Add(giftButton);
            Controls.Add(paymentButton);
            Controls.Add(getMoreItems);
            Controls.Add(startButton);
            Controls.Add(CupDrink);
            Controls.Add(comboBoxCupDrink);
            Controls.Add(comboBoxDrink);
            Controls.Add(comboBoxPastris);
            Controls.Add(comboBoxSnack);
            Controls.Add(Pastris);
            Controls.Add(Drink);
            Controls.Add(Snack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button Snack;
        public Button Drink;
        public Button Pastris;
        public ComboBox comboBoxSnack;
        public ComboBox comboBoxPastris;
        public ComboBox comboBoxDrink;
        public ComboBox comboBoxCupDrink;
        public Button CupDrink;
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