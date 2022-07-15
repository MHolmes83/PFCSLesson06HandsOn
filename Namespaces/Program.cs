using System;
using aliasName = csharpNamespace.myExample;

class UsingDirectives
{
    public static void Main()
    {
        aliasName.print();
    }
}

namespace csharpNamespace
{
    class myExample
    {
        public static void print()
        {
            Console.WriteLine("Example of using a using directive.");
        }
    }
}
    