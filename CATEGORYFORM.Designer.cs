
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CatDelete = new System.Windows.Forms.Button();
            this.CatEdit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CatDesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CatName = new System.Windows.Forms.TextBox();
            this.CatId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE CATEGORY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(966, 618);
            this.dataGridView1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(134, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sellers";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(117, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 42;
            this.label8.Text = "products";
            // 
            // CatDelete
            // 
            this.CatDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CatDelete.Location = new System.Drawing.Point(580, 385);
            this.CatDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDelete.Name = "CatDelete";
            this.CatDelete.Size = new System.Drawing.Size(112, 52);
            this.CatDelete.TabIndex = 40;
            this.CatDelete.Text = "DELETE";
            this.CatDelete.UseVisualStyleBackColor = true;
            this.CatDelete.Click += new System.EventHandler(this.CatDelete_Click_1);
            // 
            // CatEdit
            // 
            this.CatEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatEdit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CatEdit.Location = new System.Drawing.Point(459, 385);
            this.CatEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatEdit.Name = "CatEdit";
            this.CatEdit.Size = new System.Drawing.Size(112, 52);
            this.CatEdit.TabIndex = 39;
            this.CatEdit.Text = "EDIT";
            this.CatEdit.UseVisualStyleBackColor = true;
            this.CatEdit.Click += new System.EventHandler(this.CatEdit_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(322, 385);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 52);
            this.button4.TabIndex = 38;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CatDesc
            // 
            this.CatDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDesc.Location = new System.Drawing.Point(486, 303);
            this.CatDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDesc.Name = "CatDesc";
            this.CatDesc.Size = new System.Drawing.Size(196, 28);
            this.CatDesc.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(316, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 32);
            this.label11.TabIndex = 36;
            this.label11.Text = "DESCRIPTION";
            // 
            // CatName
            // 
            this.CatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatName.Location = new System.Drawing.Point(486, 220);
            this.CatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatName.Name = "CatName";
            this.CatName.Size = new System.Drawing.Size(196, 28);
            this.CatName.TabIndex = 35;
            // 
            // CatId
            // 
            this.CatId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatId.Location = new System.Drawing.Point(486, 143);
            this.CatId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatId.Name = "CatId";
            this.CatId.Size = new System.Drawing.Size(196, 28);
            this.CatId.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(336, 217);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 32);
            this.label12.TabIndex = 33;
            this.label12.Text = "NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(352, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 32);
            this.label13.TabIndex = 32;
            this.label13.Text = "ID";
            // 
            // CatDGV
            // 
            this.CatDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(740, 142);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.Size = new System.Drawing.Size(506, 546);
            this.CatDGV.TabIndex = 45;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1190, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProdButton
            // 
            this.ProdButton.Location = new System.Drawing.Point(123, 402);
            this.ProdButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdButton.Name = "ProdButton";
            this.ProdButton.Size = new System.Drawing.Size(112, 35);
            this.ProdButton.TabIndex = 47;
            this.ProdButton.Text = "Products";
            this.ProdButton.UseVisualStyleBackColor = true;
            this.ProdButton.Click += new System.EventHandler(this.ProdButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(118, 601);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Logout";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // categoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1281, 777);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProdButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CatDelete);
            this.Controls.Add(this.CatEdit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CatDesc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CatName);
            this.Controls.Add(this.CatId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "categoryform";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CatDelete;
        private System.Windows.Forms.Button CatEdit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CatDesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CatName;
        private System.Windows.Forms.TextBox CatId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProdButton;
        private System.Windows.Forms.Label label3;
    }
}