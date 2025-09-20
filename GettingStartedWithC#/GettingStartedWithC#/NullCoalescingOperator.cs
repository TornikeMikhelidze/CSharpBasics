

namespace GettingStartedWithC_
{
    class NullCoalescingOperator
    {
        static void Main(string[] args)
        {
            string? name = null;
            string displayName = name ?? "Guest"; // If name is null, use "Guest"
            Console.WriteLine(displayName); // Output: Guest

            name = "Alice";
            displayName = name ?? "Guest"; // Now name is not null
            Console.WriteLine(displayName); // Output: Alice
        }
    }
}
