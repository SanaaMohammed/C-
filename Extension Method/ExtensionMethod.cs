
/*
    
   - An extension method in C# is a static method of a static class that can be invoked using the syntax of an instance method. 
    This feature allows developers to add new methods to the public contract of an existing CLR type,
    without having to sub-class it or recompile the original type.

    both calss and method must be static


*/


using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
namespace Csharp
{
    class ExtensionMethod
    {

        static void Main()
        {
            int x = 12345;
            int y = x.Mirror();

            string str = "123";
            str = str.Mirror2();

            Console.WriteLine(y);
            Console.WriteLine(str);
        }
        

    }

   

}
