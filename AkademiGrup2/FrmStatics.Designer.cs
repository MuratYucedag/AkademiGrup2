
namespace AkademiGrup2
{
    partial class FrmStatics
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
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxStockProduct = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kategori Sayısı:";
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(217, 31);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(30, 23);
            this.lblCategoryCount.TabIndex = 1;
            this.lblCategoryCount.Text = "00";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(217, 72);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(30, 23);
            this.lblProductCount.TabIndex = 3;
            this.lblProductCount.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Ürün Sayısı:";
            // 
            // lblCityCount
            // 
            this.lblCityCount.AutoSize = true;
            this.lblCityCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCityCount.Location = new System.Drawing.Point(217, 116);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(30, 23);
            this.lblCityCount.TabIndex = 5;
            this.lblCityCount.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşteri Şehir Sayısı:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCount.Location = new System.Drawing.Point(217, 163);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(30, 23);
            this.lblTotalCount.TabIndex = 7;
            this.lblTotalCount.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toplam Stok Sayısı:";
            // 
            // lblMaxStockProduct
            // 
            this.lblMaxStockProduct.AutoSize = true;
            this.lblMaxStockProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxStockProduct.Location = new System.Drawing.Point(217, 208);
            this.lblMaxStockProduct.Name = "lblMaxStockProduct";
            this.lblMaxStockProduct.Size = new System.Drawing.Size(30, 23);
            this.lblMaxStockProduct.TabIndex = 9;
            this.lblMaxStockProduct.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "En Yüksek Stoğa Sahip Ürün:";
            // 
            // FrmStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 279);
            this.Controls.Add(this.lblMaxStockProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCityCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCategoryCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStatics";
            this.Text = "FrmStatics";
            this.Load += new System.EventHandler(this.FrmStatics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxStockProduct;
        private System.Windows.Forms.Label label9;
    }
}