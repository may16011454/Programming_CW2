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

        static void Main(String[]args)
        {
            Console.Clear();

            MainMenu();
        }

        //Main Menu
        static void MainMenu()
        {
            Console.Clear();
            var menuChoice = Prompt.Select("Choose one of the option below: ", new[] { " Properties", "Cstomers", "Booking", "Purchases", "Issues" });

            if (menuChoice == "Propeties")
            {
                SelectProperty();
            }
            else if (menuChoice == "Booking")
            {

            }

        }

        //Properties

        static void SelectProperty()
        {
            var property = Prompt.Select("What is the kind of property do you want to manage", new[] {"Domestic", "Commercial"});

            if(property ==  "Domestic")
            {
                es.DomesticInfo.Add(CreateDomestic());
                Console.Clear();
                SelectProperty();
            }
            else
            {
                CreatedCommercial();
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
    }
}
