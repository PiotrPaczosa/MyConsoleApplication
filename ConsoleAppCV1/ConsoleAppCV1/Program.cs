using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCV1
{
    public enum TransactionType 
    { buy, sell }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the transaction type (buy/sell)");          
            TransactionType trcType;
            string userInput = Console.ReadLine();

            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            var sign = trcType == 0 ? -1 : 1;
            var factor = trcType == 0 ? 0 : 1;

            Console.WriteLine("Please insert the Nominal");
            var nominal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the price");
            var price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the original price");
            var orgprice = Convert.ToDouble(Console.ReadLine());

            var result = nominal * price * sign;
            var pl = (price - orgprice) * nominal * factor;

            Console.WriteLine($"Transaction value is {result}");
            Console.WriteLine($"Transaction profit/loss is {pl}");
            Console.ReadKey();
        }
    }
}
