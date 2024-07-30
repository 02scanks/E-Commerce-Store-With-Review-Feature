using EComm_Review_App.Controllers;
using EComm_Review_App.Models;

namespace EComm_Review_App
{
    public partial class Form1 : Form
    {
        #region Moveable Form Properties
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);
        #endregion

        // Cart Panel
        private bool isOpen = false;
        public Panel cartPanel;

        public Form1()
        {
            InitializeComponent();

            //initialize the overlay panel
            this.overlayPanel.BackColor = Color.FromArgb(8, 255, 255, 255); // white color with 8% opacity
            overlayPanel.Visible = false;

        }

        #region Form Button Functions
        private void cartButtn_Click(object sender, EventArgs e)
        {
            float total = CalculateCartTotal();

            if (!isOpen)
            {
                // Set the cart total
                cartTotal.Text = $"Total: ${total}";

                // Open the cart panel
                cartBackPanel.Width += 250;
                isOpen = true;
                // Show the overlay panel
                overlayPanel.Visible = true;
            }
            else
            {
                // Close the cart panel
                cartBackPanel.Width -= 250;
                isOpen = false;
                // Hide the overlay panel
                overlayPanel.Visible = false;
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();
            this.Hide();
        }

        private async void checkoutBtn_Click(object sender, EventArgs e)
        {
            // Check if the cart is empty
            if (CartItemPanel.Controls.Count <= 2)
            {
                MessageBox.Show("Your cart is empty. Please add some products to the cart before checking out.");
            }
            else
            {
                // Checkout the cart
                await DatabaseController.CheckoutAsync(this, CartItemPanel);
            }
        }

        private async void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (searchBar.Text == string.Empty)
            {
                // Get all the products from the database
                await DatabaseController.GetProductsAsync(productsPanel);
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            // Check if the search bar is empty
            if (searchBar.Text != string.Empty)
            {
                // Search for the product
                await DatabaseController.SearchForProduct(searchBar.Text, productsPanel);
            }
            else
            {
                MessageBox.Show("Please enter a search value.");
            }
        }

        #endregion

        #region Moveable Form Functions
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        #region Form Events
        private async void Form1_Load(object sender, EventArgs e)
        {
            // Get all the products from the database
            await DatabaseController.GetProductsAsync(productsPanel);

            // Set the cart panel
            cartPanel = CartItemPanel;
        }

        #endregion

        #region Custom Functions
        private float CalculateCartTotal()
        {
            // Calculate the total of all the products in the cart
            float total = 0;

            // Check if the cart is empty
            if (CartItemPanel.Controls.Count > 2)
            {
                // Loop through all the cart items and calculate the total
                foreach (var control in CartItemPanel.Controls)
                {
                    if (control is CartItemTemplate cartItem)
                    {
                        total += cartItem.CartItemPrice;
                    }
                }
            }
            else
            {
                return 0f;
            }

            return total;
        }

        #endregion

    }
}
