namespace EcoStore
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            FirstName = new TextBox();
            label = new Label();
            LastName = new TextBox();
            label3 = new Label();
            UserName = new TextBox();
            label4 = new Label();
            Email = new TextBox();
            label5 = new Label();
            Password = new TextBox();
            label6 = new Label();
            NumberPhone = new TextBox();
            label7 = new Label();
            Address = new TextBox();
            label8 = new Label();
            ComboBox = new ComboBox();
            label9 = new Label();
            RegisterBt = new Button();
            DateOfBirth = new DateTimePicker();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 37);
            label1.TabIndex = 0;
            label1.Text = "Create New Account ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(55, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name : ";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(64, 98);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(181, 27);
            FirstName.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Location = new Point(55, 142);
            label.Name = "label";
            label.Size = new Size(90, 20);
            label.TabIndex = 3;
            label.Text = "Last Name : ";
            // 
            // LastName
            // 
            LastName.Location = new Point(64, 165);
            LastName.Name = "LastName";
            LastName.Size = new Size(181, 27);
            LastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(56, 209);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "UserName : ";
            // 
            // UserName
            // 
            UserName.Location = new Point(64, 232);
            UserName.Name = "UserName";
            UserName.Size = new Size(181, 27);
            UserName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(56, 276);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Email :";
            // 
            // Email
            // 
            Email.Location = new Point(64, 299);
            Email.Name = "Email";
            Email.Size = new Size(181, 27);
            Email.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(434, 75);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 9;
            label5.Text = "Password :";
            // 
            // Password
            // 
            Password.Location = new Point(446, 98);
            Password.Name = "Password";
            Password.Size = new Size(181, 27);
            Password.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(434, 142);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 11;
            label6.Text = "Number Phone :";
            // 
            // NumberPhone
            // 
            NumberPhone.Location = new Point(446, 165);
            NumberPhone.Name = "NumberPhone";
            NumberPhone.Size = new Size(181, 27);
            NumberPhone.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(434, 209);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 13;
            label7.Text = "Address :";
            // 
            // Address
            // 
            Address.Location = new Point(446, 232);
            Address.Name = "Address";
            Address.Size = new Size(181, 27);
            Address.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(434, 276);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "Country :";
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(446, 299);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(181, 28);
            ComboBox.TabIndex = 16;
            ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(55, 344);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 17;
            label9.Text = "Date Of Birth :";
            // 
            // RegisterBt
            // 
            RegisterBt.BackColor = Color.White;
            RegisterBt.ForeColor = SystemColors.ActiveCaptionText;
            RegisterBt.Location = new Point(503, 399);
            RegisterBt.Name = "RegisterBt";
            RegisterBt.Size = new Size(111, 39);
            RegisterBt.TabIndex = 19;
            RegisterBt.Text = "Register";
            RegisterBt.UseVisualStyleBackColor = false;
            RegisterBt.Click += RegisterBt_Click;
            // 
            // DateOfBirth
            // 
            DateOfBirth.Location = new Point(64, 367);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(250, 27);
            DateOfBirth.TabIndex = 20;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.ForeColor = Color.Black;
            Back.Location = new Point(650, 399);
            Back.Name = "Back";
            Back.Size = new Size(111, 39);
            Back.TabIndex = 21;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(DateOfBirth);
            Controls.Add(RegisterBt);
            Controls.Add(label9);
            Controls.Add(ComboBox);
            Controls.Add(label8);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(NumberPhone);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(label5);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(label);
            Controls.Add(FirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FirstName;
        private Label label;
        private TextBox LastName;
        private Label label3;
        private TextBox UserName;
        private Label label4;
        private TextBox Email;
        private Label label5;
        private TextBox Password;
        private Label label6;
        private TextBox NumberPhone;
        private Label label7;
        private TextBox Address;
        private Label label8;
        private ComboBox ComboBox;
        private Label label9;
        private Button RegisterBt;
        private DateTimePicker DateOfBirth;
        private Button Back;
    }
}