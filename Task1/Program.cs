using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Test test = new Test();
            test.NewMapArray();
            
            for (int i = 0; i < test.mapArray.Length; i++)
            {
                test.mapArray[i].Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
            }

            var result = test.GetMapById(test.mapArray, 5);

            result.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }
      
    }
}
