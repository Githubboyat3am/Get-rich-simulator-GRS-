using System;
using System.ComponentModel.Design;
using System.Xml;

namespace Get_rich_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* GRS Version 1.4
             * Fifth release 
             * added risk
             * I dont know what I will add next update
             */

            bool back_door_dash = false;
            int balance = 50;


            Console.WriteLine("WELCOME TO GET RICH SIMULATOR");
            Console.WriteLine("TYPE help FOR COMMANDS");

            const bool gameStart = true;
            

                while (gameStart == true)
                {
                Console.WriteLine();
               String input = Console.ReadLine();
                //+ or no money
                if (input == "help")
                {
                    Console.WriteLine();
                    Console.WriteLine("Type command balance to show your balance");
                    Console.WriteLine("Type command buy to go to the store");
                    Console.WriteLine("Type command invest to invest in stock");
                    Console.WriteLine("Type command job if you want to have a job");
                    Console.WriteLine("Type command real estate to buy a house");


                }
                else if (input == "balance")
                {
                    Console.WriteLine();
                    Console.WriteLine("Your balance is " + balance);
                }
                else if (input == "job")
                {
                    Console.WriteLine();
                    Console.WriteLine("These are the job listings");
                    Console.WriteLine("Work at back door dash");

                    string jobChoice = Console.ReadLine();

                    if (jobChoice == "back door dash")
                    {
                        if (back_door_dash == true)
                        {
                            Console.WriteLine("You're hired!");
                            Console.WriteLine("You have 5 deliveries");
                            Console.WriteLine("type deliver to get them done (5 dollars per delivery)");

                            string delivery = Console.ReadLine();

                            if (delivery == "deliver")
                            {
                                balance = balance + (5 * 5);
                                Console.WriteLine();
                                Console.WriteLine("You received your payment!");
                            }
                        }
                        else if (back_door_dash == false)
                        {
                            Console.WriteLine("You need a bicycle to do Back door dash!");
                        }

                    }
                }
                //- money
                else if (balance <= 0)
                {
                    Console.WriteLine("You're broke! no buying stuff from here");

                }
                else if (input == "buy")
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("Hamburger 5$");
                    Console.WriteLine("1 pound fish 2$ (Very Very Cheap)");
                    Console.WriteLine("Bicycle 20$");
                    Console.WriteLine("Water skis 50$");
                    string item = Console.ReadLine();

                    if (item == "Hamburger")
                    {
                        Console.WriteLine("Purchase made! -5$");
                        balance = balance - 5;
                    }
                    else if (item == "1 pound fish")
                    {
                        Console.WriteLine("Purchase made! -2$");
                        balance = balance - 2;
                    }
                    else if (item == "Bicycle")
                    {
                        Console.WriteLine("Purchase made! -20$");
                        balance = balance - 20;
                        back_door_dash = true;
                    }
                    else if (item == "Water skis")
                    {
                        Console.WriteLine("Purchase made! -50$");
                        balance = balance - 50;
                    }

                }
                else if (input == "invest")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are the investing options");
                    Console.WriteLine("Dougcoin (Return 5$ per dollar)");
                    Console.WriteLine("Index fund (Return 7$ per dollar)");
                    Console.WriteLine("Megasoft (Return 10$ per dollar)");
                    Console.WriteLine("Bitcoin (Return 12$ per dollar)");
                    string investment = Console.ReadLine();
                    Console.WriteLine("How much do you want to put in?");
                    int investDeposit = Convert.ToInt32(Console.ReadLine());
                    Random random = new Random();
                    int investReturn = random.Next(1, 3);

                    if (investment == "Dougcoin")
                    {

                        if (investReturn == 1)
                        {
                            balance = balance - investDeposit;
                            investDeposit = investDeposit * 5;
                            balance = balance + investDeposit;
                            Console.WriteLine("This investment was a winner!");
                        }
                        else if (investReturn == 2)
                        {
                            balance = balance - investDeposit;
                            Console.WriteLine("This investment lost you money!");
                        }
                    }

                    if (investment == "Index fund")
                    {
                        if (investReturn == 1)
                        {
                            balance = balance - investDeposit;
                            investDeposit = investDeposit * 7;
                            balance = balance + investDeposit;
                            Console.WriteLine("This investment was a winner!");
                        }
                        else if (investReturn == 2)
                        {
                            balance = balance - investDeposit;
                            Console.WriteLine("This investment lost you money!");
                        }
                    }
                    if (investment == "Megasoft")
                    {
                        if (investReturn == 1)
                        {
                            balance = balance - investDeposit;
                            investDeposit = investDeposit * 10;
                            balance = balance + investDeposit;
                            Console.WriteLine("This investment was a winner!");
                        }
                        else if (investReturn == 2)
                        {
                            balance = balance - investDeposit;
                            Console.WriteLine("This investment lost you money!");
                        }

                    }
                    if (investment == "Bitcoin")
                    {
                        if (investReturn == 1)
                        {
                            balance = balance - investDeposit;
                            investDeposit = investDeposit * 12;
                            balance = balance + investDeposit;
                            Console.WriteLine("This investment was a winner!");
                        }
                        else if (investReturn == 2)
                        {
                            balance = balance - investDeposit;
                            Console.WriteLine("This investment lost you money!");
                        }

                    }

                    else if (investDeposit > balance)
                    {
                        Console.WriteLine("You spent to much money on this investment");
                        balance = balance - investDeposit;
                    }
                }
                else if (input == "real estate")
                {
                    Console.WriteLine("These are the house listings");
                    Console.WriteLine("dump 200$");
                    Console.WriteLine("apartment 2000$");
                    Console.WriteLine("2 bedroom house 70000$");
                    Console.WriteLine("Suburban house 500000$");

                    string house = Console.ReadLine();


                    if (house == "dump")
                    {
                        Console.WriteLine("You have bought a dump! -200$");
                        balance = balance - 200;
                    }
                    else if (house == "apartment")
                    {
                        Console.WriteLine("You have bought a apartment! -2000$");
                        balance = balance - 2000;
                    }
                    else if (house == "2 bedroom house")
                    {
                        Console.WriteLine("You have bought a 2 bedroom house! -70000$");
                        balance = balance - 70000;
                    }
                    else if (house == "Suburban house")
                    {
                        Console.WriteLine("You have bought a Suburban house! -500000$");
                        balance = balance - 500000;
                    }

                }
                else if (input == "richmode")
                {
                    balance += 1000000; // Adds 1,000,000 to the player's balance
                    Console.WriteLine("Cheat activated! You now have $1,000,000.");
                }
            }  
        }
    }
}

