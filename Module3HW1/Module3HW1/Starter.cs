using System;
using System.Collections.Generic;

namespace Module3HW1
{
    public class Starter
    {
        public Starter(IMyList<int> listToTest)
        {
            ListToTest = listToTest;
        }

        public IMyList<int> ListToTest { get; set; }

        public void Run()
        {
            ListToTest.Add(4);
            ListToTest.Add(5);
            ListToTest.Add(6);
            ListToTest.Add(7);

            Console.WriteLine($"List count: {ListToTest.Count}\nList capacity: {ListToTest.Capacity}");

            for (int i = 0; i < ListToTest.Count; i++)
            {
                Console.Write($"{ListToTest[i]} ");
            }

            Console.WriteLine();

            ListToTest.RemoveAt(0);
            ListToTest.Remove(5);

            bool isFound = ListToTest.Remove(6);
            Console.WriteLine(isFound);
            isFound = ListToTest.Remove(5);
            Console.WriteLine(isFound);

            Console.WriteLine($"List count: {ListToTest.Count}\nList capacity: {ListToTest.Capacity}");

            foreach (var item in ListToTest)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            ListToTest.AddRange(7, 32, 12, 776, 12, 6, 7);

            Console.WriteLine($"List count: {ListToTest.Count}\nList capacity: {ListToTest.Capacity}");

            foreach (var item in ListToTest)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            ListToTest.Sort(new IntegerComparator());

            foreach (var item in ListToTest)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
