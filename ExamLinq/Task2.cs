namespace ExamLinq;

public class Task2
{
    public static void Task_2()
    {
        var list = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Test",
                Price = 10,
            },
            new Product
            {
                Id= 2,
                Name = "Test",
                Price = 50,
            },
            new Product
            {
                Id = 3,
                Name = "Test",
                Price = 60,
            },
            new Product
            {
                Id= 4,
                Name = "Test",
                Price = 70,
            }
        };

        var result = list.MaxBy(x => x.Price);

        Console.WriteLine($"{result.Id}, {result.Name}, {result.Price}");
        
    }
}
