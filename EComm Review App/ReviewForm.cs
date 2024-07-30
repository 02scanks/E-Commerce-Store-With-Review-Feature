namespace EComm_Review_App
{
    public partial class ReviewForm : Form
    {
        #region Moveable Form Properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);
        #endregion


        Form1 main;
        int orderID = 0;
        int userID = 0;
        string[] itemNames;

        public ReviewForm(Form1 form1, int orderID, int userID, string[] itemNames)
        {
            InitializeComponent();

            // Set the main form and the orderID and userID
            main = form1;
            this.orderID = orderID;
            this.userID = userID;
            this.itemNames = itemNames;

            // set variables to respective text labels  
            orderIDBox.Text = orderID.ToString();
            userIDBox.Text = userID.ToString();

            // Add the items to the itemsBox
            foreach (string item in itemNames)
            {
                itemsBox.Items.Add(item);
            }

        }

        #region Form Events
        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }

        private void ReviewForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void ReviewForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void ReviewForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        #endregion


        #region Button Functions
        private async void submitReview_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if the rating is a number
                if (!float.TryParse(reviewBox.Text, out float rating))
                {
                    throw new Exception("Please enter a valid rating");
                }

                // Convert the value of dateBox.Text to a DateTime object
                if (!DateTime.TryParse(dateBox.Text, out DateTime date))
                {
                    throw new Exception("Please enter a valid date");
                }

                // Check if any of the fields are empty
                if (reviewBox.Text == string.Empty || commentBox.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in all fields");
                }
                else if (rating > 5 || rating < 1)
                {
                    MessageBox.Show("Please enter a rating between 1 and 5");
                }
                else
                {
                    // Call the ReviewAsync method from the DatabaseController class
                    await DatabaseController.ReviewAsync(
                        orderID,
                        userID,
                        rating,
                        commentBox.Text,
                        date,
                        itemNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        #endregion


        
    }
}
