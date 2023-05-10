namespace EcoStore
{
    partial class Admin
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
            tab = new TabControl();
            Grocery1 = new TabPage();
            ItemName = new TextBox();
            label8 = new Label();
            AddQ = new NumericUpDown();
            Refresh = new Button();
            Remove = new TextBox();
            label7 = new Label();
            EditBt = new Button();
            ChangeQ = new TextBox();
            label6 = new Label();
            RemoveBt = new Button();
            label5 = new Label();
            label4 = new Label();
            BtAdd = new Button();
            AddCategory = new TextBox();
            label3 = new Label();
            label2 = new Label();
            AddItem = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            Customers = new TabPage();
            BtLogOut = new Button();
            tab.SuspendLayout();
            Grocery1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddQ).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(Grocery1);
            tab.Controls.Add(Customers);
            tab.Location = new Point(12, 30);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(776, 373);
            tab.TabIndex = 0;
            // 
            // Grocery1
            // 
            Grocery1.BackColor = Color.White;
            Grocery1.Controls.Add(ItemName);
            Grocery1.Controls.Add(label8);
            Grocery1.Controls.Add(AddQ);
            Grocery1.Controls.Add(Refresh);
            Grocery1.Controls.Add(Remove);
            Grocery1.Controls.Add(label7);
            Grocery1.Controls.Add(EditBt);
            Grocery1.Controls.Add(ChangeQ);
            Grocery1.Controls.Add(label6);
            Grocery1.Controls.Add(RemoveBt);
            Grocery1.Controls.Add(label5);
            Grocery1.Controls.Add(label4);
            Grocery1.Controls.Add(BtAdd);
            Grocery1.Controls.Add(AddCategory);
            Grocery1.Controls.Add(label3);
            Grocery1.Controls.Add(label2);
            Grocery1.Controls.Add(AddItem);
            Grocery1.Controls.Add(label1);
            Grocery1.Controls.Add(listView1);
            Grocery1.ForeColor = Color.Black;
            Grocery1.Location = new Point(4, 29);
            Grocery1.Name = "Grocery1";
            Grocery1.Padding = new Padding(3);
            Grocery1.Size = new Size(768, 340);
            Grocery1.TabIndex = 0;
            Grocery1.Text = "Grocery";
            // 
            // ItemName
            // 
            ItemName.Location = new Point(214, 63);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(125, 27);
            ItemName.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 40);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 18;
            label8.Text = "Item Name :";
            // 
            // AddQ
            // 
            AddQ.Location = new Point(15, 170);
            AddQ.Name = "AddQ";
            AddQ.Size = new Size(125, 27);
            AddQ.TabIndex = 17;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(111, 305);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 29);
            Refresh.TabIndex = 16;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(213, 219);
            Remove.Name = "Remove";
            Remove.Size = new Size(125, 27);
            Remove.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 196);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 14;
            label7.Text = "Remove Item :";
            // 
            // EditBt
            // 
            EditBt.Location = new Point(224, 149);
            EditBt.Name = "EditBt";
            EditBt.Size = new Size(94, 29);
            EditBt.TabIndex = 13;
            EditBt.Text = "Update";
            EditBt.UseVisualStyleBackColor = true;
            EditBt.Click += EditBt_Click;
            // 
            // ChangeQ
            // 
            ChangeQ.Location = new Point(214, 116);
            ChangeQ.Name = "ChangeQ";
            ChangeQ.Size = new Size(125, 27);
            ChangeQ.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 93);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 11;
            label6.Text = "Change Quantity :";
            // 
            // RemoveBt
            // 
            RemoveBt.Location = new Point(224, 252);
            RemoveBt.Name = "RemoveBt";
            RemoveBt.Size = new Size(94, 29);
            RemoveBt.TabIndex = 10;
            RemoveBt.Text = "Remove";
            RemoveBt.UseVisualStyleBackColor = true;
            RemoveBt.Click += RemoveBt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 146);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Quantity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 146);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // BtAdd
            // 
            BtAdd.Location = new Point(24, 214);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(94, 29);
            BtAdd.TabIndex = 6;
            BtAdd.Text = "Add";
            BtAdd.UseVisualStyleBackColor = true;
            BtAdd.Click += BtAdd_Click;
            // 
            // AddCategory
            // 
            AddCategory.Location = new Point(15, 116);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(125, 27);
            AddCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 93);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Category :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 40);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Add Item :";
            // 
            // AddItem
            // 
            AddItem.Location = new Point(15, 63);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(125, 27);
            AddItem.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(533, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "Grocery Item :";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(395, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(367, 294);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Customers
            // 
            Customers.Location = new Point(4, 29);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(768, 340);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // BtLogOut
            // 
            BtLogOut.Location = new Point(349, 409);
            BtLogOut.Name = "BtLogOut";
            BtLogOut.Size = new Size(94, 29);
            BtLogOut.TabIndex = 1;
            BtLogOut.Text = "Log Out";
            BtLogOut.UseVisualStyleBackColor = true;
            BtLogOut.Click += BtLogOut_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BtLogOut);
            Controls.Add(tab);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            tab.ResumeLayout(false);
            Grocery1.ResumeLayout(false);
            Grocery1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddQ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage Grocery1;
        private TabPage Customers;
        private Label label1;
        private Button Refresh;
        private TextBox Remove;
        private Label label7;
        private Button EditBt;
        private TextBox ChangeQ;
        private Label label6;
        private Button RemoveBt;
        private Label label5;
        private Label label4;
        private Button BtAdd;
        private TextBox AddCategory;
        private Label label3;
        private Label label2;
        private TextBox AddItem;
        private ListView listView1;
        private Button BtLogOut;
        private NumericUpDown AddQ;
        private TextBox ItemName;
        private Label label8;
    }
}