namespace Thota_2
{
    partial class Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TermInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.SpringRadioButton = new System.Windows.Forms.RadioButton();
            this.FallRadioButton = new System.Windows.Forms.RadioButton();
            this.TermLabel = new System.Windows.Forms.Label();
            this.StudentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.OutStatePriceLabel = new System.Windows.Forms.Label();
            this.InStatePriceLabel = new System.Windows.Forms.Label();
            this.OutOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.InStateRadioButton = new System.Windows.Forms.RadioButton();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StudentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.CourseOrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfCoursesOutpulLabel = new System.Windows.Forms.Label();
            this.NumberOfCoursesLabel = new System.Windows.Forms.Label();
            this.TotalChargeLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BegSpanishCheckBox = new System.Windows.Forms.CheckBox();
            this.BegRussianCheckBox = new System.Windows.Forms.CheckBox();
            this.BegItalianCheckBox = new System.Windows.Forms.CheckBox();
            this.BegGermanCheckBox = new System.Windows.Forms.CheckBox();
            this.BegFrenchCheckBox = new System.Windows.Forms.CheckBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.PaymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ExpirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CreditCardNumberMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.VisaCreditRadioButton = new System.Windows.Forms.RadioButton();
            this.MasterCardButton = new System.Windows.Forms.RadioButton();
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TermInfoGroupBox.SuspendLayout();
            this.StudentInfoGroupBox.SuspendLayout();
            this.CourseOrderInfoGroupBox.SuspendLayout();
            this.PaymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thota_2.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(382, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TermInfoGroupBox
            // 
            this.TermInfoGroupBox.Controls.Add(this.label1);
            this.TermInfoGroupBox.Controls.Add(this.YearComboBox);
            this.TermInfoGroupBox.Controls.Add(this.SpringRadioButton);
            this.TermInfoGroupBox.Controls.Add(this.FallRadioButton);
            this.TermInfoGroupBox.Controls.Add(this.TermLabel);
            this.TermInfoGroupBox.Location = new System.Drawing.Point(11, 161);
            this.TermInfoGroupBox.Name = "TermInfoGroupBox";
            this.TermInfoGroupBox.Size = new System.Drawing.Size(159, 142);
            this.TermInfoGroupBox.TabIndex = 1;
            this.TermInfoGroupBox.TabStop = false;
            this.TermInfoGroupBox.Text = "Term Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year:";
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.YearComboBox.Location = new System.Drawing.Point(46, 95);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(96, 21);
            this.YearComboBox.TabIndex = 3;
            // 
            // SpringRadioButton
            // 
            this.SpringRadioButton.AutoSize = true;
            this.SpringRadioButton.Location = new System.Drawing.Point(87, 42);
            this.SpringRadioButton.Name = "SpringRadioButton";
            this.SpringRadioButton.Size = new System.Drawing.Size(55, 17);
            this.SpringRadioButton.TabIndex = 2;
            this.SpringRadioButton.Text = "Spring";
            this.SpringRadioButton.UseVisualStyleBackColor = true;
            // 
            // FallRadioButton
            // 
            this.FallRadioButton.AutoSize = true;
            this.FallRadioButton.Checked = true;
            this.FallRadioButton.Location = new System.Drawing.Point(46, 42);
            this.FallRadioButton.Name = "FallRadioButton";
            this.FallRadioButton.Size = new System.Drawing.Size(44, 17);
            this.FallRadioButton.TabIndex = 1;
            this.FallRadioButton.TabStop = true;
            this.FallRadioButton.Text = "Fall ";
            this.FallRadioButton.UseVisualStyleBackColor = true;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Location = new System.Drawing.Point(6, 43);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(34, 13);
            this.TermLabel.TabIndex = 0;
            this.TermLabel.Text = "Term:";
            // 
            // StudentInfoGroupBox
            // 
            this.StudentInfoGroupBox.Controls.Add(this.OutStatePriceLabel);
            this.StudentInfoGroupBox.Controls.Add(this.InStatePriceLabel);
            this.StudentInfoGroupBox.Controls.Add(this.OutOfStateRadioButton);
            this.StudentInfoGroupBox.Controls.Add(this.InStateRadioButton);
            this.StudentInfoGroupBox.Controls.Add(this.EmailAddressTextBox);
            this.StudentInfoGroupBox.Controls.Add(this.LastNameTextBox);
            this.StudentInfoGroupBox.Controls.Add(this.FirstNameTextBox);
            this.StudentInfoGroupBox.Controls.Add(this.label2);
            this.StudentInfoGroupBox.Controls.Add(this.FirstNameLabel);
            this.StudentInfoGroupBox.Controls.Add(this.LastNameLabel);
            this.StudentInfoGroupBox.Controls.Add(this.EmailLabel);
            this.StudentInfoGroupBox.Controls.Add(this.StudentIDMaskedTextBox);
            this.StudentInfoGroupBox.Controls.Add(this.StudentIDLabel);
            this.StudentInfoGroupBox.Location = new System.Drawing.Point(176, 161);
            this.StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            this.StudentInfoGroupBox.Size = new System.Drawing.Size(271, 279);
            this.StudentInfoGroupBox.TabIndex = 2;
            this.StudentInfoGroupBox.TabStop = false;
            this.StudentInfoGroupBox.Text = "Student Information";
            // 
            // OutStatePriceLabel
            // 
            this.OutStatePriceLabel.AutoSize = true;
            this.OutStatePriceLabel.Location = new System.Drawing.Point(203, 242);
            this.OutStatePriceLabel.Name = "OutStatePriceLabel";
            this.OutStatePriceLabel.Size = new System.Drawing.Size(40, 13);
            this.OutStatePriceLabel.TabIndex = 16;
            this.OutStatePriceLabel.Text = "$99.00";
            // 
            // InStatePriceLabel
            // 
            this.InStatePriceLabel.AutoSize = true;
            this.InStatePriceLabel.Location = new System.Drawing.Point(134, 242);
            this.InStatePriceLabel.Name = "InStatePriceLabel";
            this.InStatePriceLabel.Size = new System.Drawing.Size(40, 13);
            this.InStatePriceLabel.TabIndex = 15;
            this.InStatePriceLabel.Text = "$49.00";
            // 
            // OutOfStateRadioButton
            // 
            this.OutOfStateRadioButton.AutoSize = true;
            this.OutOfStateRadioButton.Location = new System.Drawing.Point(176, 208);
            this.OutOfStateRadioButton.Name = "OutOfStateRadioButton";
            this.OutOfStateRadioButton.Size = new System.Drawing.Size(84, 17);
            this.OutOfStateRadioButton.TabIndex = 14;
            this.OutOfStateRadioButton.Text = "Out-Of-State";
            this.OutOfStateRadioButton.UseVisualStyleBackColor = true;
            this.OutOfStateRadioButton.CheckedChanged += new System.EventHandler(this.OutOfStateRadioButton_CheckedChanged);
            // 
            // InStateRadioButton
            // 
            this.InStateRadioButton.AutoSize = true;
            this.InStateRadioButton.Checked = true;
            this.InStateRadioButton.Location = new System.Drawing.Point(108, 208);
            this.InStateRadioButton.Name = "InStateRadioButton";
            this.InStateRadioButton.Size = new System.Drawing.Size(62, 17);
            this.InStateRadioButton.TabIndex = 5;
            this.InStateRadioButton.TabStop = true;
            this.InStateRadioButton.Text = "In-State";
            this.InStateRadioButton.UseVisualStyleBackColor = true;
            this.InStateRadioButton.CheckedChanged += new System.EventHandler(this.InStateRadioButton_CheckedChanged);
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(108, 162);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(137, 20);
            this.EmailAddressTextBox.TabIndex = 13;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(108, 122);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.LastNameTextBox.TabIndex = 12;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(108, 83);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.FirstNameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Residence Status:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 83);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 122);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(6, 165);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(76, 13);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email Address:";
            // 
            // StudentIDMaskedTextBox
            // 
            this.StudentIDMaskedTextBox.Location = new System.Drawing.Point(108, 36);
            this.StudentIDMaskedTextBox.Mask = "000-00-0000";
            this.StudentIDMaskedTextBox.Name = "StudentIDMaskedTextBox";
            this.StudentIDMaskedTextBox.Size = new System.Drawing.Size(137, 20);
            this.StudentIDMaskedTextBox.TabIndex = 6;
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(6, 43);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(61, 13);
            this.StudentIDLabel.TabIndex = 5;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // CourseOrderInfoGroupBox
            // 
            this.CourseOrderInfoGroupBox.Controls.Add(this.NumberOfCoursesOutpulLabel);
            this.CourseOrderInfoGroupBox.Controls.Add(this.NumberOfCoursesLabel);
            this.CourseOrderInfoGroupBox.Controls.Add(this.TotalChargeLabel);
            this.CourseOrderInfoGroupBox.Controls.Add(this.TotalLabel);
            this.CourseOrderInfoGroupBox.Controls.Add(this.BegSpanishCheckBox);
            this.CourseOrderInfoGroupBox.Controls.Add(this.BegRussianCheckBox);
            this.CourseOrderInfoGroupBox.Controls.Add(this.BegItalianCheckBox);
            this.CourseOrderInfoGroupBox.Controls.Add(this.BegGermanCheckBox);
            this.CourseOrderInfoGroupBox.Controls.Add(this.BegFrenchCheckBox);
            this.CourseOrderInfoGroupBox.Controls.Add(this.CourseNameLabel);
            this.CourseOrderInfoGroupBox.Location = new System.Drawing.Point(464, 161);
            this.CourseOrderInfoGroupBox.Name = "CourseOrderInfoGroupBox";
            this.CourseOrderInfoGroupBox.Size = new System.Drawing.Size(248, 304);
            this.CourseOrderInfoGroupBox.TabIndex = 3;
            this.CourseOrderInfoGroupBox.TabStop = false;
            this.CourseOrderInfoGroupBox.Text = "Course Order Information";
            // 
            // NumberOfCoursesOutpulLabel
            // 
            this.NumberOfCoursesOutpulLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfCoursesOutpulLabel.Location = new System.Drawing.Point(129, 225);
            this.NumberOfCoursesOutpulLabel.Name = "NumberOfCoursesOutpulLabel";
            this.NumberOfCoursesOutpulLabel.Size = new System.Drawing.Size(109, 23);
            this.NumberOfCoursesOutpulLabel.TabIndex = 14;
            this.NumberOfCoursesOutpulLabel.Click += new System.EventHandler(this.NumberOfCoursesOutpulLabel_Click);
            // 
            // NumberOfCoursesLabel
            // 
            this.NumberOfCoursesLabel.AutoSize = true;
            this.NumberOfCoursesLabel.Location = new System.Drawing.Point(14, 226);
            this.NumberOfCoursesLabel.Name = "NumberOfCoursesLabel";
            this.NumberOfCoursesLabel.Size = new System.Drawing.Size(102, 13);
            this.NumberOfCoursesLabel.TabIndex = 13;
            this.NumberOfCoursesLabel.Text = "Number Of Courses:";
            // 
            // TotalChargeLabel
            // 
            this.TotalChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalChargeLabel.Location = new System.Drawing.Point(129, 265);
            this.TotalChargeLabel.Name = "TotalChargeLabel";
            this.TotalChargeLabel.Size = new System.Drawing.Size(109, 23);
            this.TotalChargeLabel.TabIndex = 12;
            this.TotalChargeLabel.Click += new System.EventHandler(this.TotalChargeLabel_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(14, 266);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(71, 13);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total Charge:";
            // 
            // BegSpanishCheckBox
            // 
            this.BegSpanishCheckBox.AutoSize = true;
            this.BegSpanishCheckBox.Location = new System.Drawing.Point(128, 183);
            this.BegSpanishCheckBox.Name = "BegSpanishCheckBox";
            this.BegSpanishCheckBox.Size = new System.Drawing.Size(114, 17);
            this.BegSpanishCheckBox.TabIndex = 10;
            this.BegSpanishCheckBox.Text = "Beginning Spanish";
            this.BegSpanishCheckBox.UseVisualStyleBackColor = true;
            this.BegSpanishCheckBox.CheckedChanged += new System.EventHandler(this.BegFrenchCheckBox_CheckedChanged);
            // 
            // BegRussianCheckBox
            // 
            this.BegRussianCheckBox.AutoSize = true;
            this.BegRussianCheckBox.Location = new System.Drawing.Point(128, 148);
            this.BegRussianCheckBox.Name = "BegRussianCheckBox";
            this.BegRussianCheckBox.Size = new System.Drawing.Size(114, 17);
            this.BegRussianCheckBox.TabIndex = 9;
            this.BegRussianCheckBox.Text = "Beginning Russian";
            this.BegRussianCheckBox.UseVisualStyleBackColor = true;
            this.BegRussianCheckBox.CheckedChanged += new System.EventHandler(this.BegFrenchCheckBox_CheckedChanged);
            // 
            // BegItalianCheckBox
            // 
            this.BegItalianCheckBox.AutoSize = true;
            this.BegItalianCheckBox.Location = new System.Drawing.Point(129, 114);
            this.BegItalianCheckBox.Name = "BegItalianCheckBox";
            this.BegItalianCheckBox.Size = new System.Drawing.Size(104, 17);
            this.BegItalianCheckBox.TabIndex = 8;
            this.BegItalianCheckBox.Text = "Beginning Italian";
            this.BegItalianCheckBox.UseVisualStyleBackColor = true;
            this.BegItalianCheckBox.CheckedChanged += new System.EventHandler(this.BegFrenchCheckBox_CheckedChanged);
            // 
            // BegGermanCheckBox
            // 
            this.BegGermanCheckBox.AutoSize = true;
            this.BegGermanCheckBox.Location = new System.Drawing.Point(129, 75);
            this.BegGermanCheckBox.Name = "BegGermanCheckBox";
            this.BegGermanCheckBox.Size = new System.Drawing.Size(113, 17);
            this.BegGermanCheckBox.TabIndex = 7;
            this.BegGermanCheckBox.Text = "Beginning German";
            this.BegGermanCheckBox.UseVisualStyleBackColor = true;
            this.BegGermanCheckBox.CheckedChanged += new System.EventHandler(this.BegFrenchCheckBox_CheckedChanged);
            // 
            // BegFrenchCheckBox
            // 
            this.BegFrenchCheckBox.AutoSize = true;
            this.BegFrenchCheckBox.Location = new System.Drawing.Point(129, 39);
            this.BegFrenchCheckBox.Name = "BegFrenchCheckBox";
            this.BegFrenchCheckBox.Size = new System.Drawing.Size(109, 17);
            this.BegFrenchCheckBox.TabIndex = 6;
            this.BegFrenchCheckBox.Text = "Beginning French";
            this.BegFrenchCheckBox.UseVisualStyleBackColor = true;
            this.BegFrenchCheckBox.CheckedChanged += new System.EventHandler(this.BegFrenchCheckBox_CheckedChanged);
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(7, 38);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(74, 13);
            this.CourseNameLabel.TabIndex = 5;
            this.CourseNameLabel.Text = "Course Name:";
            // 
            // PaymentInfoGroupBox
            // 
            this.PaymentInfoGroupBox.Controls.Add(this.ExpirationDateLabel);
            this.PaymentInfoGroupBox.Controls.Add(this.ExpirationDateMaskedTextBox);
            this.PaymentInfoGroupBox.Controls.Add(this.CreditCardNumberMaskedBox);
            this.PaymentInfoGroupBox.Controls.Add(this.CreditCardNumberLabel);
            this.PaymentInfoGroupBox.Controls.Add(this.VisaCreditRadioButton);
            this.PaymentInfoGroupBox.Controls.Add(this.MasterCardButton);
            this.PaymentInfoGroupBox.Controls.Add(this.PaymentTypeLabel);
            this.PaymentInfoGroupBox.Location = new System.Drawing.Point(728, 161);
            this.PaymentInfoGroupBox.Name = "PaymentInfoGroupBox";
            this.PaymentInfoGroupBox.Size = new System.Drawing.Size(241, 191);
            this.PaymentInfoGroupBox.TabIndex = 4;
            this.PaymentInfoGroupBox.TabStop = false;
            this.PaymentInfoGroupBox.Text = "Payment Information";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Location = new System.Drawing.Point(8, 143);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(82, 13);
            this.ExpirationDateLabel.TabIndex = 19;
            this.ExpirationDateLabel.Text = "Expiration Date:";
            // 
            // ExpirationDateMaskedTextBox
            // 
            this.ExpirationDateMaskedTextBox.Location = new System.Drawing.Point(116, 140);
            this.ExpirationDateMaskedTextBox.Mask = "00/00/0000";
            this.ExpirationDateMaskedTextBox.Name = "ExpirationDateMaskedTextBox";
            this.ExpirationDateMaskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.ExpirationDateMaskedTextBox.TabIndex = 18;
            this.ExpirationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // CreditCardNumberMaskedBox
            // 
            this.CreditCardNumberMaskedBox.Location = new System.Drawing.Point(116, 98);
            this.CreditCardNumberMaskedBox.Mask = "0000-0000-0000-0000";
            this.CreditCardNumberMaskedBox.Name = "CreditCardNumberMaskedBox";
            this.CreditCardNumberMaskedBox.Size = new System.Drawing.Size(112, 20);
            this.CreditCardNumberMaskedBox.TabIndex = 17;
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(6, 98);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(102, 13);
            this.CreditCardNumberLabel.TabIndex = 16;
            this.CreditCardNumberLabel.Text = "Credit Card Number:";
            // 
            // VisaCreditRadioButton
            // 
            this.VisaCreditRadioButton.AutoSize = true;
            this.VisaCreditRadioButton.Location = new System.Drawing.Point(116, 63);
            this.VisaCreditRadioButton.Name = "VisaCreditRadioButton";
            this.VisaCreditRadioButton.Size = new System.Drawing.Size(75, 17);
            this.VisaCreditRadioButton.TabIndex = 15;
            this.VisaCreditRadioButton.Text = "Visa Credit";
            this.VisaCreditRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasterCardButton
            // 
            this.MasterCardButton.AutoSize = true;
            this.MasterCardButton.Checked = true;
            this.MasterCardButton.Location = new System.Drawing.Point(116, 40);
            this.MasterCardButton.Name = "MasterCardButton";
            this.MasterCardButton.Size = new System.Drawing.Size(79, 17);
            this.MasterCardButton.TabIndex = 15;
            this.MasterCardButton.TabStop = true;
            this.MasterCardButton.Text = "MasterCard";
            this.MasterCardButton.UseVisualStyleBackColor = true;
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Location = new System.Drawing.Point(6, 42);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.PaymentTypeLabel.TabIndex = 13;
            this.PaymentTypeLabel.Text = "Payment Type:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(176, 488);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 43);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(440, 488);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(109, 43);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(703, 488);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 43);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 543);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PaymentInfoGroupBox);
            this.Controls.Add(this.CourseOrderInfoGroupBox);
            this.Controls.Add(this.StudentInfoGroupBox);
            this.Controls.Add(this.TermInfoGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Arts Institute";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TermInfoGroupBox.ResumeLayout(false);
            this.TermInfoGroupBox.PerformLayout();
            this.StudentInfoGroupBox.ResumeLayout(false);
            this.StudentInfoGroupBox.PerformLayout();
            this.CourseOrderInfoGroupBox.ResumeLayout(false);
            this.CourseOrderInfoGroupBox.PerformLayout();
            this.PaymentInfoGroupBox.ResumeLayout(false);
            this.PaymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox TermInfoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.RadioButton SpringRadioButton;
        private System.Windows.Forms.RadioButton FallRadioButton;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.GroupBox StudentInfoGroupBox;
        private System.Windows.Forms.RadioButton OutOfStateRadioButton;
        private System.Windows.Forms.RadioButton InStateRadioButton;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.MaskedTextBox StudentIDMaskedTextBox;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.GroupBox CourseOrderInfoGroupBox;
        private System.Windows.Forms.Label TotalChargeLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.CheckBox BegSpanishCheckBox;
        private System.Windows.Forms.CheckBox BegRussianCheckBox;
        private System.Windows.Forms.CheckBox BegItalianCheckBox;
        private System.Windows.Forms.CheckBox BegGermanCheckBox;
        private System.Windows.Forms.CheckBox BegFrenchCheckBox;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.GroupBox PaymentInfoGroupBox;
        private System.Windows.Forms.RadioButton MasterCardButton;
        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.MaskedTextBox ExpirationDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CreditCardNumberMaskedBox;
        private System.Windows.Forms.Label CreditCardNumberLabel;
        private System.Windows.Forms.RadioButton VisaCreditRadioButton;
        private System.Windows.Forms.Label NumberOfCoursesOutpulLabel;
        private System.Windows.Forms.Label NumberOfCoursesLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label OutStatePriceLabel;
        private System.Windows.Forms.Label InStatePriceLabel;
    }
}

