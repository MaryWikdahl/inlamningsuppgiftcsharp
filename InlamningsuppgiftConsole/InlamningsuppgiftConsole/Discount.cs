using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsuppgiftConsole
{
    public static class Discount
    {
        public static string Code { get; set; }
        public static string GenerateDiscountCode()
        {
          var Code = "Rabatt-" + DateTime.Now.Millisecond;
            return Code;
        }

        public static void SendOutDiscountCode(List<MyCustomer> customers)
        {
            foreach(var customer in customers)
                Console.WriteLine($"Skickar ut rabattkod {Code} till {customer.Email}");
        }
    }
}
