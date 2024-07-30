namespace EComm_Review_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            controlBox = new ReaLTaiizor.Controls.DungeonControlBox();
            cartBackPanel = new ReaLTaiizor.Controls.PoisonPanel();
            cartTotal = new ReaLTaiizor.Controls.DungeonLabel();
            checkoutBtn = new ReaLTaiizor.Controls.DungeonButtonLeft();
            cartBtn = new ReaLTaiizor.Controls.DungeonButtonLeft();
            CartItemPanel = new ReaLTaiizor.Controls.PoisonPanel();
            productsPanel = new ReaLTaiizor.Controls.PoisonPanel();
            searchBar = new ReaLTaiizor.Controls.DungeonTextBox();
            pictureBox1 = new PictureBox();
            AddProductBtn = new ReaLTaiizor.Controls.DungeonButtonLeft();
            searchButton = new ReaLTaiizor.Controls.DungeonButtonLeft();
            overlayPanel = new Panel();
            pictureBox2 = new PictureBox();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cartBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            overlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            controlBox.TabIndex = 1;
            controlBox.Text = "dungeonControlBox1";
            // 
            // cartBackPanel
            // 
            cartBackPanel.BackColor = Color.Silver;
            cartBackPanel.BorderStyle = BorderStyle.FixedSingle;
            cartBackPanel.Controls.Add(cartTotal);
            cartBackPanel.Controls.Add(checkoutBtn);
            cartBackPanel.Controls.Add(cartBtn);
            cartBackPanel.Controls.Add(CartItemPanel);
            cartBackPanel.Dock = DockStyle.Right;
            cartBackPanel.HorizontalScrollbarBarColor = true;
            cartBackPanel.HorizontalScrollbarHighlightOnWheel = false;
            cartBackPanel.HorizontalScrollbarSize = 10;
            cartBackPanel.Location = new Point(750, 0);
            cartBackPanel.Name = "cartBackPanel";
            cartBackPanel.Size = new Size(50, 450);
            cartBackPanel.TabIndex = 3;
            cartBackPanel.VerticalScrollbarBarColor = true;
            cartBackPanel.VerticalScrollbarHighlightOnWheel = false;
            cartBackPanel.VerticalScrollbarSize = 10;
            // 
            // cartTotal
            // 
            cartTotal.BackColor = Color.Transparent;
            cartTotal.Font = new Font("Segoe UI", 11F);
            cartTotal.ForeColor = Color.FromArgb(76, 76, 77);
            cartTotal.Location = new Point(66, 41);
            cartTotal.Name = "cartTotal";
            cartTotal.Size = new Size(177, 43);
            cartTotal.TabIndex = 14;
            cartTotal.Text = "Total:";
            cartTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.Transparent;
            checkoutBtn.BorderColor = Color.FromArgb(180, 180, 180);
            checkoutBtn.Font = new Font("Segoe UI", 12F);
            checkoutBtn.Image = null;
            checkoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            checkoutBtn.InactiveColorA = Color.FromArgb(253, 252, 252);
            checkoutBtn.InactiveColorB = Color.FromArgb(239, 237, 236);
            checkoutBtn.Location = new Point(66, 87);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.PressedColorA = Color.FromArgb(226, 226, 226);
            checkoutBtn.PressedColorB = Color.FromArgb(237, 237, 237);
            checkoutBtn.PressedContourColorA = Color.FromArgb(167, 167, 167);
            checkoutBtn.PressedContourColorB = Color.FromArgb(167, 167, 167);
            checkoutBtn.Size = new Size(177, 30);
            checkoutBtn.TabIndex = 13;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.TextAlignment = StringAlignment.Center;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // cartBtn
            // 
            cartBtn.BackColor = Color.Transparent;
            cartBtn.BorderColor = Color.FromArgb(180, 180, 180);
            cartBtn.Font = new Font("Segoe UI", 12F);
            cartBtn.Image = null;
            cartBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cartBtn.InactiveColorA = Color.FromArgb(253, 252, 252);
            cartBtn.InactiveColorB = Color.FromArgb(239, 237, 236);
            cartBtn.Location = new Point(4, 8);
            cartBtn.Name = "cartBtn";
            cartBtn.PressedColorA = Color.FromArgb(226, 226, 226);
            cartBtn.PressedColorB = Color.FromArgb(237, 237, 237);
            cartBtn.PressedContourColorA = Color.FromArgb(167, 167, 167);
            cartBtn.PressedContourColorB = Color.FromArgb(167, 167, 167);
            cartBtn.Size = new Size(41, 30);
            cartBtn.TabIndex = 11;
            cartBtn.Text = "Cart";
            cartBtn.TextAlignment = StringAlignment.Center;
            cartBtn.Click += cartButtn_Click;
            // 
            // CartItemPanel
            // 
            CartItemPanel.AutoScroll = true;
            CartItemPanel.Dock = DockStyle.Bottom;
            CartItemPanel.HorizontalScrollbar = true;
            CartItemPanel.HorizontalScrollbarBarColor = true;
            CartItemPanel.HorizontalScrollbarHighlightOnWheel = false;
            CartItemPanel.HorizontalScrollbarSize = 10;
            CartItemPanel.Location = new Point(0, 123);
            CartItemPanel.Name = "CartItemPanel";
            CartItemPanel.Size = new Size(48, 325);
            CartItemPanel.TabIndex = 4;
            CartItemPanel.VerticalScrollbar = true;
            CartItemPanel.VerticalScrollbarBarColor = true;
            CartItemPanel.VerticalScrollbarHighlightOnWheel = false;
            CartItemPanel.VerticalScrollbarSize = 10;
            // 
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.BorderStyle = BorderStyle.Fixed3D;
            productsPanel.HorizontalScrollbar = true;
            productsPanel.HorizontalScrollbarBarColor = true;
            productsPanel.HorizontalScrollbarHighlightOnWheel = false;
            productsPanel.HorizontalScrollbarSize = 10;
            productsPanel.Location = new Point(48, 89);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(553, 325);
            productsPanel.TabIndex = 5;
            productsPanel.VerticalScrollbar = true;
            productsPanel.VerticalScrollbarBarColor = true;
            productsPanel.VerticalScrollbarHighlightOnWheel = false;
            productsPanel.VerticalScrollbarSize = 10;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BorderColor = Color.FromArgb(180, 180, 180);
            searchBar.EdgeColor = Color.White;
            searchBar.Font = new Font("Tahoma", 11F);
            searchBar.ForeColor = Color.DimGray;
            searchBar.Location = new Point(406, 9);
            searchBar.MaxLength = 32767;
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.ReadOnly = false;
            searchBar.Size = new Size(272, 28);
            searchBar.TabIndex = 6;
            searchBar.TextAlignment = HorizontalAlignment.Left;
            searchBar.UseSystemPasswordChar = false;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.Transparent;
            AddProductBtn.BorderColor = Color.FromArgb(180, 180, 180);
            AddProductBtn.Font = new Font("Segoe UI", 12F);
            AddProductBtn.Image = null;
            AddProductBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddProductBtn.InactiveColorA = Color.FromArgb(253, 252, 252);
            AddProductBtn.InactiveColorB = Color.FromArgb(239, 237, 236);
            AddProductBtn.Location = new Point(607, 89);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.PressedColorA = Color.FromArgb(226, 226, 226);
            AddProductBtn.PressedColorB = Color.FromArgb(237, 237, 237);
            AddProductBtn.PressedContourColorA = Color.FromArgb(167, 167, 167);
            AddProductBtn.PressedContourColorB = Color.FromArgb(167, 167, 167);
            AddProductBtn.Size = new Size(133, 30);
            AddProductBtn.TabIndex = 9;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.TextAlignment = StringAlignment.Center;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BorderColor = Color.FromArgb(180, 180, 180);
            searchButton.Font = new Font("Segoe UI", 12F);
            searchButton.Image = null;
            searchButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchButton.InactiveColorA = Color.FromArgb(253, 252, 252);
            searchButton.InactiveColorB = Color.FromArgb(239, 237, 236);
            searchButton.Location = new Point(688, 9);
            searchButton.Name = "searchButton";
            searchButton.PressedColorA = Color.FromArgb(226, 226, 226);
            searchButton.PressedColorB = Color.FromArgb(237, 237, 237);
            searchButton.PressedContourColorA = Color.FromArgb(167, 167, 167);
            searchButton.PressedContourColorB = Color.FromArgb(167, 167, 167);
            searchButton.Size = new Size(56, 30);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.TextAlignment = StringAlignment.Center;
            searchButton.Click += searchButton_Click;
            // 
            // overlayPanel
            // 
            overlayPanel.BackColor = SystemColors.ControlLightLight;
            overlayPanel.Controls.Add(pictureBox2);
            overlayPanel.Controls.Add(dungeonHeaderLabel1);
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.ForeColor = Color.White;
            overlayPanel.Location = new Point(0, 0);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new Size(750, 450);
            overlayPanel.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.DimGray;
            dungeonHeaderLabel1.Location = new Point(154, 182);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(177, 64);
            dungeonHeaderLabel1.TabIndex = 12;
            dungeonHeaderLabel1.Text = "Your Cart";
            dungeonHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(overlayPanel);
            Controls.Add(pictureBox1);
            Controls.Add(cartBackPanel);
            Controls.Add(controlBox);
            Controls.Add(searchBar);
            Controls.Add(productsPanel);
            Controls.Add(searchButton);
            Controls.Add(AddProductBtn);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            cartBackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            overlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.DungeonControlBox controlBox;
        private ReaLTaiizor.Controls.PoisonPanel cartBackPanel;
        private ReaLTaiizor.Controls.PoisonPanel CartItemPanel;
        private ReaLTaiizor.Controls.PoisonPanel productsPanel;
        private ReaLTaiizor.Controls.DungeonTextBox searchBar;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonButtonLeft AddProductBtn;
        private ReaLTaiizor.Controls.DungeonButtonLeft cartBtn;
        private ReaLTaiizor.Controls.DungeonButtonLeft searchButton;
        private ReaLTaiizor.Controls.DungeonButtonLeft checkoutBtn;
        private ReaLTaiizor.Controls.DungeonLabel cartTotal;
        private Panel overlayPanel;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
    }
}
