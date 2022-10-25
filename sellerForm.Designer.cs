
namespace project_sw_visual
{
    partial class sellerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerPassword = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditSeller = new System.Windows.Forms.Button();
            this.AddSeller = new System.Windows.Forms.Button();
            this.SellerDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SellerAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SellerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.LogoutLable = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.SellerPassword);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.EditSeller);
            this.panel1.Controls.Add(this.AddSeller);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SellerPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SellerAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SellerId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(204, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 789);
            this.panel1.TabIndex = 20;
            // 
            // SellerPassword
            // 
            this.SellerPassword.BackColor = System.Drawing.SystemColors.Control;
            this.SellerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerPassword.Location = new System.Drawing.Point(184, 342);
            this.SellerPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerPassword.Name = "SellerPassword";
            this.SellerPassword.Size = new System.Drawing.Size(196, 28);
            this.SellerPassword.TabIndex = 21;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(268, 480);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 52);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditSeller
            // 
            this.EditSeller.BackColor = System.Drawing.SystemColors.Control;
            this.EditSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSeller.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EditSeller.Location = new System.Drawing.Point(147, 480);
            this.EditSeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSeller.Name = "EditSeller";
            this.EditSeller.Size = new System.Drawing.Size(112, 52);
            this.EditSeller.TabIndex = 19;
            this.EditSeller.Text = "EDIT";
            this.EditSeller.UseVisualStyleBackColor = false;
            this.EditSeller.Click += new System.EventHandler(this.EditSeller_Click);
            // 
            // AddSeller
            // 
            this.AddSeller.BackColor = System.Drawing.SystemColors.Control;
            this.AddSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSeller.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddSeller.Location = new System.Drawing.Point(26, 480);
            this.AddSeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSeller.Name = "AddSeller";
            this.AddSeller.Size = new System.Drawing.Size(112, 52);
            this.AddSeller.TabIndex = 18;
            this.AddSeller.Text = "ADD";
            this.AddSeller.UseVisualStyleBackColor = false;
            this.AddSeller.Click += new System.EventHandler(this.AddSeller_Click);
            // 
            // SellerDGV
            // 
            this.SellerDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerDGV.Location = new System.Drawing.Point(406, 123);
            this.SellerDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersWidth = 62;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(860, 642);
            this.SellerDGV.TabIndex = 8;
            this.SellerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // SellerPhone
            // 
            this.SellerPhone.BackColor = System.Drawing.SystemColors.Control;
            this.SellerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerPhone.Location = new System.Drawing.Point(184, 277);
            this.SellerPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerPhone.Name = "SellerPhone";
            this.SellerPhone.Size = new System.Drawing.Size(196, 28);
            this.SellerPhone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "PASSWORD";
            // 
            // SellerAge
            // 
            this.SellerAge.BackColor = System.Drawing.SystemColors.Control;
            this.SellerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAge.Location = new System.Drawing.Point(184, 223);
            this.SellerAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.Size = new System.Drawing.Size(196, 28);
            this.SellerAge.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // SellerName
            // 
            this.SellerName.BackColor = System.Drawing.SystemColors.Control;
            this.SellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.Location = new System.Drawing.Point(184, 171);
            this.SellerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(196, 28);
            this.SellerName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "PHONE";
            // 
            // SellerId
            // 
            this.SellerId.BackColor = System.Drawing.SystemColors.Control;
            this.SellerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerId.Location = new System.Drawing.Point(184, 123);
            this.SellerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerId.Name = "SellerId";
            this.SellerId.Size = new System.Drawing.Size(196, 28);
            this.SellerId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "AGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLERS";
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Exitlabel.Location = new System.Drawing.Point(1401, 9);
            this.Exitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(31, 29);
            this.Exitlabel.TabIndex = 22;
            this.Exitlabel.Text = "X";
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // LogoutLable
            // 
            this.LogoutLable.AutoSize = true;
            this.LogoutLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLable.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LogoutLable.Location = new System.Drawing.Point(38, 663);
            this.LogoutLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLable.Name = "LogoutLable";
            this.LogoutLable.Size = new System.Drawing.Size(87, 29);
            this.LogoutLable.TabIndex = 27;
            this.LogoutLable.Text = "Logout";
            this.LogoutLable.Click += new System.EventHandler(this.LogoutLable_Click);
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Products.Location = new System.Drawing.Point(38, 128);
            this.Products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(108, 29);
            this.Products.TabIndex = 28;
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Categories.Location = new System.Drawing.Point(38, 188);
            this.Categories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(131, 29);
            this.Categories.TabIndex = 29;
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // sellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1528, 869);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.LogoutLable);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellerForm";
            this.Load += new System.EventHandler(this.sellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditSeller;
        private System.Windows.Forms.Button AddSeller;
        private System.Windows.Forms.DataGridView SellerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellerPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SellerAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SellerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SellerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Exitlabel;
        private System.Windows.Forms.TextBox SellerPassword;
        private System.Windows.Forms.Label LogoutLable;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Label Categories;
    }
}