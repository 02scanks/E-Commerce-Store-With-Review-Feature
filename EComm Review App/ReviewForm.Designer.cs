namespace EComm_Review_App
{
    partial class ReviewForm
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
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            reviewBox = new ReaLTaiizor.Controls.PoisonTextBox();
            userIDBox = new ReaLTaiizor.Controls.PoisonTextBox();
            orderIDBox = new ReaLTaiizor.Controls.PoisonTextBox();
            itemsBox = new ListBox();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel5 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel6 = new ReaLTaiizor.Controls.DungeonLabel();
            submitReview = new ReaLTaiizor.Controls.DungeonButtonLeft();
            commentBox = new ReaLTaiizor.Controls.DungeonTextBox();
            dateBox = new DateTimePicker();
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
            controlBox.TabIndex = 3;
            controlBox.Text = "dungeonControlBox1";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(55, 50);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(73, 20);
            dungeonLabel1.TabIndex = 4;
            dungeonLabel1.Text = "Order ID:";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(55, 99);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(65, 20);
            dungeonLabel2.TabIndex = 5;
            dungeonLabel2.Text = "User ID:";
            // 
            // reviewBox
            // 
            // 
            // 
            // 
            reviewBox.CustomButton.Image = null;
            reviewBox.CustomButton.Location = new Point(45, 1);
            reviewBox.CustomButton.Name = "";
            reviewBox.CustomButton.Size = new Size(19, 19);
            reviewBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            reviewBox.CustomButton.TabIndex = 1;
            reviewBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            reviewBox.CustomButton.UseSelectable = true;
            reviewBox.CustomButton.Visible = false;
            reviewBox.Location = new Point(55, 303);
            reviewBox.MaxLength = 32767;
            reviewBox.Name = "reviewBox";
            reviewBox.PasswordChar = '\0';
            reviewBox.ScrollBars = ScrollBars.None;
            reviewBox.SelectedText = "";
            reviewBox.SelectionLength = 0;
            reviewBox.SelectionStart = 0;
            reviewBox.ShortcutsEnabled = true;
            reviewBox.Size = new Size(65, 21);
            reviewBox.TabIndex = 8;
            reviewBox.UseSelectable = true;
            reviewBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            reviewBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // userIDBox
            // 
            // 
            // 
            // 
            userIDBox.CustomButton.Image = null;
            userIDBox.CustomButton.Location = new Point(45, 1);
            userIDBox.CustomButton.Name = "";
            userIDBox.CustomButton.Size = new Size(19, 19);
            userIDBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            userIDBox.CustomButton.TabIndex = 1;
            userIDBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            userIDBox.CustomButton.UseSelectable = true;
            userIDBox.CustomButton.Visible = false;
            userIDBox.Enabled = false;
            userIDBox.Location = new Point(134, 99);
            userIDBox.MaxLength = 32767;
            userIDBox.Name = "userIDBox";
            userIDBox.PasswordChar = '\0';
            userIDBox.ReadOnly = true;
            userIDBox.ScrollBars = ScrollBars.None;
            userIDBox.SelectedText = "";
            userIDBox.SelectionLength = 0;
            userIDBox.SelectionStart = 0;
            userIDBox.ShortcutsEnabled = true;
            userIDBox.Size = new Size(65, 21);
            userIDBox.TabIndex = 9;
            userIDBox.UseSelectable = true;
            userIDBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            userIDBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // orderIDBox
            // 
            // 
            // 
            // 
            orderIDBox.CustomButton.Image = null;
            orderIDBox.CustomButton.Location = new Point(45, 1);
            orderIDBox.CustomButton.Name = "";
            orderIDBox.CustomButton.Size = new Size(19, 19);
            orderIDBox.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            orderIDBox.CustomButton.TabIndex = 1;
            orderIDBox.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            orderIDBox.CustomButton.UseSelectable = true;
            orderIDBox.CustomButton.Visible = false;
            orderIDBox.Enabled = false;
            orderIDBox.Location = new Point(134, 50);
            orderIDBox.MaxLength = 32767;
            orderIDBox.Name = "orderIDBox";
            orderIDBox.PasswordChar = '\0';
            orderIDBox.ReadOnly = true;
            orderIDBox.ScrollBars = ScrollBars.None;
            orderIDBox.SelectedText = "";
            orderIDBox.SelectionLength = 0;
            orderIDBox.SelectionStart = 0;
            orderIDBox.ShortcutsEnabled = true;
            orderIDBox.Size = new Size(65, 21);
            orderIDBox.TabIndex = 10;
            orderIDBox.UseSelectable = true;
            orderIDBox.WaterMarkColor = Color.FromArgb(109, 109, 109);
            orderIDBox.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // itemsBox
            // 
            itemsBox.FormattingEnabled = true;
            itemsBox.ItemHeight = 15;
            itemsBox.Location = new Point(378, 148);
            itemsBox.Name = "itemsBox";
            itemsBox.Size = new Size(197, 124);
            itemsBox.TabIndex = 11;
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 11F);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(378, 125);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(48, 20);
            dungeonLabel3.TabIndex = 12;
            dungeonLabel3.Text = "Items:";
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 11F);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(378, 50);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(44, 20);
            dungeonLabel4.TabIndex = 13;
            dungeonLabel4.Text = "Date:";
            // 
            // dungeonLabel5
            // 
            dungeonLabel5.AutoSize = true;
            dungeonLabel5.BackColor = Color.Transparent;
            dungeonLabel5.Font = new Font("Segoe UI", 11F);
            dungeonLabel5.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel5.Location = new Point(55, 125);
            dungeonLabel5.Name = "dungeonLabel5";
            dungeonLabel5.Size = new Size(83, 20);
            dungeonLabel5.TabIndex = 14;
            dungeonLabel5.Text = "Comments:";
            // 
            // dungeonLabel6
            // 
            dungeonLabel6.AutoSize = true;
            dungeonLabel6.BackColor = Color.Transparent;
            dungeonLabel6.Font = new Font("Segoe UI", 11F);
            dungeonLabel6.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel6.Location = new Point(55, 278);
            dungeonLabel6.Name = "dungeonLabel6";
            dungeonLabel6.Size = new Size(88, 20);
            dungeonLabel6.TabIndex = 15;
            dungeonLabel6.Text = "Rating (0/5)";
            // 
            // submitReview
            // 
            submitReview.BackColor = Color.Transparent;
            submitReview.BorderColor = Color.FromArgb(180, 180, 180);
            submitReview.Font = new Font("Segoe UI", 12F);
            submitReview.Image = null;
            submitReview.ImageAlign = ContentAlignment.MiddleLeft;
            submitReview.InactiveColorA = Color.FromArgb(253, 252, 252);
            submitReview.InactiveColorB = Color.FromArgb(239, 237, 236);
            submitReview.Location = new Point(378, 294);
            submitReview.Name = "submitReview";
            submitReview.PressedColorA = Color.FromArgb(226, 226, 226);
            submitReview.PressedColorB = Color.FromArgb(237, 237, 237);
            submitReview.PressedContourColorA = Color.FromArgb(167, 167, 167);
            submitReview.PressedContourColorB = Color.FromArgb(167, 167, 167);
            submitReview.Size = new Size(197, 30);
            submitReview.TabIndex = 16;
            submitReview.Text = "Submit Review";
            submitReview.TextAlignment = StringAlignment.Center;
            submitReview.Click += submitReview_Click;
            // 
            // commentBox
            // 
            commentBox.BackColor = Color.Transparent;
            commentBox.BorderColor = Color.FromArgb(180, 180, 180);
            commentBox.EdgeColor = Color.White;
            commentBox.Font = new Font("Tahoma", 11F);
            commentBox.ForeColor = Color.DimGray;
            commentBox.Location = new Point(55, 148);
            commentBox.MaxLength = 32767;
            commentBox.Multiline = true;
            commentBox.Name = "commentBox";
            commentBox.ReadOnly = false;
            commentBox.Size = new Size(267, 124);
            commentBox.TabIndex = 17;
            commentBox.TextAlignment = HorizontalAlignment.Left;
            commentBox.UseSystemPasswordChar = false;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(378, 73);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(200, 23);
            dateBox.TabIndex = 18;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 373);
            Controls.Add(dateBox);
            Controls.Add(commentBox);
            Controls.Add(submitReview);
            Controls.Add(dungeonLabel6);
            Controls.Add(dungeonLabel5);
            Controls.Add(dungeonLabel4);
            Controls.Add(dungeonLabel3);
            Controls.Add(itemsBox);
            Controls.Add(orderIDBox);
            Controls.Add(userIDBox);
            Controls.Add(reviewBox);
            Controls.Add(dungeonLabel2);
            Controls.Add(dungeonLabel1);
            Controls.Add(controlBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReviewForm";
            Text = "ReviewForm";
            FormClosing += ReviewForm_FormClosing;
            MouseDown += ReviewForm_MouseDown;
            MouseMove += ReviewForm_MouseMove;
            MouseUp += ReviewForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonControlBox controlBox;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.PoisonTextBox reviewBox;
        private ReaLTaiizor.Controls.PoisonTextBox userIDBox;
        private ReaLTaiizor.Controls.PoisonTextBox orderIDBox;
        private ListBox itemsBox;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel6;
        private ReaLTaiizor.Controls.DungeonButtonLeft submitReview;
        private ReaLTaiizor.Controls.DungeonTextBox commentBox;
        private DateTimePicker dateBox;
    }
}