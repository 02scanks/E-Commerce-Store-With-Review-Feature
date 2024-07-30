namespace EComm_Review_App.Models
{
    partial class ProductTemplate
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
            itemDisplay = new PictureBox();
            ItemName = new ReaLTaiizor.Controls.DungeonLabel();
            PriceLabel = new ReaLTaiizor.Controls.DungeonLabel();
            ItemPrice = new ReaLTaiizor.Controls.DungeonLabel();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            ItemInfo = new ReaLTaiizor.Controls.DungeonLabel();
            AddToCartBtn = new ReaLTaiizor.Controls.DungeonButtonRight();
            ItemRating = new ReaLTaiizor.Controls.DungeonLabel();
            ((System.ComponentModel.ISupportInitialize)itemDisplay).BeginInit();
            poisonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // itemDisplay
            // 
            itemDisplay.BackColor = SystemColors.AppWorkspace;
            itemDisplay.Location = new Point(15, 16);
            itemDisplay.Name = "itemDisplay";
            itemDisplay.Size = new Size(128, 101);
            itemDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            itemDisplay.TabIndex = 0;
            itemDisplay.TabStop = false;
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.BackColor = Color.Transparent;
            ItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemName.ForeColor = Color.FromArgb(76, 76, 77);
            ItemName.Location = new Point(161, 15);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(91, 21);
            ItemName.TabIndex = 3;
            ItemName.Text = "Item Name";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.BackColor = Color.Transparent;
            PriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.ForeColor = Color.FromArgb(76, 76, 77);
            PriceLabel.Location = new Point(445, 16);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(46, 21);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price";
            // 
            // ItemPrice
            // 
            ItemPrice.BackColor = Color.Transparent;
            ItemPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemPrice.ForeColor = Color.FromArgb(76, 76, 77);
            ItemPrice.Location = new Point(400, 43);
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new Size(151, 32);
            ItemPrice.TabIndex = 5;
            ItemPrice.Text = "$----";
            ItemPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // poisonPanel1
            // 
            poisonPanel1.BorderStyle = BorderStyle.FixedSingle;
            poisonPanel1.Controls.Add(ItemInfo);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(161, 59);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(242, 58);
            poisonPanel1.TabIndex = 6;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // ItemInfo
            // 
            ItemInfo.BackColor = Color.Transparent;
            ItemInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemInfo.ForeColor = Color.FromArgb(76, 76, 77);
            ItemInfo.Location = new Point(-1, 0);
            ItemInfo.Name = "ItemInfo";
            ItemInfo.Size = new Size(242, 56);
            ItemInfo.TabIndex = 2;
            ItemInfo.Text = "Item Info";
            // 
            // AddToCartBtn
            // 
            AddToCartBtn.BackColor = Color.Transparent;
            AddToCartBtn.BorderColor = Color.FromArgb(162, 120, 101);
            AddToCartBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddToCartBtn.Image = null;
            AddToCartBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddToCartBtn.InactiveColorA = Color.FromArgb(253, 175, 143);
            AddToCartBtn.InactiveColorB = Color.FromArgb(244, 146, 106);
            AddToCartBtn.Location = new Point(421, 86);
            AddToCartBtn.Name = "AddToCartBtn";
            AddToCartBtn.PressedColorA = Color.FromArgb(244, 146, 106);
            AddToCartBtn.PressedColorB = Color.FromArgb(244, 146, 106);
            AddToCartBtn.PressedContourColorA = Color.FromArgb(162, 120, 101);
            AddToCartBtn.PressedContourColorB = Color.FromArgb(162, 120, 101);
            AddToCartBtn.Size = new Size(104, 30);
            AddToCartBtn.TabIndex = 7;
            AddToCartBtn.Text = "Add To Cart";
            AddToCartBtn.TextAlignment = StringAlignment.Center;
            AddToCartBtn.Click += AddToCartBtn_Click;
            // 
            // ItemRating
            // 
            ItemRating.AutoSize = true;
            ItemRating.BackColor = Color.Transparent;
            ItemRating.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemRating.ForeColor = Color.FromArgb(76, 76, 77);
            ItemRating.Location = new Point(161, 38);
            ItemRating.Name = "ItemRating";
            ItemRating.Size = new Size(47, 15);
            ItemRating.TabIndex = 8;
            ItemRating.Text = "Rating: ";
            // 
            // ProductTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemRating);
            Controls.Add(poisonPanel1);
            Controls.Add(ItemPrice);
            Controls.Add(PriceLabel);
            Controls.Add(ItemName);
            Controls.Add(itemDisplay);
            Controls.Add(AddToCartBtn);
            Name = "ProductTemplate";
            Size = new Size(551, 134);
            ((System.ComponentModel.ISupportInitialize)itemDisplay).EndInit();
            poisonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox itemDisplay;
        private ReaLTaiizor.Controls.DungeonLabel ItemName;
        private ReaLTaiizor.Controls.DungeonLabel PriceLabel;
        private ReaLTaiizor.Controls.DungeonLabel ItemPrice;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.DungeonLabel ItemInfo;
        private ReaLTaiizor.Controls.DungeonButtonRight AddToCartBtn;
        private ReaLTaiizor.Controls.DungeonLabel ItemRating;
    }
}
