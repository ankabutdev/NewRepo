namespace ExamLinq;

public static class Task1
{
    public static void Task_1()
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

        var result = list.FindAll(x => x.Price < 50);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
        }
    }
}
