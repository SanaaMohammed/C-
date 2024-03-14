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