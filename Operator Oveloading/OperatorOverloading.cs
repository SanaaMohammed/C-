using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
namespace Csharp
{
    class OperatorOverloading
    {

        static void Main()
        {
            Money money1 = new Money(100);
            Money money2 = new Money(20);

            // Operator Overloading
            Money money3 = money1 + money2;
            Money money4 = money1 - money2;
            Money money5 = money1 * money2;
            Money money6 = money1 / money2;

            Console.WriteLine($"Money after applaing Operator Overloading in +  = {money3.Amount}");
            Console.WriteLine($"Money after applaing Operator Overloading in -  = {money4.Amount}");
            Console.WriteLine($"Money after applaing Operator Overloading in *  = {money5.Amount}");
            Console.WriteLine($"Money after applaing Operator Overloading in /  = {money6.Amount}");


        }

    }


}