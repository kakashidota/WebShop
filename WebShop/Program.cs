

using WebShop.ProductData;

namespace WebShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kommertar

            List<Product> inventory = new List<Product>()
            {
                new Book {Name = "PotatoTech", Brand = "Potatoes united", Price = 99.99, Author = "Robin Kamo"},
                new Clothing {Name = "Polo by poolo", Brand = "Temu", Price = 59.99, Size = "L"},
                new Electronics {Name = "Iphone", Brand = "Apple", Price = 9999.99, WarrantyYears = 3},
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("=== Tamims WebShop Admin Panel ===");
                Console.WriteLine("[1]. Lägg till Produkt");
                Console.WriteLine("[2]. Lista produker");
                Console.WriteLine("[3]. Antal produkter");
                Console.WriteLine("[4]. Totalt värde");
                Console.WriteLine("[5]. Ändra global rabatt");
                Console.WriteLine("[6]. Avsluta");

                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        AddProductMenu(inventory);
                        break;
                    case 2:
                        ListProducts(inventory);
                        break;
                    case 3:
                        Console.WriteLine(Product.TotalCount);
                        break;
                    case 4:
                        Console.WriteLine($"The total value of your inventory is {CalculateTotalValue(inventory)}");
                        break;
                    case 5:
                        ChangeGlobalDiscount();
                        Console.WriteLine("The discount is now added to all the products");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }

            static void AddProductMenu(List<Product> i)
            {
                Console.WriteLine("[1]. Book");
                Console.WriteLine("[2]. Electronics");
                Console.WriteLine("[3]. Clothing");

                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Book b = new Book();
                        FillCommonFields(b);
                        Console.Write("Author: ");
                        b.Author = Console.ReadLine();
                        i.Add(b);
                        break;
                    case 2:
                        Electronics e = new Electronics();
                        FillCommonFields(e);
                        Console.Write("Warranty (years): ");
                        e.WarrantyYears = int.Parse(Console.ReadLine());
                        i.Add(e);
                        break;
                    case 3:
                        Clothing c  = new Clothing();
                        FillCommonFields(c);
                        Console.Write("Size: ");
                        c.Size = Console.ReadLine();
                        i.Add(c);
                        break;
                    default:
                        break;
                }
            }

            static void FillCommonFields(Product p)
            {
                Console.Write("Name: ");
                p.Name = Console.ReadLine();
                Console.Write("Brand: ");
                p.Brand = Console.ReadLine();
                Console.Write("Price: ");
                p.Price = double.Parse(Console.ReadLine());
            }


            static void ListProducts(List<Product> products)
            {
                foreach(Product p in products)
                {
                    Console.WriteLine(p.ProudctDetails());
                }
            }


            static double CalculateTotalValue(List<Product> produtcs)
            {

                double sum = 0;
                foreach (Product p in produtcs)
                {
                    sum += p.Price;
                }

                return sum;
            }

            static void ChangeGlobalDiscount()
            {
                Console.Write("New discount in %: ");
                double percent = double.Parse(Console.ReadLine());
                Product.SetGlobalDiscountPercent(percent);
            }
        }
    }
}
