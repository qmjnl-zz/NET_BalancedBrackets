using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
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
            Console.WriteLine(IsBalanced("((1+3)()(4+(3-5)))"));
        }
    }
}
