
namespace templet
{
    partial class Exit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.Logoutlabel = new System.Windows.Forms.Label();
            this.Sellerslabel = new System.Windows.Forms.Label();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-296, -85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "PRICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "CATEGORY";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(1005, 105);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(129, 45);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "meat"});
            this.comboBox1.Location = new System.Drawing.Point(700, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 40);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Beverage";
            // 
            // CategoryCb
            // 
            this.CategoryCb.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(182, 351);
            this.CategoryCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(198, 40);
            this.CategoryCb.TabIndex = 10;
            this.CategoryCb.Text = "Beverage";
            // 
            // ProductId
            // 
            this.ProductId.BackColor = System.Drawing.SystemColors.Control;
            this.ProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.Location = new System.Drawing.Point(184, 123);
            this.ProductId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(196, 28);
            this.ProductId.TabIndex = 14;
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.SystemColors.Control;
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(184, 171);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(196, 28);
            this.ProductName.TabIndex = 15;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.Location = new System.Drawing.Point(184, 223);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(196, 28);
            this.ProductQuantity.TabIndex = 16;
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.Location = new System.Drawing.Point(184, 277);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(196, 28);
            this.ProductPrice.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ProductQuantity);
            this.panel1.Controls.Add(this.CategoryCb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Location = new System.Drawing.Point(194, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 785);
            this.panel1.TabIndex = 19;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(268, 480);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(124, 52);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EditButton.Location = new System.Drawing.Point(147, 480);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 52);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(26, 480);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 52);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(417, 163);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(900, 602);
            this.ProdDGV.TabIndex = 8;
            this.ProdDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // Logoutlabel
            // 
            this.Logoutlabel.AutoSize = true;
            this.Logoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Logoutlabel.Location = new System.Drawing.Point(18, 723);
            this.Logoutlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logoutlabel.Name = "Logoutlabel";
            this.Logoutlabel.Size = new System.Drawing.Size(87, 29);
            this.Logoutlabel.TabIndex = 20;
            this.Logoutlabel.Text = "Logout";
            this.Logoutlabel.Click += new System.EventHandler(this.Logoutlabel_Click);
            // 
            // Sellerslabel
            // 
            this.Sellerslabel.AutoSize = true;
            this.Sellerslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sellerslabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Sellerslabel.Location = new System.Drawing.Point(18, 174);
            this.Sellerslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sellerslabel.Name = "Sellerslabel";
            this.Sellerslabel.Size = new System.Drawing.Size(92, 30);
            this.Sellerslabel.TabIndex = 18;
            this.Sellerslabel.Text = "Sellers";
            this.Sellerslabel.Click += new System.EventHandler(this.Sellerslabel_Click);
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Exitlabel.Location = new System.Drawing.Point(1420, 18);
            this.Exitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(31, 29);
            this.Exitlabel.TabIndex = 21;
            this.Exitlabel.Text = "X";
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Categories.Location = new System.Drawing.Point(18, 246);
            this.Categories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(137, 30);
            this.Categories.TabIndex = 23;
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1528, 869);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.Sellerslabel);
            this.Controls.Add(this.Logoutlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Exit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.Label Logoutlabel;
        private System.Windows.Forms.Label Sellerslabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Exitlabel;
        private System.Windows.Forms.Label Categories;
    }
}

