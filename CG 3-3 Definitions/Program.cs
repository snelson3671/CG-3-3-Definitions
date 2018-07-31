using System;

namespace CG_3_3_Definitions
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERAND can equate to a noun in english.  It's what we want to do something with.
            // In the following line, the operands are x and 4.
            int x = 4;
            // OPERATOR can equate to a verb in english.  It does something.
            // In the following line, the operators are int, =, and ;
            int y = 9;
            // EXPRESSIONS are lines of code that are not a complete thought.  
            // In the following line, int z and x + y are expressions.
            int z = x + y;
            // STATEMENTS are complete thoughts.  They contain operators and operands.
            // They end with a ;.  The following two lines are both statements.
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
