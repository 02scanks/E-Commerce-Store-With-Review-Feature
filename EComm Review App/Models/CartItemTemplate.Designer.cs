namespace EComm_Review_App.Models
{
    partial class CartItemTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            TotalPrice = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            TotalQuantity = new ReaLTaiizor.Controls.DungeonLabel();
            ProductName = new ReaLTaiizor.Controls.DungeonLabel();
            ProductImage = new PictureBox();
            poisonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // poisonPanel2
            // 
            poisonPanel2.Controls.Add(TotalPrice);
            poisonPanel2.Controls.Add(dungeonLabel3);
            poisonPanel2.Controls.Add(dungeonLabel2);
            poisonPanel2.Controls.Add(TotalQuantity);
            poisonPanel2.Controls.Add(ProductName);
            poisonPanel2.Controls.Add(ProductImage);
            poisonPanel2.Dock = DockStyle.Top;
            poisonPanel2.HorizontalScrollbarBarColor = true;
            poisonPanel2.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel2.HorizontalScrollbarSize = 10;
            poisonPanel2.Location = new Point(0, 0);
            poisonPanel2.Name = "poisonPanel2";
            poisonPanel2.Size = new Size(298, 76);
            poisonPanel2.TabIndex = 4;
            poisonPanel2.VerticalScrollbarBarColor = true;
            poisonPanel2.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel2.VerticalScrollbarSize = 10;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BackColor = Color.Transparent;
            TotalPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPrice.ForeColor = Color.FromArgb(76, 76, 77);
            TotalPrice.Location = new Point(214, 50);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(30, 17);
            TotalPrice.TabIndex = 7;
            TotalPrice.Text = "$---";
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(214, 37);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(35, 13);
            dungeonLabel3.TabIndex = 6;
            dungeonLabel3.Text = "Total:";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(93, 38);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(29, 13);
            dungeonLabel2.TabIndex = 5;
            dungeonLabel2.Text = "QTY:";
            // 
            // TotalQuantity
            // 
            TotalQuantity.AutoSize = true;
            TotalQuantity.BackColor = Color.Transparent;
            TotalQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalQuantity.ForeColor = Color.FromArgb(76, 76, 77);
            TotalQuantity.Location = new Point(92, 50);
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.Size = new Size(56, 17);
            TotalQuantity.TabIndex = 4;
            TotalQuantity.Text = "Quantity";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.BackColor = Color.Transparent;
            ProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductName.ForeColor = Color.FromArgb(76, 76, 77);
            ProductName.Location = new Point(92, 8);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(88, 17);
            ProductName.TabIndex = 3;
            ProductName.Text = "ProductName";
            // 
            // ProductImage
            // 
            ProductImage.Location = new Point(13, 8);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(73, 62);
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImage.TabIndex = 2;
            ProductImage.TabStop = false;
            // 
            // CartItemTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(poisonPanel2);
            Name = "CartItemTemplate";
            Size = new Size(298, 76);
            poisonPanel2.ResumeLayout(false);
            poisonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.DungeonLabel TotalPrice;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel ProductName;
        private PictureBox ProductImage;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel TotalQuantity;
    }
}
