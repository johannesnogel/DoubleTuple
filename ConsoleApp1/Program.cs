using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("TupleSix");
            Console.WriteLine("TupleWithValues");
            Console.WriteLine("WithSortedList");

            Console.WriteLine("Choose number 1-3");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TupleSix();
                    break;

                case 2:
                    TupleWithValues();
                    break;

                case 3:
                    WithSortedList();
                    break;
            }
        }

        private static void WithSortedList()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(17, "Seitseteist");
            numberNames.Add(15, "Viisteist");
            numberNames.Add(18, "Kaheksateist");
            numberNames.Add(12, "Kaksteist");
            numberNames.Add(11, "Üksteist");

            foreach (var kvp in numberNames)
            {
                Console.WriteLine($".{kvp.Key}, {kvp.Value}");
            }
        }

        private static void TupleWithValues()
        {
            ValueTuple<int, string, string> valueTuple = (69, "string", "string2");
            Console.WriteLine(valueTuple.ToString());
        }

        private static void TupleSix()
        {
            var values = Tuple.Create(1, 2, 3, 4, 5, 6);
            TupleParem(values);
        }

        private static void TupleParem(Tuple<int, int, int, int, int, int> values)
        {
            Console.WriteLine(values.ToString());
        }
    }
}
