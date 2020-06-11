using System;
using System.IO;
using System.Linq;

namespace Euler.problems
{
    class Problem22 : ProblemBase
    {


        public override string GetResult()
        {
            var content = File.ReadAllText(@"D:\gitfolder\Euler\p022_names.txt");
            var arr = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(arr.Length);

            arr = arr.Select(x => x.Substring(1, x.Length - 2)).OrderBy(x =>
                 {
                     return string.Join("", x.Select(c => (c - 'A').ToString().PadLeft(2, '0')));
                 }).ToArray();

            var len = arr.Length;
            long total = 0;
            for (int i = 1; i <= len; i++)
            {
                var t = arr[i - 1].Select(c => (c - 'A') + 1).Sum();
                var b = t * i;

                if (total <= 0 && total + b >= 0 || total >= 0 && total + b <= 0)
                {
                    Console.WriteLine(total + "," + b + "," + arr[i - 1] + "," + t);
                }

                total += b;
            }

            return "This is problem 22 answner : " + total;
        }
    }
}
