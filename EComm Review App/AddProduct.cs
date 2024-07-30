namespace EComm_Review_App.Controllers
{
    public partial class AddProduct : Form
    {
        #region Moveable Form Properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);
        #endregion

        Form1 _Form1;
        public AddProduct(Form1 form1)
        {
            _Form1 = form1;

            InitializeComponent();
        }

        #region Form Button Functions
        private void AddProductImageBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    // Create an Image object from the specified file
                    Image product = Image.FromFile(filePath);

                    // Display the image in the picture box
                    productDisplay.Image = product;
                }
                catch (Exception ex)
                {
                    // Check if the error is an OutOfMemoryException
                    if (ex is OutOfMemoryException)
                    {
                        MessageBox.Show($"Error: File Size Too Big");
                    }
                    else
                    {
                        MessageBox.Show($"An Error Occurred: {ex.Message}");
                    }

                }

            }
        }

        private async void AddItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the fields are empty
                if (
                    productName.Text != string.Empty ||
                    productDescription.Text != string.Empty ||
                    productDisplay.Image != null ||
                    productCost.Text != string.Empty)
                {
                    //remove $ from cost box
                    productCost.Text = productCost.Text.Replace("$", "");

                    //create variables to send to database
                    string name = productName.Text;
                    string description = productDescription.Text;
                    float cost = float.Parse(productCost.Text);
                    string imagePath = openFileDialog.FileName;

                    // Send the data to the db controller
                    await DatabaseController.AddItemAsync(this, name, description, cost, imagePath);
                }
                else
                {
                    MessageBox.Show("Fields Cannot Be Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }

        }

        #endregion


        #region Form Events
        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the Form1 form when the AddProduct form is closed
            _Form1.Show();
        }
        #endregion


        #region Moveable Form Functions
        private void AddProduct_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void AddProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void AddProduct_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        
    }
}
