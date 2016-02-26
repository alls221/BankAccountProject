﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Title();
                DisplayMenu();
                string choice = Console.ReadLine();
                int menuChoice;
                bool result = int.TryParse(choice, out menuChoice);
                if (result == true)
                {
                    if (menuChoice==5)
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                    else
                    {
                        switch(menuChoice)
                        {
                            case 1:// this is the view client information section, will need to call the client class
                                Clients client = new Clients();
                                Console.WriteLine(client.name);
                                Console.WriteLine(client.GetAccountnumber());
                                break;
                            case 2: // This is the view account balance section, will need to call the accounts class here
                                break;
                            case 3: // this is the deposit funds section, Deposit method is containted in the accounts class
                                break;
                            case 4: // this is the Withdraw funds sections, Withdraw method is in the accounts class
                                break;
                            default:// puts something for an error here
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter the number of the Menu item you wish to choose");
                    ReturnToMain();
                }
            }
        }

       static void Title ()// prints the project title to the screen
        {
            Console.WriteLine("***Bank Account System***\n\n\n");
        }
        static void ReturnToMain () // clears the console before returning to the main menu
        {
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
       static void DisplayMenu () // display's the main menu
        {
            string[] menu = { "Main Menu", "1- View Client Information", "2-View Account Balance", "3-Deposit Funds", "4- Withdraw Funds", "5- Exit" };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("Enter a menu option");
        }
    }
}