using System;
using System.Collections.Generic;

class Shop
{
    private List<Product> products;
    private Seller seller;

    public Shop(Seller seller)
    {
        products = new List<Product>();
        this.seller = seller ?? throw new ArgumentNullException(nameof(seller), "Продавец не может быть пустым.");
    }

    public void AddProduct(Product product)
    {
        if (products.Exists(p => p.Name == product.Name))
        {
            throw new Exception("Товар уже существует в магазине.");
        }

        products.Add(product);
    }

    public void SellProduct(Product product, decimal payment)
    {
        if (!products.Contains(product))
        {
            throw new Exception("Товар не найден в магазине.");
        }

        if (!seller.Pay(payment))
        {
            throw new Exception("Оплата не прошла.");
        }

        products.Remove(product);
    }

    public void LiquidateShop()
    {
        if (products.Count > 0)
        {
            throw new Exception("Магазин не может быть ликвидирован, пока есть товары.");
        }

        if (seller == null)
        {
            throw new Exception("Магазин не может быть ликвидирован, так как продавец не установлен.");
        }

        Console.WriteLine("Магазин ликвидирован.");
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Seller
{
    private decimal balance;

    public Seller(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public bool Pay(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW14_ex1_Mileshko \n");

        Seller seller = new Seller(1000);
        Shop shop = new Shop(seller);

        Product product1 = new Product { Name = "Product 1", Price = 200 };
        Product product2 = new Product { Name = "Product 2", Price = 400 };

        try
        {
            shop.AddProduct(product1);
            shop.AddProduct(product2);
            shop.AddProduct(product2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            shop.SellProduct(product1, 150);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            shop.SellProduct(product1, 250);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            shop.SellProduct(product1, 1000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            shop.SellProduct(product1, 400);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            shop.LiquidateShop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();

        shop = new Shop(seller);

        try
        {
            shop.LiquidateShop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        shop.AddProduct(product2);
        shop.SellProduct(product2, 400);

        try
        {
            shop.LiquidateShop();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}