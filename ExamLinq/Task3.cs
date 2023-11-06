namespace ExamLinq;

public class Task3
{
    public static void Task_3()
    {
        var list = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "1",
                Price = 10,
            },
            new Product
            {
                Id= 2,
                Name = "2",
                Price = 50,
                ClientId = 2
            },
            new Product
            {
                Id = 3,
                Name = "3",
                Price = 60,
                ClientId = 1,
            },
            new Product
            {
                Id= 4,
                Name = "4Test",
                Price = 70,
                ClientId = 1,
            }
        };

        var clients = new List<Clients>
        {
            new Clients
            {
                Id = 1,
                Name = "C1Test",
                Description = "Test",

            },
            new Clients
            {
                 Id = 2,
                Name = "C1Test",
                Description = "Test",
            }
        };

        var res = clients.Join(
        list,
        mijoz => mijoz.Id,
        buyurtma => buyurtma.ClientId,
        (mijoz, buyurtma) => mijoz.Name
        );

        foreach (var item in res)
        {
            Console.WriteLine($"{item[1]}, {item[1]}, {item}");
        }
    }
}