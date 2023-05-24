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
            paymentButton = new Button();
            giftButton = new RadioButton();
            bagButton = new RadioButton();
            cashButton = new RadioButton();
            cardButton = new RadioButton();
            toPayLabel = new Label();
            selasLabel = new Label();
            itemsLabel = new Label();
            payment = new Label();
            label1 = new Label();
            cashtextBox = new TextBox();
            makingDrinks = new Label();
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
            comboBoxSnack.Location = new Point(11, 97);
            comboBoxSnack.Name = "comboBoxSnack";
            comboBoxSnack.Size = new Size(129, 28);
            comboBoxSnack.TabIndex = 6;
            comboBoxSnack.SelectedIndexChanged += comboBoxSnack_SelectedIndexChanged;
            // 
            // comboBoxPastris
            // 
            comboBoxPastris.Enabled = false;
            comboBoxPastris.FormattingEnabled = true;
            comboBoxPastris.Location = new Point(303, 97);
            comboBoxPastris.Name = "comboBoxPastris";
            comboBoxPastris.Size = new Size(151, 28);
            comboBoxPastris.TabIndex = 7;
            comboBoxPastris.SelectedIndexChanged += comboBoxPastris_SelectedIndexChanged;
            // 
            // comboBoxDrink
            // 
            comboBoxDrink.Enabled = false;
            comboBoxDrink.FormattingEnabled = true;
            comboBoxDrink.Location = new Point(145, 97);
            comboBoxDrink.Name = "comboBoxDrink";
            comboBoxDrink.Size = new Size(151, 28);
            comboBoxDrink.TabIndex = 8;
            comboBoxDrink.SelectedIndexChanged += comboBoxDrink_SelectedIndexChanged;
            // 
            // comboBoxCupDrink
            // 
            comboBoxCupDrink.Enabled = false;
            comboBoxCupDrink.FormattingEnabled = true;
            comboBoxCupDrink.Location = new Point(461, 97);
            comboBoxCupDrink.Name = "comboBoxCupDrink";
            comboBoxCupDrink.Size = new Size(151, 28);
            comboBoxCupDrink.TabIndex = 9;
            comboBoxCupDrink.SelectedIndexChanged += comboBoxCupDrink_SelectedIndexChanged_1;
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
            startButton.Location = new Point(305, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(165, 35);
            startButton.TabIndex = 11;
            startButton.Text = "לחץ להתחלה";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // paymentButton
            // 
            paymentButton.Enabled = false;
            paymentButton.Location = new Point(633, 119);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(155, 36);
            paymentButton.TabIndex = 13;
            paymentButton.Text = "תשלום";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // giftButton
            // 
            giftButton.AutoSize = true;
            giftButton.Enabled = false;
            giftButton.Location = new Point(633, 184);
            giftButton.Name = "giftButton";
            giftButton.Size = new Size(145, 24);
            giftButton.TabIndex = 14;
            giftButton.TabStop = true;
            giftButton.Text = "אריזת מתנה-5שח";
            giftButton.UseVisualStyleBackColor = true;
            giftButton.CheckedChanged += giftButton_CheckedChanged;
            // 
            // bagButton
            // 
            bagButton.AutoSize = true;
            bagButton.Enabled = false;
            bagButton.Location = new Point(633, 214);
            bagButton.Name = "bagButton";
            bagButton.Size = new Size(107, 24);
            bagButton.TabIndex = 15;
            bagButton.TabStop = true;
            bagButton.Text = "שקית-1שח ";
            bagButton.UseVisualStyleBackColor = true;
            bagButton.CheckedChanged += bagButton_CheckedChanged;
            // 
            // cashButton
            // 
            cashButton.AutoSize = true;
            cashButton.Enabled = false;
            cashButton.Location = new Point(633, 293);
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
            cardButton.Location = new Point(633, 263);
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
            toPayLabel.Location = new Point(656, 86);
            toPayLabel.Name = "toPayLabel";
            toPayLabel.Size = new Size(100, 20);
            toPayLabel.TabIndex = 18;
            toPayLabel.Text = "סה\"כ לתשלום";
            toPayLabel.Visible = false;
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
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Location = new Point(351, 390);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.RightToLeft = RightToLeft.No;
            itemsLabel.Size = new Size(119, 20);
            itemsLabel.TabIndex = 20;
            itemsLabel.Text = "-רשימת המוצרים";
            itemsLabel.TextAlign = ContentAlignment.MiddleLeft;
            itemsLabel.Visible = false;
            // 
            // payment
            // 
            payment.AutoSize = true;
            payment.Enabled = false;
            payment.Location = new Point(657, 55);
            payment.Name = "payment";
            payment.Size = new Size(110, 20);
            payment.TabIndex = 21;
            payment.Text = "-סה\"כ לתשלום ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 346);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // cashtextBox
            // 
            cashtextBox.Location = new Point(633, 387);
            cashtextBox.Name = "cashtextBox";
            cashtextBox.Size = new Size(123, 27);
            cashtextBox.TabIndex = 23;
            cashtextBox.Text = "הכנס כסף";
            // 
            // makingDrinks
            // 
            makingDrinks.AutoSize = true;
            makingDrinks.Font = new Font("Snap ITC", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            makingDrinks.Location = new Point(64, 200);
            makingDrinks.Name = "makingDrinks";
            makingDrinks.Size = new Size(151, 24);
            makingDrinks.TabIndex = 24;
            makingDrinks.Text = "making drinks";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(makingDrinks);
            Controls.Add(cashtextBox);
            Controls.Add(label1);
            Controls.Add(payment);
            Controls.Add(itemsLabel);
            Controls.Add(selasLabel);
            Controls.Add(toPayLabel);
            Controls.Add(cardButton);
            Controls.Add(cashButton);
            Controls.Add(bagButton);
            Controls.Add(giftButton);
            Controls.Add(paymentButton);
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
        public Button paymentButton;
        public RadioButton giftButton;
        public RadioButton bagButton;
        public RadioButton cashButton;
        public RadioButton cardButton;
        public Label toPayLabel;
        public Label selasLabel;
        public Label itemsLabel;
        public Label payment;
        private Label label1;
        private TextBox cashtextBox;
        public Label makingDrinks;
    }
}