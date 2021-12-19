

// See https://aka.ms/new-console-template for more information
using InlamningsuppgiftConsole;
using static InlamningsuppgiftConsole.Discount;

using static InlamningsuppgiftConsole.Customer;
{
    var customerlist = new List<MyCustomer>();
    string filePath = "minakunder.txt";
    
    try
    {
        var minakunder = File.ReadAllLines(filePath);
        foreach (var customerInText in minakunder)
        {
            var splitCustomerInText = customerInText.Split(',');
            customerlist.Add(new MyCustomer(customerlist.Count, splitCustomerInText[0], splitCustomerInText[1], 
                splitCustomerInText[2], splitCustomerInText[3], splitCustomerInText[4]));

        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("FEL! Meddelande " + ex.Message);
    }

  
    var Choice = 0;

   
    do
    {

        Console.WriteLine("[1] Lägg till i lista");

        Console.WriteLine("[2] Visa listan");

        Console.WriteLine("[3] Få rabattkod");

        Console.WriteLine("[4] Radera från listan");

        Console.WriteLine("[0] Avsluta");

        try
        {
            Choice = int.Parse(Console.ReadLine());
        }

        catch (Exception X)
        {
            Console.WriteLine("FEL! Meddelande " + X.Message);
        }
       
        

        
        switch (Choice)
        {

            case 1:
                Console.WriteLine("Skriv in ditt förnamn");
                var firstName = Console.ReadLine();
                Console.WriteLine("Skriv in ditt efternamn");
                var lastName = Console.ReadLine();
                Console.WriteLine("Skriv in din email");
                var email = Console.ReadLine();
                Console.WriteLine("Skriv in ditt dryckesval");
                var drinkPref = Console.ReadLine();
                Console.WriteLine("Skriv in din matpreferens");
                var foodpref = Console.ReadLine();
                customerlist.Add(new MyCustomer(customerlist.Count, firstName, lastName, email, drinkPref, foodpref));
                FileHandler.SaveToFile(filePath, customerlist);
                break;

            case 2:
                foreach (var name in customerlist)
                    Console.WriteLine(name.AllCustomerData()+ "\n");
               
                break;
            case 3:
                var code = GenerateDiscountCode();
                Console.WriteLine(code);
                SendOutDiscountCode(customerlist);
                break;
            case 4:
                Console.WriteLine("Välj nummer på en av de följande kunder som du vill radera");
                foreach (var name in customerlist)
                Console.WriteLine(name.AllCustomerData() + "\n");
                var   i = int.Parse(Console.ReadLine());
                customerlist.RemoveAt(i);
                FileHandler.SaveToFile(filePath, customerlist);
                break;
           case 0:
                Choice = 0;
                break;
            default:
                Console.WriteLine("\nVälj en siffra mellan 0-4.\n");
                break;
        }
    }

    while (Choice >= 1);
}













