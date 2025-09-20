
/*
    Example of using the 'is' operator in C#
 */
namespace GettingStartedWithC
{
    class IsOperator
    {
        static void Main(string[] args)
        {
            bool result=123 is int; // true
            Console.WriteLine(result);
        }
    }
}