
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
            bool result2="Hello" is string; // true
            Console.WriteLine(result +"\n"+result2);
        }
    }
}