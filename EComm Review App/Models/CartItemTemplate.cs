namespace EComm_Review_App.Models
{
    public partial class CartItemTemplate : UserControl
    {
        public CartItemTemplate()
        {
            InitializeComponent();
        }

        public string CartItemName 
        {
            get { return ProductName.Text; }
            set { ProductName.Text = value; }
        }

        public int CartItemQuantity
        {
            get { return Convert.ToInt32(TotalQuantity.Text); }
            set { TotalQuantity.Text = value.ToString(); }
        }

        public float CartItemPrice
        {
            get
            {
                string priceText = TotalPrice.Text.Replace("$", "");
                return float.Parse(priceText);
            }
            set { TotalPrice.Text = $"${value.ToString()}"; }
        }

        public Image CartItemImage
        {
            get { return ProductImage.Image; }
            set { ProductImage.Image = value; }
        }
    }
}
