using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsMethodOverloading
{//EDNA LYNN LAXA 
 //PROGRAMMING III 
 // 4.16.23 
 // CONSTRUCTORS , METHOD & OVERLOADING 
    internal class Program
    {
        static void Main(string[] args)
        {
            CarMethod();
            AccountDeposits(500);
            AccountWithdrawl(300);


        }

        public static void CarMethod()
        {
            //PART I ✔ 

            // -- MIMICKING DISPLAY ✔ 
            //Display
            //0 unassigned unassigned -Mileage 0
            //0 Toyota Rav4 -Mileage 0
            //2010 Hyundai Sonata -Mileage 100000

            Car defaultCar = new Car(); //Corresponds to default constructor 

            Car makeModelCar = new Car("Toyota", "Rav4"); // Corresponds to "new car" constructor 

            Car fullCar = new Car("Kia", "Soul", 2023, 940); // Corresponds to constructors w/ Make, Model, Year & Mileage) 

            Console.WriteLine(defaultCar.ToString()); //calling TO STRING to prompt format 
            Console.WriteLine(); //Spacing , easy to read when added. 
            Console.WriteLine(makeModelCar.ToString());//calling TO STRING to prompt format 
            Console.WriteLine();//Spacing , easy to read when added. 
            Console.WriteLine(fullCar.ToString());//calling TO STRING to prompt format 
            Console.WriteLine();//Spacing , easy to read when added. 



        } 

        //PART II // Can you teach me how to  do the updated part? I got lost in this section. 
                // 3. Deposit 500 into the account
                //4. Show the updated information
                //5. Deposit -15000 into the account
                //6. Show updated information // The number shouldn't have changed because a negative number was passed
                //// Test withdraw
                //7. Withdraw 300 from the account.
                //8. Display the updated information.
                //9. Withdraw -500 from the account.
                //10. Display the updated information. // No change since the amount was negative
        public static void AccountDeposits(double amount)
        {
            BankAccount Account = new BankAccount("Kitana");

            Account.Deposit(amount);
            Console.WriteLine(Account.ToString());
        }
        public static void AccountWithdrawl(double amount)
        {
            BankAccount BalanceAccount = new BankAccount("Kitana");

            BalanceAccount.WithDraw(amount);
            Console.WriteLine(BalanceAccount.ToString());
        }

     
    }
}
