using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Open Account
            //2. Search Account and show details
            //3. Close Account

            List<Account> myAccounts = new List<Account>();

            int choice = 0; 
            do
            {
                Console.WriteLine("1. Open Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. Close Account");
                Console.WriteLine("4. Quit application");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("What type of account you would like to open?");
                        Console.WriteLine("1. Savings");
                        Console.WriteLine("2. Current");
                        Console.WriteLine("3. Loan");
                        Console.WriteLine("4. Go Back");
                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        switch(choice2)
                        {
                            case 1:
                                Savings mySavingsAccount = new Savings();
                                Console.WriteLine("Type in IBAN:");
                                mySavingsAccount.IBAN = Console.ReadLine();
                                Console.WriteLine("Type in Client Id Card No:");
                                mySavingsAccount.IdCard = Console.ReadLine();

                                mySavingsAccount.Active = true;
                                mySavingsAccount.OpenedDate = DateTime.Now;

                                Console.WriteLine("Deposit amount? (Type 0 if no deposit)");
                                mySavingsAccount.Deposit(Convert.ToDouble(Console.ReadLine()));

                                Console.WriteLine("Interest rate? %: ");
                                mySavingsAccount.InterestRate = Convert.ToDouble(Console.ReadLine());

                                myAccounts.Add(mySavingsAccount);

                                Console.WriteLine("Account created!");
                                Console.WriteLine("Press a key to go back to main menu...");
                                Console.ReadKey();

                                break;

                            case 2: 
                                //Current
                                break;


                            case 3:
                                //Loan

                                Loan myLoanAccount = new Loan();
                                Console.WriteLine("Type in IBAN:");
                                myLoanAccount.IBAN = Console.ReadLine();
                                Console.WriteLine("Type in Client Id Card No:");
                                myLoanAccount.IdCard = Console.ReadLine();

                                myLoanAccount.Active = true;
                                myLoanAccount.OpenedDate = DateTime.Now;

                                Console.WriteLine("How much the loan will be?");
                                myLoanAccount.Deposit(Convert.ToDouble(Console.ReadLine()));

                                Console.WriteLine("Interest rate? %: ");
                                myLoanAccount.Interest = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Duration in months:");
                                myLoanAccount.Months = Convert.ToInt32(Console.ReadLine());

                                myAccounts.Add(myLoanAccount);

                                Console.WriteLine("Loan Account created!");
                                Console.WriteLine("Press a key to go back to main menu...");
                                Console.ReadKey();
                                break;
                        }

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.WriteLine("Bye bye! Press a key to continue...");
                        Console.ReadKey();
                        break;
                }

            } while (choice != 4); //keep repeating the loop WHILE choice is not number 4
        }
    }
}
