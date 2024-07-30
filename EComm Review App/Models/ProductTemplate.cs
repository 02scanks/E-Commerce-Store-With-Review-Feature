namespace EComm_Review_App.Models
{
    public partial class ProductTemplate : UserControl
    {
        private Form1 form1 = new Form1();

        public ProductTemplate()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get { return ItemName.Text; }
            set { ItemName.Text = value; }
        }

        public float Rating 
        {
            get { return float.Parse(ItemRating.Text); }
            set { ItemRating.Text = $"Rating: {value.ToString()} ★"; }
        }

        public string ProductDescription
        {
            get { return ItemInfo.Text; }
            set { ItemInfo.Text = value; }
        }

        public float ProductPrice
        {
            get
            {
                // Check if ItemPrice.Text is empty or in an invalid format
                if (string.IsNullOrEmpty(ItemPrice.Text) || !float.TryParse(ItemPrice.Text.Replace("$", ""), out float price))
                {
                    return 0; // Default or handle invalid case
                }
                return price;
            }
            set
            {
                ItemPrice.Text = $"${value}";
            }
        }

        public Image ProductImage
        {
            get { return itemDisplay.Image; }
            set { itemDisplay.Image = value; }
        }

        private async void AddToCartBtn_Click(object sender, EventArgs e)
        {
            try 
            {

                // Remove the $ from the product price to negate any errors
                float price = float.Parse(ItemPrice.Text.Replace("$", ""));

                // Add the product to the cart
                await DatabaseController.AddToCartAsync((Form1)this.Parent.Parent, ProductName, 1, price, ProductImage);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            
        }
    }
}
