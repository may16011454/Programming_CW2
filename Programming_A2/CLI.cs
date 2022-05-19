using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using static Programming_A2.Enums;

namespace Programming_A2
{
    public static class CLI
    {
        static CleaningSystem es = new CleaningSystem("SCS");

        static void Main(string[]args)
        {
            Console.Clear();

            MainMenu();
        }

        //Main Menu
        static void MainMenu()
        {
            Console.Clear();
            var menuChoice = Prompt.Select("Choose one of the option below: ", new[] { "Properties", "People", "Booking", "Purchases", "Issues" });

            if (menuChoice == "Properties")
            {
                SelectProperty();
            }
            else if (menuChoice == "Booking")
            {
                SelectBooking();
            }
            else if (menuChoice == "People")
            {
                SelectPeople();
            }
            else if (menuChoice == "Purchases")
            {
                SelectPurchase();
            }
            else if (menuChoice == "Issues")
            {
                SelectIssues();
            }
            else
            {
                Console.WriteLine("okay...");
            }

        }

        //Properties

        static void SelectProperty()
        {
            var property = Prompt.Select("What is the kind of property do you want to manage", new[] {"Domestic", "Commercial", "Menu"});

            if(property ==  "Domestic")
            {
                es.DomesticInfo.Add(CreateDomestic());
                Console.Clear();
                SelectProperty();
            }
            else if (property == "Commercial")
            {
                CreatedCommercial();
                Console.Clear();
                SelectProperty();
            }
            else
            {
                MainMenu();
            }
        }
        //method called to create a domestic property
        static Domestic CreateDomestic()
        {
            var address = Prompt.Input<string>("Enter your address: ");
            var type = Prompt.Select<DomesticType>("Waht type of property: ");
            var noRooms = Prompt.Input<int>("Enter the number of rooms: ");
            var customer = CreateCustomer();
            return new Domestic(address, customer,type ,noRooms );
        }

        //method to create a commercial property
        static Commercial CreatedCommercial()
        {
            var address = Prompt.Input<string>("Enter your address: ");
            var customer = CreateCustomer();
            var size = Prompt.Input<int>("Enter the size: ");
            return new Commercial(address, size);
        }


        //create customer

        static Customer CreateCustomer() 
        {
            var fname = Prompt.Input<string>("Enter first name: ");
            var sname = Prompt.Input<string>("Enter last name: ");
            var contact = Prompt.Input<string>("Enter Contact: ");
            return new Customer(fname, sname, contact);
        }



        //Booking

        static void SelectBooking()
        {
            var book = Prompt.Select("Choose: ", new[] { "Make new booking", "view bookings", "Menu" });

            if (book == "Make new booking")
            {
                es.BookingInfo.Add(CreateBookings());
                Console.Clear();
                SelectBooking();
            }
            else if (book == "view bookings")
            {
                foreach (var booking in es.BookingInfo)
                {
                    Console.WriteLine(booking);
                }
                SelectBooking();
            }
            else
            {
                MainMenu();
            }
        }

        static Booking CreateBookings()
        {
            var details = Prompt.Input<string>("Enter the details of booking: ");
            var customer = CreateCustomer();
            es.CustomerInfo.Add(customer);
            return new Booking(details, customer);
        }

        //People

        static void SelectPeople()
        {
            var people = Prompt.Select("Choose one of the option below: ", new[] { "Create Staff","View Staff", "Create Customer", "View Customer", "Menu"});

            if (people == "Create Staff")
            {
                es.StaffInfo.Add(CreateStaff());
                Console.Clear();
                SelectPeople();
            }
            else if (people == "View Staff")
            {
                foreach (var staff in es.StaffInfo)
                {
                    Console.WriteLine(staff);
                }
                SelectPeople(); 
            }
            else if (people == "Create Customer")
            {
                es.CustomerInfo.Add(CreateCustomer());
                Console.Clear();
                SelectPeople();
            }
            else if (people == "View Customer")
            {
                foreach (var cus in es.CustomerInfo)
                {
                    Console.WriteLine(cus);
                }
                SelectPeople();
            }
            else
            {
                MainMenu();
            }
        }

        //create staff
        static StaffMember CreateStaff()
        {
            var fname = Prompt.Input<string>("Enter first name: ");
            var sname = Prompt.Input<string>("Enter last name: ");
            var uname = Prompt.Input<string>("Enter username: ");
            var password = Prompt.Input<string>("Enter password: ");
            var contact = Prompt.Input<string>("Enter contact: ");
            var type = Prompt.Select<StaffType>("Type of Staff: ");
            return new StaffMember(fname, sname, uname, password, type);

        }

        //Purchases

        static void SelectPurchase()
        {
            var pur = Prompt.Select("Choose: ", new[] { "Add new purchase", "view purchases", "Menu" });

            if (pur == "Add new purchase")
            {
                es.PurchaseInfo.Add(CreatePurchase());
                Console.Clear();
                SelectPurchase();
            }
            else if (pur == "view purchases")
            {
                foreach (var purchase in es.PurchaseInfo)
                {
                    Console.WriteLine(purchase); 
                }
                SelectPurchase();
            }
            else
            {
                MainMenu();
            }
        }

        static Purchases CreatePurchase()
        {
            var desc = Prompt.Input<string>("Enter product description: ");
            var cost = Prompt.Input<double>("Enter product cost: ");
            var staff = CreateStaff();
            return new Purchases(desc, cost,staff);
        }

        //Issues

        static void SelectIssues()
        {
            var iss = Prompt.Select("Choose: ", new[] { "Add Issue", "View Issues", "Menu" });

            if (iss == "Add Issue")
            {
                es.IssueInfo.Add(CreateIssue());
                Console.Clear();
                SelectIssues();
            }
            else if (iss == "View Issues")
            {
                foreach (var issue in es.IssueInfo)
                {
                    Console.WriteLine(issue);
                }
                SelectIssues();
            }
            else
            {
                MainMenu();
            }

        }

        //create Major Issue

        static Major CreateIssue()
        {
            var desc = Prompt.Input<string>("Enter Issue description: ");
            var type = Prompt.Select<IssueSeverity>("Severity: ");
            return new Major(desc,type);

        }
    }
}
