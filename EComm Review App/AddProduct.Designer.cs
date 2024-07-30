namespace EComm_Review_App.Controllers
{
    partial class AddProduct
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
            controlBox = new ReaLTaiizor.Controls.DungeonControlBox();
            productDisplay = new PictureBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            AddProductImageBtn = new ReaLTaiizor.Controls.DungeonButtonLeft();
            productName = new ReaLTaiizor.Controls.DungeonTextBox();
            productDescription = new ReaLTaiizor.Controls.DungeonTextBox();
            productCost = new ReaLTaiizor.Controls.DungeonTextBox();
            AddItemBtn = new ReaLTaiizor.Controls.DungeonButtonLeft();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)productDisplay).BeginInit();
            SuspendLayout();
            // 
            // controlBox
            // 
            controlBox.BackColor = Color.Transparent;
            controlBox.DefaultLocation = true;
            controlBox.EnableMaximize = false;
            controlBox.EnableMinimize = true;
            controlBox.Font = new Font("Marlett", 7F);
            controlBox.Location = new Point(5, 13);
            controlBox.Name = "controlBox";
            controlBox.RightToLeft = RightToLeft.No;
            controlBox.Size = new Size(44, 22);
            controlBox.TabIndex = 2;
            controlBox.Text = "dungeonControlBox1";
            // 
            // productDisplay
            // 
            productDisplay.BorderStyle = BorderStyle.FixedSingle;
            productDisplay.Location = new Point(376, 29);
            productDisplay.Name = "productDisplay";
            productDisplay.Size = new Size(242, 191);
            productDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            productDisplay.TabIndex = 3;
            productDisplay.TabStop = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(12, 37);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(107, 20);
            dungeonLabel1.TabIndex = 4;
            dungeonLabel1.Text = "Product Name:";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11F);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(12, 111);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(145, 20);
            dungeonLabel2.TabIndex = 5;
            dungeonLabel2.Text = "Product Information:";
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 11F);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(235, 37);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(96, 20);
            dungeonLabel3.TabIndex = 6;
            dungeonLabel3.Text = "Product Cost:";
            // 
            // AddProductImageBtn
            // 
            AddProductImageBtn.BackColor = Color.Transparent;
            AddProductImageBtn.BorderColor = Color.FromArgb(180, 180, 180);
            AddProductImageBtn.Font = new Font("Segoe UI", 12F);
            AddProductImageBtn.Image = null;
            AddProductImageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddProductImageBtn.InactiveColorA = Color.FromArgb(253, 252, 252);
            AddProductImageBtn.InactiveColorB = Color.FromArgb(239, 237, 236);
            AddProductImageBtn.Location = new Point(376, 238);
            AddProductImageBtn.Name = "AddProductImageBtn";
            AddProductImageBtn.PressedColorA = Color.FromArgb(226, 226, 226);
            AddProductImageBtn.PressedColorB = Color.FromArgb(237, 237, 237);
            AddProductImageBtn.PressedContourColorA = Color.FromArgb(167, 167, 167);
            AddProductImageBtn.PressedContourColorB = Color.FromArgb(167, 167, 167);
            AddProductImageBtn.Size = new Size(242, 30);
            AddProductImageBtn.TabIndex = 7;
            AddProductImageBtn.Text = "Add Product Image";
            AddProductImageBtn.TextAlignment = StringAlignment.Center;
            AddProductImageBtn.Click += AddProductImageBtn_Click;
            // 
            // productName
            // 
            productName.BackColor = Color.Transparent;
            productName.BorderColor = Color.FromArgb(180, 180, 180);
            productName.EdgeColor = Color.White;
            productName.Font = new Font("Tahoma", 11F);
            productName.ForeColor = Color.DimGray;
            productName.Location = new Point(12, 60);
            productName.MaxLength = 32767;
            productName.Multiline = false;
            productName.Name = "productName";
            productName.ReadOnly = false;
            productName.Size = new Size(197, 28);
            productName.TabIndex = 8;
            productName.TextAlignment = HorizontalAlignment.Left;
            productName.UseSystemPasswordChar = false;
            // 
            // productDescription
            // 
            productDescription.BackColor = Color.Transparent;
            productDescription.BorderColor = Color.FromArgb(180, 180, 180);
            productDescription.EdgeColor = Color.White;
            productDescription.Font = new Font("Tahoma", 11F);
            productDescription.ForeColor = Color.DimGray;
            productDescription.Location = new Point(12, 134);
            productDescription.MaxLength = 32767;
            productDescription.Multiline = true;
            productDescription.Name = "productDescription";
            productDescription.ReadOnly = false;
            productDescription.Size = new Size(335, 63);
            productDescription.TabIndex = 9;
            productDescription.TextAlignment = HorizontalAlignment.Left;
            productDescription.UseSystemPasswordChar = false;
            // 
            // productCost
            // 
            productCost.BackColor = Color.Transparent;
            productCost.BorderColor = Color.FromArgb(180, 180, 180);
            productCost.EdgeColor = Color.White;
            productCost.Font = new Font("Tahoma", 11F);
            productCost.ForeColor = Color.DimGray;
            productCost.Location = new Point(235, 60);
            productCost.MaxLength = 32767;
            productCost.Multiline = false;
            productCost.Name = "productCost";
            productCost.ReadOnly = false;
            productCost.Size = new Size(112, 28);
            productCost.TabIndex = 10;
            productCost.Text = "$";
            productCost.TextAlignment = HorizontalAlignment.Left;
            productCost.UseSystemPasswordChar = false;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.Transparent;
            AddItemBtn.BorderColor = Color.FromArgb(180, 180, 180);
            AddItemBtn.Font = new Font("Segoe UI", 12F);
            AddItemBtn.Image = null;
            AddItemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddItemBtn.InactiveColorA = Color.FromArgb(253, 252, 252);
            AddItemBtn.InactiveColorB = Color.FromArgb(239, 237, 236);
            AddItemBtn.Location = new Point(92, 222);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.PressedColorA = Color.FromArgb(226, 226, 226);
            AddItemBtn.PressedColorB = Color.FromArgb(237, 237, 237);
            AddItemBtn.PressedContourColorA = Color.FromArgb(167, 167, 167);
            AddItemBtn.PressedContourColorB = Color.FromArgb(167, 167, 167);
            AddItemBtn.Size = new Size(185, 46);
            AddItemBtn.TabIndex = 11;
            AddItemBtn.Text = "Add";
            AddItemBtn.TextAlignment = StringAlignment.Center;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 294);
            Controls.Add(AddItemBtn);
            Controls.Add(productCost);
            Controls.Add(productDescription);
            Controls.Add(productName);
            Controls.Add(AddProductImageBtn);
            Controls.Add(dungeonLabel3);
            Controls.Add(dungeonLabel2);
            Controls.Add(dungeonLabel1);
            Controls.Add(productDisplay);
            Controls.Add(controlBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            Text = "AddProduct";
            FormClosing += AddProduct_FormClosing;
            MouseDown += AddProduct_MouseDown;
            MouseMove += AddProduct_MouseMove;
            MouseUp += AddProduct_MouseUp;
            ((System.ComponentModel.ISupportInitialize)productDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonControlBox controlBox;
        private PictureBox productDisplay;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonButtonLeft AddProductImageBtn;
        private ReaLTaiizor.Controls.DungeonTextBox productName;
        private ReaLTaiizor.Controls.DungeonTextBox productDescription;
        private ReaLTaiizor.Controls.DungeonTextBox productCost;
        private ReaLTaiizor.Controls.DungeonButtonLeft AddItemBtn;
        private OpenFileDialog openFileDialog;
    }
}