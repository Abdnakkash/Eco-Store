namespace EcoStore
{
    partial class EcoStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcoStore));
            UserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            password = new TextBox();
            LogInBt = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Location = new Point(322, 206);
            UserName.Name = "UserName";
            UserName.Size = new Size(161, 27);
            UserName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(350, 180);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "UserName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(350, 236);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // password
            // 
            password.Location = new Point(322, 262);
            password.Name = "password";
            password.Size = new Size(161, 27);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // LogInBt
            // 
            LogInBt.BackColor = Color.White;
            LogInBt.Location = new Point(344, 334);
            LogInBt.Name = "LogInBt";
            LogInBt.Size = new Size(94, 29);
            LogInBt.TabIndex = 5;
            LogInBt.Text = "LogIn";
            LogInBt.UseVisualStyleBackColor = false;
            LogInBt.Click += LogInBt_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(720, 421);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "EcoStore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(333, 292);
            label4.Name = "label4";
            label4.Size = new Size(115, 12);
            label4.TabIndex = 7;
            label4.Text = "You don't have account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = SystemColors.ButtonHighlight;
            linkLabel2.LinkColor = Color.WhiteSmoke;
            linkLabel2.Location = new Point(350, 304);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(83, 15);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register Here..";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // EcoStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(LogInBt);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserName);
            Name = "EcoStore";
            Text = "EcoStore";
            Load += EcoStore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private Label label2;
        private Label label3;
        private TextBox password;
        private Button LogInBt;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel linkLabel2;
    }
}