using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConstructorsMethodOverloading
{
    public class BankAccount
    {

        //Create a class: BankAccount✔ 

        //FIELDS ✔ 
        string _accountNumber;
        string _customerName;
        double _balance;


        //Constructor for all✔ 
        public BankAccount( string customerName) // When the properties took in an effect the parameters for acct # & balance were redline. I removed it to stop yelling at me. 
        {
            _accountNumber = "111211";
            CustomerName = customerName;
            _balance = 1000;
        }

        //Property - CustomerName { get; set; }✔ 
        //AccountNumber and Balance - {get;}read only✔ 
        public string AccountNumber { get => _accountNumber; } // ✔ 
        public string CustomerName { get => _customerName; set => _customerName = value; } //✔ 
        public double Balance { get => _balance; } //✔ 

        public void Deposit(double amount)
        {
            //Deposit(double amount) - When the user passes in a value, add that money to the account.Make sure the number isn't negative before adding.✔ 

            if (amount >= 0) // Restricted to only pass in positive numbers
            {
                _balance = _balance += amount; 
            }

        }
        public void WithDraw (double amount)
        {

            //Withdraw(double amount) - When the user passes in a value, withdraw that month from the account.

            if (amount >= 0) // Restricted to only pass in positive numbers
            {
                _balance = _balance -= amount;
            }

        }
        //override ToString()✔ 
        public override string ToString()
        {
            return $"BALLER BANK: \n Account Number: {_accountNumber} \n Customer Name: {_customerName} \n Current Balance: ${_balance}";  
        }

    }
}
