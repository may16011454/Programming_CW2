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
            var people = Prompt.Select("Choose one of the option below: ", new[] { "Staff", "Customer"});
        }
    }
}
