using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
namespace Csharp
{

    //delegate used by event
    public delegate void StockPriceChangeHandler(Stock stock, decimal OldPrice);
    class program //subscriber ( used event and take the action)
    {

        static void Main()
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;

            stock.OnStockPriceChange += Stock_OnStockPriceChange; // Subscribe
            Console.WriteLine($"Stock Price befor Change ${stock.Price}\n\n");

            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0.0m);

            stock.OnStockPriceChange -= Stock_OnStockPriceChange; // Unsubscribe
            stock.ChangeStockPriceBy(0.8m);

            Console.ReadKey();

        }
        private static void Stock_OnStockPriceChange(Stock stock, decimal OldPrice)
        {
            string status = "";
            if (stock.Price > OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "UP";
            }
            else if (stock.Price < OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"Stock {stock.Name} Price {stock.Price}: {status}");
        }
    }






}