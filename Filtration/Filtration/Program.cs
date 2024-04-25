using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Diagnostics;
using Filtration;

short select = 0;

Console.Write("\n\t1.Add Product\n" +
    "\t2.Sort Products\n" +
    "\t3.Filter Products\n" +
    "\tEnter your choice: ");

select = Int16.Parse(Console.ReadLine());

switch (select)
{
    case 1:
        AddProduct();
        break;

    case 2:
        SortProduct();
        break;

    case 3:
        FilterProduct();
        break;
}

void AddProduct()
{
    string name;
    string studio;
    string description;
    int price;

    Console.Write("\n\tEnter Name of Product: ");
    name = Console.ReadLine();

    Console.Write("\n\tEnter Description of Product: ");
    description = Console.ReadLine();

    Console.Write("\n\tEnter Price of Product: ");
    price = Convert.ToInt32(Console.ReadLine());

    Console.Write("\n\tEnter studio of Product: ");
    studio = Console.ReadLine();

    using var context = new StoreDbContext();
    context.Game.Add(new Game(name, studio, description, price));
    context.SaveChanges();
}

void SortProduct()
{
    short choice = 0;

    Console.Write("\n\t1.By Name\n" +
    "\t2.By Price\n" +
    "\tEnter your choice: ");

    choice = Int16.Parse(Console.ReadLine());

    using var context = new StoreDbContext();

    switch (choice)
    {
        case 1:
            var sortedByName = context.Game.OrderBy(p => p.Name);
            break;

        case 2:
            var sortedByPrice = context.Game.OrderBy(p => p.Price);
            break;
    }

    context.SaveChanges();
}

void FilterProduct()
{
    short choice = 0;
    string filter = string.Empty;

    Console.Write("\n\t1.By studio\n" +
    "\t2.By Price\n" +
    "\tEnter your choice: ");

    choice = Int16.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("\n\tEnter studio to Filter: ");
            filter = Console.ReadLine();
            break;

        case 2:
            Console.WriteLine("\n\tEnter Min Price to Filter: ");
            filter = Console.ReadLine();
            break;
    }

    using var context = new StoreDbContext();
    switch (choice)
    {
        case 1:
            var filteredBystudio = context.Game.Where(p => p.Studio == filter);
            break;

        case 2:
            var filteredByPrice = context.Game.Where(p => p.Price > Convert.ToSingle(filter));
            break;
    }

    context.SaveChanges();
}