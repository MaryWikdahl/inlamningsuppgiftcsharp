using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsuppgiftConsole
{
    public class Customer
    {
       
        public Customer(int index, string name, string lastName, string email)
        {
            Index= index;
            Name = name;
            LastName = lastName;
            Email = email;
        }
        
        public int Index { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        public string FullName => $"{Name} {LastName}";

        public string AllCustomerData()
        {
            return Index + " " + FullName + " " + Email ;
        }
    }
    public class  MyCustomer : Customer
    {
        public MyCustomer(int index, string name, string lastName, string email, string drinkpref, string foodpref) : base(index, name, lastName, email)
        {

            DrinkPref = drinkpref;
            Foodpref = foodpref;

        }

        
        

        public string Foodpref { get; set; }

        public string DrinkPref { get; set; }
        


        public string ConvertToCommaSeparatedList()
        {
            return $"{Name},{LastName},{Email},{DrinkPref},{Foodpref}";
        }
    }
    


}
    

