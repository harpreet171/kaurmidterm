using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Not enough stock available.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item: {ItemName}\nID: {ItemId}\nPrice: {Price:C}\nStock Quantity: {QuantityInStock}\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items.
        Console.WriteLine("Initial Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and then print the updated details.
        Console.WriteLine("Selling 3 laptops and 5 smartphones:");
        item1.SellItem(3);
        item2.SellItem(5);
        Console.WriteLine("Updated Item Details after selling:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details.
        Console.WriteLine("Restocking 5 laptops and 8 smartphones:");
        item1.RestockItem(5);
        item2.RestockItem(8);
        Console.WriteLine("Updated Item Details after restocking:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Check if an item is in stock and print a message accordingly.
        Console.WriteLine("Checking if items are in stock:");
        Console.WriteLine($"Laptop is in stock: {item1.IsInStock()}");
        Console.WriteLine($"Smartphone is in stock: {item2.IsInStock()}");
    }
}