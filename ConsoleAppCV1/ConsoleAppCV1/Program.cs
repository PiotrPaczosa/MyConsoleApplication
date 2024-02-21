using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the transaction type (buy/sell)");          
            TransactionType trcType;
            string userInput = Console.ReadLine();

            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            var sign = trcType == 0 ? -1 : 1;

            Console.WriteLine("Please insert the Nominal");
            var nominal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the price");
            var price = Convert.ToDouble(Console.ReadLine());

            var result = nominal * price * sign;

            if (trcType == 0)
            {
                Console.WriteLine($"Transaction value is {result}");
            }
            else
            {
                Console.WriteLine("Please insert the original price");
                var orgprice = Convert.ToDouble(Console.ReadLine());
                var pl = (price - orgprice) * nominal;
                Console.WriteLine($"Transaction value is {result}");
                Console.WriteLine($"Profit/loss on a transaction is {pl}");
            }
            Console.ReadKey();
        }
    }
}
