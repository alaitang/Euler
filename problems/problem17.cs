using System;

namespace Euler.problems
{
    class Problem17 : ProblemBase
    {


        public override string GetResult()
        {

            var num1 = new string[]{"","one",
"two",
"three",
"four",
"five",
"six",
"seven",
"eight",
"nine",
"ten",
"eleven",
"twelve",
"thirteen",
"fourteen",
"fifteen",
"sixteen",
"seventeen",
"eighteen",
"nineteen",
"twenty" };

            var num2 = new string[]{"","ten","twenty",
    "Thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
};

            var total = "onethousand".Length;

            for (int i = 1; i < 1000; i++)
            {
                var t = 0;
                var n = i;
                var s = "";

                t += num1[n / 100].Length;
                s += num1[n / 100] + " ";
                n %= 100;
                if (t > 0)
                {
                    t += 7;
                    s += " hundred ";
                    if (n > 0)
                    {
                        t += 3;
                        s += " and  ";
                    }
                }


                if (n >= 20)
                {
                    t += num2[n / 10].Length;

                    s += num2[n / 10] + " ";

                    n %= 10;
                }

                t += num1[n].Length;

                s += num1[n] + " ";

                total += t;

                //Console.WriteLine($"{i} = {s}");
            }


            return "This is problem 17 answner : " + total;
        }
    }
}
