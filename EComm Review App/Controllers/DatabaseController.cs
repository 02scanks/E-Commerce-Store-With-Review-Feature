using EComm_Review_App;
using EComm_Review_App.Controllers;
using EComm_Review_App.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

public class DatabaseController 
{
    internal static async Task AddItemAsync(AddProduct addProductForm, string name, string description, float price, string imagePath)
    {
        try
        {
            addProductForm.Close();

            // Create a new temp DB object
            var db = new AppDbContext();

            // Create a new product object
            var product = new Product
            {
                Name = name,
                Description = description,
                Cost = price,
                ProductImageData = await File.ReadAllBytesAsync(imagePath)
            };

            // Add the product to the database if it is not null
            if (product != null)
            {
                await db.Products.AddAsync(product);
                await db.SaveChangesAsync();

                // Display a message box to the user
                MessageBox.Show("Product Added");
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
        
    }

    internal static async Task GetProductsAsync(Panel panel) 
    {
        try
        {
            // Clear the panel before adding new products
            panel.Controls.Clear();

            // Set the initial height of the panel for the first product
            int i = 0;

            // Create a new temp DB object
            var db = new AppDbContext();

            // Get all the products from the database
            var products = await db.Products.ToListAsync();

            // Loop through all the products
            foreach (var product in products)
            {
                // Get the product details
                string name = product.Name;
                string description = product.Description;
                float cost = product.Cost;
                float rating = product.ReviewAverage / product.TotalReviews;
                Image productImage = null;

                // Convert the byte array to an image
                using (MemoryStream ms = new MemoryStream(product.ProductImageData))
                {
                    productImage = Image.FromStream(ms);
                }

                // Create a new product template
                ProductTemplate productTemplate = new ProductTemplate();
                productTemplate.ProductName = name;
                productTemplate.ProductDescription = description;
                productTemplate.ProductPrice = cost;
                productTemplate.ProductImage = productImage;
                productTemplate.Rating = MathF.Round(rating, 2);

                // Increase the panel height
                productTemplate.Location = new Point(0, i);
                // Add the product template to the panel
                panel.Controls.Add(productTemplate);

                // Increase the height of the product template to accommodate for the next product
                i += 134;
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
        
    }

    internal static async Task AddToCartAsync(Form1 main, string name, int quantity, float price, Image image)
    {
        try
        {
            // Check if the item already exists in the cart
            bool itemExists = false;

            foreach (Control control in main.cartPanel.Controls)
            {
                if (control.Name == name)
                {
                    // Update the existing item's quantity and price
                    var cartItem = control as CartItemTemplate;
                    if (cartItem != null)
                    {
                        cartItem.CartItemQuantity += quantity; // Increment quantity
                        cartItem.CartItemPrice += price; // Update price if necessary
                    }

                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                // Create a new cart item object
                CartItemTemplate cartItemTemplate = new CartItemTemplate
                {
                    Name = name, // Set the control's name for identification
                    CartItemName = name,
                    CartItemQuantity = quantity,
                    CartItemPrice = price,
                    CartItemImage = image
                };

                // Increment the height of the cart item template panel each time a product is added
                int i = (main.cartPanel.Controls.Count - 2) * 76; // Adjusted to consider the new item

                // Set product height to the current panel height indexer (i)
                cartItemTemplate.Location = new Point(0, i);

                // Add the product template to the panel
                main.cartPanel.Controls.Add(cartItemTemplate);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
    }

    internal static async Task SearchForProduct(string searchValue, Panel productPanel) 
    {
        try 
        {
            // Create a new temp DB object
            var db = new AppDbContext();

            // Get all the products from the database that match the search value
            var products = await db.Products.Where(p => p.Name.Contains(searchValue)).ToListAsync();

            // Check if any products were found
            if (products.Count > 0)
            {
                // Clear the panel before adding new products
                productPanel.Controls.Clear();

                // Set the initial height of the panel for the first product
                int i = 0;

                // Loop through all the products
                foreach (var product in products)
                {
                    // Get the product details
                    string name = product.Name;
                    string description = product.Description;
                    float cost = product.Cost;
                    Image productImage = null;

                    // Convert the byte array to an image
                    using (MemoryStream ms = new MemoryStream(product.ProductImageData))
                    {
                        productImage = Image.FromStream(ms);
                    }

                    // Create a new product template
                    ProductTemplate productTemplate = new ProductTemplate();
                    productTemplate.ProductName = name;
                    productTemplate.ProductDescription = description;
                    productTemplate.ProductPrice = cost;
                    productTemplate.ProductImage = productImage;

                    // Increase the panel height
                    productTemplate.Location = new Point(0, i);

                    // Add the product template to the panel
                    productPanel.Controls.Add(productTemplate);

                    // Increase the height of the product template to accommodate for the next product
                    i += 134;
                }
            }
            else
            {
                MessageBox.Show("No products found");
            }
        }
        catch(Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
        
    }

    internal static async Task CheckoutAsync(Form1 main, Panel cartItemPanel) 
    {
        try
        {
            var db = new AppDbContext();

            // Get all the products from the cart
            var cartItems = cartItemPanel.Controls.OfType<CartItemTemplate>();
            CartItemTemplate[] items = cartItems.ToArray();

            // create array of item names
            string[] itemNames = new string[items.Length];

            // initialize total price
            float totalPrice = 0;

            //random order ID and User ID for purposes of mock invoice
            int orderID = RandomNumberGenerator.GetInt32(1, 9999);
            int userID = RandomNumberGenerator.GetInt32(1, 9999);


            // Calculate total price and create list of products
            int i = 0;
            foreach (var item in items)
            {
                totalPrice += item.CartItemPrice;

                //add item name to array
                itemNames[i] = item.CartItemName;
                //increment i
                i++;
            }

            // create text invoice
            await FileController.SaveInvoiceToDiskAsync(orderID, items, totalPrice);

            //ask user to leave a review
            var result = MessageBox.Show(
                "Would you like to leave a review?",
                "Leave a review?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //if user wants to leave a review
            if (result == DialogResult.Yes)
            {
                //open review form with main form as parameter
                ReviewForm review = new ReviewForm(main, orderID, userID, itemNames);
                review.Show();
                
                //hide main form
                main.Hide();
            }

            // Clear the cart panel
            cartItemPanel.Controls.Clear();
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
        
    }

    internal static async Task ReviewAsync(int orderID, int userID, float rating, string comment, DateTime date, string[] itemNames) 
    {
        try
        {
            // Create a new temp DB object
            var db = new AppDbContext();

            // Create a new review object
            Review review = new Review();
            review.ProductID = orderID;
            review.UserID = userID;
            review.Rating = rating;
            review.Comment = comment;
            review.ReviewDate = date;

            //add review to each product
            foreach (string item in itemNames) 
            {
                //get product from database
                var product = await db.Products.FirstOrDefaultAsync(p => p.Name == item);
                product.TotalReviews++;
                product.ReviewAverage += rating;
            }

            // Check if the review is not null
            if (review != null)
            {
                // Add the review to the database
                await db.Reviews.AddAsync(review);

                // Save the changes to the database
                await db.SaveChangesAsync();

                MessageBox.Show("Thankyou for the review :)");
            }

        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
        
    }
}