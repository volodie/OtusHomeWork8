using System.Xml.Linq;
using OtusHomeWork8;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree tree = new Tree();

        Dictionary<string, int> Employee = new Dictionary<string, int>
                    {
                        {"Яша", 20},
                        {"Сева", 1},
                        {"Вася", 6},
                        {"Аня", 3},
                        {"Петя", 14},
                        {"Даша", 9}
                    };
        ReadParametrs readParametr = new ReadParametrs();
        //while (true)
        //{
        //    Console.WriteLine("Введите имя сотрудника.");
        //    var EmployeName = readParametr.ReadTextFromConsole();
        //    if (string.IsNullOrEmpty(EmployeName))
        //    {
        //        break;
        //    }
        //    Console.WriteLine("Введите зарплату сотрудника.");
        //    var Salary = readParametr.ReadNumbersFromConsole();
        //    tree.Add(new Nodes(EmployeName, Salary));
        //}
        foreach (var item in Employee)
        {
            tree.Add(new Nodes(item.Key, item.Value));
        }


        tree.PrintTree();
        Console.WriteLine("Введите искомую зарплату сотрудника сотрудника.");

        var _Salary = readParametr.ReadNumbersFromConsole();

        string result = tree.Find(_Salary);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
