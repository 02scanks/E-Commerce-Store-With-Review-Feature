using EComm_Review_App.Models;
using System.Text;

public class FileController 
{
    internal static async Task SaveInvoiceToDiskAsync(int invoiceNumber, CartItemTemplate[] items, float totalPrice) 
    {
        try
        {
            // Create a new string builder to store the invoice details
            StringBuilder sb = new StringBuilder();

            // Add the invoice number to the string builder
            sb.AppendLine($"Invoice #{invoiceNumber}");

            // Add the items to the string builder
            sb.AppendLine("Items:");
            foreach (var item in items)
            {
                sb.AppendLine($"{item.CartItemQuantity}x {item.CartItemName}: ${item.CartItemPrice}");
            }

            // Add the total price to the string builder
            sb.AppendLine($"Total Price: ${totalPrice}");

            // Convert the string builder to a string
            string content = sb.ToString();

            // Write the content to a file
            await File.WriteAllTextAsync($"invoice{invoiceNumber}.txt", content);

            MessageBox.Show("Invoice saved successfully!");
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
        
    }
}