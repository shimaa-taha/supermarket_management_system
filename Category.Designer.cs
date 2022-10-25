
namespace project_sw_visual
{
    partial class categoryform
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sellerlabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.CategoryDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.Logoutlabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(586, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE CATEGORY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 768);
            this.dataGridView1.TabIndex = 28;
            // 
            // Sellerlabel
            // 
            this.Sellerlabel.AutoSize = true;
            this.Sellerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sellerlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Sellerlabel.Location = new System.Drawing.Point(60, 166);
            this.Sellerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sellerlabel.Name = "Sellerlabel";
            this.Sellerlabel.Size = new System.Drawing.Size(92, 30);
            this.Sellerlabel.TabIndex = 41;
            this.Sellerlabel.Text = "Sellers";
            this.Sellerlabel.Click += new System.EventHandler(this.Sellerlabel_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Control;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(574, 515);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 52);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.Control;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(422, 515);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(112, 52);
            this.Edit.TabIndex = 39;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Add.Location = new System.Drawing.Point(274, 515);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 52);
            this.Add.TabIndex = 38;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDescription.Location = new System.Drawing.Point(508, 414);
            this.CategoryDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(196, 28);
            this.CategoryDescription.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(316, 414);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 32);
            this.label11.TabIndex = 36;
            this.label11.Text = "DESCRIPTION";
            // 
            // CategoryName
            // 
            this.CategoryName.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(508, 332);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(196, 28);
            this.CategoryName.TabIndex = 35;
            // 
            // CategoryId
            // 
            this.CategoryId.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryId.Location = new System.Drawing.Point(508, 260);
            this.CategoryId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Size = new System.Drawing.Size(196, 28);
            this.CategoryId.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(316, 329);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 32);
            this.label12.TabIndex = 33;
            this.label12.Text = "NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(316, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 32);
            this.label13.TabIndex = 32;
            this.label13.Text = "ID";
            // 
            // CatDGV
            // 
            this.CatDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(724, 142);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(682, 671);
            this.CatDGV.TabIndex = 45;
            this.CatDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Exitlabel.Location = new System.Drawing.Point(1456, 17);
            this.Exitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(31, 29);
            this.Exitlabel.TabIndex = 46;
            this.Exitlabel.Text = "X";
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // Logoutlabel
            // 
            this.Logoutlabel.AutoSize = true;
            this.Logoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Logoutlabel.Location = new System.Drawing.Point(60, 708);
            this.Logoutlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logoutlabel.Name = "Logoutlabel";
            this.Logoutlabel.Size = new System.Drawing.Size(87, 29);
            this.Logoutlabel.TabIndex = 48;
            this.Logoutlabel.Text = "Logout";
            this.Logoutlabel.Click += new System.EventHandler(this.Logoutlabel_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ProductLabel.Location = new System.Drawing.Point(60, 222);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(101, 30);
            this.ProductLabel.TabIndex = 49;
            this.ProductLabel.Text = "Product";
            this.ProductLabel.Click += new System.EventHandler(this.ProductLabel_Click);
            // 
            // categoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1528, 869);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.Logoutlabel);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.Sellerlabel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CategoryDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.CategoryId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "categoryform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryform";
            this.Load += new System.EventHandler(this.categoryform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Sellerlabel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox CategoryDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.TextBox CategoryId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Label Exitlabel;
        private System.Windows.Forms.Label Logoutlabel;
        private System.Windows.Forms.Label ProductLabel;
    }
}