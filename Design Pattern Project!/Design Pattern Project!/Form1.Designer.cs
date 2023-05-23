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
            Snack.Location = new Point(41, 40);
            Snack.Margin = new Padding(3, 2, 3, 2);
            Snack.Name = "Snack";
            Snack.Size = new Size(58, 25);
            Snack.TabIndex = 1;
            Snack.Text = "חטיפים";
            Snack.Click += Snack_Click;
            // 
            // Drink
            // 
            Drink.AutoSize = true;
            Drink.Enabled = false;
            Drink.Location = new Point(168, 40);
            Drink.Margin = new Padding(3, 2, 3, 2);
            Drink.Name = "Drink";
            Drink.Size = new Size(49, 25);
            Drink.TabIndex = 2;
            Drink.Text = "שתיה";
            Drink.Click += Drink_Click;
            // 
            // Pastris
            // 
            Pastris.AutoSize = true;
            Pastris.Enabled = false;
            Pastris.Location = new Point(297, 39);
            Pastris.Margin = new Padding(3, 2, 3, 2);
            Pastris.Name = "Pastris";
            Pastris.Size = new Size(54, 25);
            Pastris.TabIndex = 3;
            Pastris.Text = "מאפים";
            Pastris.Click += Pastris_Click;
            // 
            // comboBoxSnack
            // 
            comboBoxSnack.DisplayMember = "Snack";
            comboBoxSnack.Enabled = false;
            comboBoxSnack.FormattingEnabled = true;
            comboBoxSnack.Location = new Point(10, 73);
            comboBoxSnack.Margin = new Padding(3, 2, 3, 2);
            comboBoxSnack.Name = "comboBoxSnack";
            comboBoxSnack.Size = new Size(113, 23);
            comboBoxSnack.TabIndex = 6;
            comboBoxSnack.SelectedIndexChanged += comboBoxSnack_SelectedIndexChanged;
            // 
            // comboBoxPastris
            // 
            comboBoxPastris.Enabled = false;
            comboBoxPastris.FormattingEnabled = true;
            comboBoxPastris.Location = new Point(265, 73);
            comboBoxPastris.Margin = new Padding(3, 2, 3, 2);
            comboBoxPastris.Name = "comboBoxPastris";
            comboBoxPastris.Size = new Size(133, 23);
            comboBoxPastris.TabIndex = 7;
            comboBoxPastris.SelectedIndexChanged += comboBoxPastris_SelectedIndexChanged;
            // 
            // comboBoxDrink
            // 
            comboBoxDrink.Enabled = false;
            comboBoxDrink.FormattingEnabled = true;
            comboBoxDrink.Location = new Point(127, 73);
            comboBoxDrink.Margin = new Padding(3, 2, 3, 2);
            comboBoxDrink.Name = "comboBoxDrink";
            comboBoxDrink.Size = new Size(133, 23);
            comboBoxDrink.TabIndex = 8;
            // 
            // comboBoxCupDrink
            // 
            comboBoxCupDrink.Enabled = false;
            comboBoxCupDrink.FormattingEnabled = true;
            comboBoxCupDrink.Location = new Point(403, 73);
            comboBoxCupDrink.Margin = new Padding(3, 2, 3, 2);
            comboBoxCupDrink.Name = "comboBoxCupDrink";
            comboBoxCupDrink.Size = new Size(133, 23);
            comboBoxCupDrink.TabIndex = 9;
            // 
            // CupDrink
            // 
            CupDrink.AutoSize = true;
            CupDrink.Enabled = false;
            CupDrink.Location = new Point(431, 41);
            CupDrink.Name = "CupDrink";
            CupDrink.Size = new Size(72, 25);
            CupDrink.TabIndex = 10;
            CupDrink.Text = "כוס שתיה";
            CupDrink.Click += CupDrink_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(225, 2);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(144, 26);
            startButton.TabIndex = 11;
            startButton.Text = "לחץ להתחלה";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // getMoreItems
            // 
            getMoreItems.Enabled = false;
            getMoreItems.Location = new Point(554, 82);
            getMoreItems.Margin = new Padding(3, 2, 3, 2);
            getMoreItems.Name = "getMoreItems";
            getMoreItems.Size = new Size(136, 30);
            getMoreItems.TabIndex = 12;
            getMoreItems.Text = "בחירת מוצר נוסף";
            getMoreItems.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Enabled = false;
            paymentButton.Location = new Point(554, 117);
            paymentButton.Margin = new Padding(3, 2, 3, 2);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(136, 27);
            paymentButton.TabIndex = 13;
            paymentButton.Text = "תשלום";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // giftButton
            // 
            giftButton.AutoSize = true;
            giftButton.Enabled = false;
            giftButton.Location = new Point(556, 163);
            giftButton.Margin = new Padding(3, 2, 3, 2);
            giftButton.Name = "giftButton";
            giftButton.Size = new Size(89, 19);
            giftButton.TabIndex = 14;
            giftButton.TabStop = true;
            giftButton.Text = "אריזת מתנה";
            giftButton.UseVisualStyleBackColor = true;
            // 
            // bagButton
            // 
            bagButton.AutoSize = true;
            bagButton.Enabled = false;
            bagButton.Location = new Point(556, 185);
            bagButton.Margin = new Padding(3, 2, 3, 2);
            bagButton.Name = "bagButton";
            bagButton.Size = new Size(57, 19);
            bagButton.TabIndex = 15;
            bagButton.TabStop = true;
            bagButton.Text = "שקית ";
            bagButton.UseVisualStyleBackColor = true;
            // 
            // cashButton
            // 
            cashButton.AutoSize = true;
            cashButton.Enabled = false;
            cashButton.Location = new Point(556, 245);
            cashButton.Margin = new Padding(3, 2, 3, 2);
            cashButton.Name = "cashButton";
            cashButton.Size = new Size(97, 19);
            cashButton.TabIndex = 16;
            cashButton.TabStop = true;
            cashButton.Text = "תשלום במזומן";
            cashButton.UseVisualStyleBackColor = true;
            // 
            // cardButton
            // 
            cardButton.AutoSize = true;
            cardButton.Enabled = false;
            cardButton.Location = new Point(556, 223);
            cardButton.Margin = new Padding(3, 2, 3, 2);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(106, 19);
            cardButton.TabIndex = 17;
            cardButton.TabStop = true;
            cardButton.Text = "תשלום באשראי";
            cardButton.UseVisualStyleBackColor = true;
            cardButton.CheckedChanged += cardButton_CheckedChanged;
            // 
            // toPayLabel
            // 
            toPayLabel.AutoSize = true;
            toPayLabel.Enabled = false;
            toPayLabel.Location = new Point(584, 56);
            toPayLabel.Name = "toPayLabel";
            toPayLabel.Size = new Size(81, 15);
            toPayLabel.TabIndex = 18;
            toPayLabel.Text = "סה\"כ לתשלום";
            // 
            // selasLabel
            // 
            selasLabel.AutoSize = true;
            selasLabel.Location = new Point(208, 316);
            selasLabel.Name = "selasLabel";
            selasLabel.Size = new Size(247, 15);
            selasLabel.TabIndex = 19;
            selasLabel.Text = "שמחים שבחרת להשתמש במוצרינו,קניה מהנה!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
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