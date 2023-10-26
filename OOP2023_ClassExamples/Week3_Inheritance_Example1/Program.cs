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
                //=================== main menu =========================
                Console.Clear();
                Console.WriteLine("1. Open Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. Close Account");
                Console.WriteLine("4. Quit application");

                //HW
                Console.WriteLine("5. Deposit");
                Console.WriteLine("6. Transfer");
                Console.WriteLine("7. Withdraw");
                Console.WriteLine("8. Calculate Interest");

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

                    case 2: //Search

                        Console.WriteLine("Input Iban");
                        string iban = Console.ReadLine();
                        //short version
                        var myFoundAccount = myAccounts.SingleOrDefault(a => a.IBAN == iban);

                        if (myFoundAccount == null)
                        {
                            Console.WriteLine("Account not found");
                        }
                        else
                        {
                            Console.WriteLine($"IdCard: {myFoundAccount.IdCard}, " +
                                $"Balance: {myFoundAccount.Balance}, Opened Date: {myFoundAccount.OpenedDate.ToString("dd/MM/yyyy")},");

                            if (myFoundAccount.ClosedDate != null)
                            {
                                Console.WriteLine($"Closed date: {myFoundAccount.ClosedDate.Value.ToShortDateString()}");
                            }
                              
                         

                        }
                        Console.WriteLine("Press a key to go back to main menu...");
                        Console.ReadKey();
                        //long version
                        /*foreach (var a in myAccounts)
                        {
                            if(a.IBAN == iban)
                            {
                                //display the details
                                //stop the loop using break;
                            }
                        }*/

                        break;

                    case 3: //close account
                        Console.WriteLine("Input Iban");
                        string iban2 = Console.ReadLine();
                        //short version
                        var myFoundAccount2 = myAccounts.SingleOrDefault(a => a.IBAN == iban2);
                        if (myFoundAccount2 == null)
                        {
                            Console.WriteLine("Account not found");
                        }
                        else
                        {
                            myFoundAccount2.Active = false;
                            myFoundAccount2.ClosedDate = DateTime.Now;
                            Console.WriteLine("Account closed!");
                        }
                        Console.WriteLine("Press a key to go back to main menu...");
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.WriteLine("Bye bye! Press a key to continue...");
                        Console.ReadKey();
                        break;


                    case 7: //Withdraw

                        Console.WriteLine("Input Iban");
                        string iban3 = Console.ReadLine();
                        //short version
                        var myFoundAccount3 = myAccounts.SingleOrDefault(a => a.IBAN == iban3);
                        if (myFoundAccount3 == null)
                        {
                            Console.WriteLine("Account not found");
                        }
                        else
                        {
                            if (myFoundAccount3.GetType() == typeof(Savings) || myFoundAccount3.GetType() == typeof(Current))
                            {
                                //allowed to withraw
                            }
                            else
                            {
                                Console.WriteLine("Withrawal denied");
                            }
                        }

                        break;
                }

            } while (choice != 4); //keep repeating the loop WHILE choice is not number 4
        }
    }
}
