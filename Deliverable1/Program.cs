using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Initializing the default stock and threshold to restock
        int soda_stock = 100;
        int soda_restock = 40;
        int chips_stock = 40;
        int chips_restock = 20;
        int candy_stock = 60;
        int candy_restock = 40;

        // Asks how many sodas have been sold and stores that value asa variable
        Console.Write("How many sodas have been sold today? 100 in stock: ");
        int sodas_sold = int.Parse(Console.ReadLine());

        // Calculates the soda remaining from taking the default stock and subtracting by how many were bought
        int soda_remaining = soda_stock - sodas_sold;
        if (soda_remaining < 0) //Checks to see if user input is higher than default stock value if it is display message saying so, else display whats left 
        {
            Console.WriteLine("That value is too high, Stock not adjusted");
            soda_remaining = soda_stock;
        }
        else
        {
            Console.WriteLine($"Soda remaining: {soda_remaining}");
        }
        // Asks how many chips have been sold and stores that value as a variable
        Console.Write("How many bags of chips have been sold today? 40 in stock: ");
        int chips_sold = int.Parse(Console.ReadLine());

        // Same thing applies here checks the chips remaining from taking the default value and subtracting that by how many were bought
        int chips_remaining = chips_stock - chips_sold;
        if (chips_remaining < 0)
        {
            Console.WriteLine("That value is too high, Stock not adjusted");
            chips_remaining = chips_stock;
        }
        else
        {
            Console.WriteLine($"Chips remaining: {chips_remaining}");
        }
        //Asks how many candies were sold and stores that value as a variable
        Console.Write("How many candies have been sold today? 60 in stock: ");
        int candies_sold = int.Parse(Console.ReadLine());

        // Takes default value and subtracts it by how many were bought
        int candy_remaining = candy_stock - candies_sold;
        if (candy_remaining < 0)
        {
            Console.WriteLine("That value is too high, Stock not adjusted");
            candy_remaining = candy_stock;
        }
        else
        {
            Console.WriteLine($"Candy remaining: {candy_remaining}");
        }

        // Checks each item and sees if its less than each's restock value, if it is display the message.
        if (soda_remaining <= soda_restock)
        {
            Console.WriteLine("Soda needs to be restocked");
        }

        if (chips_remaining <= chips_restock)
        {
            Console.WriteLine("Chips need to be restocked");
        }

        if (candy_remaining <= candy_restock)
        {
            Console.WriteLine("Candy needs to be restocked");
        }
    }
}
