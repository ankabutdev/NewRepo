namespace ExamLinq;

public class Program
{
    public static void Main(string[] args)
    {
        // // LINQ
        // // Task 1 1
        //Task1.Task_1();

        // // Task 1 2
        //Task2.Task_2();


        // // Task 3 3
        //List<int> raqamlar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //List<int> juft = raqamlar.Where(r => r % 2 == 0).ToList();
        //int raqamSon = juft.Count;

        //Console.WriteLine("Juft raqamlar: " + string.Join(", ", juft));
        //Console.WriteLine("Raqam soni: " + raqamSon);

        // // Task 3 2
        //List<Clients> mijozlar = new List<Clients>()
        //{
        //    new Clients() { Name = "Ali", LastName = "Valiyev" },
        //    new Clients() { Name = "Nargiza", LastName = "Sultonova" },
        //    new Clients() { Name = "Husan", LastName = "Aliyev" }
        //};

        //var result = mijozlar.Select(x => x.Name + " " + x.LastName).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        // Task 4 1

        //List<int> list = new List<int>() { 5, 2, 8, 1, 9, 3, 6 };

        //var res = list.OrderBy(x => x).ToList();

        //foreach (var raqam in res)
        //{
        //    Console.WriteLine(raqam);
        //}


        // Task 4 2
        //List<string> list = new List<string>() { "Ali", "Vali", "Anvar", "Kimdur", "Nimadur", "salohiddin", "Saunnatov" };

        //var res = list.OrderBy(x => x).ToList();

        //foreach (var raqam in res)
        //{
        //    Console.WriteLine(raqam);
        //}


        // Task 6 1
        //List<int> list = new List<int>() { 5, -2, 8, -1, 9, 3, -6 };

        //bool var = list.All(x => x > 0);

        //if (var)
        //    Console.WriteLine("Musbat");
        //else
        //    Console.WriteLine("manfiy bor");

        // Task 7 1
        //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        //List<int> list2 = new List<int>() { 3, 4, 5, 6, 7 };

        //var result = list1.Intersect(list2).OrderBy(x => x).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        // Task 7 2
        //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        //List<int> list2 = new List<int>() { 3, 4, 5, 6, 7 };

        //var result = list1.Union(list2).OrderBy(x => x).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        // Task 7 6
        //List<string> list1 = new List<string>() { "Apple", "Banana", "Mango", "Orange" };
        //List<string> list2 = new List<string>() { "Melon", "Grapes", "Mango", "Peach" };

        //var result = list1.Concat(list2).Where(x => x.StartsWith("M")).OrderBy(x => x).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        // Task 7 4
        //List<string> list = new List<string>() { "Olma", "Mango", "Apelsin", "Gilos", "Aplesin" };

        //var result = list.Where(x => x.StartsWith("A")).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        // Task Dapper 
        DapperTask dapperTask = new DapperTask();
        dapperTask.dapperGetAll();

    }
}