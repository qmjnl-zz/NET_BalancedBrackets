using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalancedBrackets
{
    class Program
    {
        private struct BalanceCase
        {
            public string Expression { get; set; }
            public bool IsBalanced { get; set; }
        }

        private static readonly List<BalanceCase> BalanceCases = new List<BalanceCase>() {
            new BalanceCase() { Expression = "((1+3)()(4+(3-5)))", IsBalanced = true },
            new BalanceCase() { Expression = "", IsBalanced = true },
            new BalanceCase() { Expression = "()", IsBalanced = true },
            new BalanceCase() { Expression = "(i)", IsBalanced = true },
            new BalanceCase() { Expression = "(l))", IsBalanced = false },
            new BalanceCase() { Expression = "((a)", IsBalanced = false },
            new BalanceCase() { Expression = ")", IsBalanced = false },
            new BalanceCase() { Expression = "(", IsBalanced = false }
        };



        static bool IsBalanced(string text, char open = '(', char close = ')')
        {
            var level = 0;
            foreach (var character in text)
            {
                if (character == close)
                {
                    if (level == 0)
                    {
                        return false;
                    }
                    level--;
                }
                if (character == open)
                {
                    level++;
                }
            }
            return level == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n  BalancedBrackets Test\n-------------------------\n");
            foreach (var item in BalanceCases)
            {
                Assert.AreEqual(item.IsBalanced, IsBalanced(item.Expression));
                Console.WriteLine("  {0,18}  {1,8}\n", item.Expression, item.IsBalanced);
            }
        }
    }
}
