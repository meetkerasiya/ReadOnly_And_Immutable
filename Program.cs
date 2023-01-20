using System.Collections.Immutable;
using System.Collections.ObjectModel;

class MyClass
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
        ReadOnlyCollection<int> rolist = list.AsReadOnly();
        ImmutableArray<int> imlist=list.ToImmutableArray<int>();

        Console.WriteLine("At start of program: ");
        Console.WriteLine("List");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ReadOnlyCollection");
        foreach (var item in rolist)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ImmutableArray");
        foreach(var item in imlist)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("After modification in originl list");
        list.Add(9);
        Console.WriteLine("List");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ReadOnlyCollection");
        foreach (var item in rolist)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ImmutableArray");
        foreach (var item in imlist)
        {
            Console.WriteLine(item);
        }

        Dictionary<int,string> students= new Dictionary<int,string>();
        students.Add(22, "Jay");
        students.Add(30, "Krupal");
        students.Add(31, "Meet");
        students.Add(33, "Bhayo");
        students.Add(35, "Mitesh");

        ReadOnlyDictionary<int, string> rostudents = new ReadOnlyDictionary<int, string>(students);

        ImmutableDictionary<int,string> imstudents=students.ToImmutableDictionary();


        Console.WriteLine("At start of program: ");
        Console.WriteLine("Dictionary");
        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ReadOnlyDictionary");
        foreach (var item in rostudents)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ImmutableDictionary");
        foreach (var item in imstudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("After modification in originl list");
        students.Add(21, "Sanjay");
        Console.WriteLine("Dictionary");
        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ReadOnlyDictionary");
        foreach (var item in rostudents)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ImmutableDictionary");
        foreach (var item in imstudents)
        {
            Console.WriteLine(item);
        }

    }
}