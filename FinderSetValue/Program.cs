using System;
using System.Collections.Generic;
using System.Linq;

namespace FinderSetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> testList = new() { 0, 1, 2, 3, 4, 5, 6, 7 };
            ulong expectedSum = 11;
            var finder = new Finder();

            finder.FindElementsForSum(testList, expectedSum, out var start, out var end);
            
            Console.WriteLine($"start = {start}");
            Console.WriteLine($"end = {end}");
            Console.WriteLine($"ExpectedSym = {expectedSum}, FactSum = {testList.ToArray()[start..end].Sum(x => x)}");
        }
    }
}