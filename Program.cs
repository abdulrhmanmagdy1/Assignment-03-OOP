using Assignment_03_OOP.Core;
using Assignment_03_OOP.Models;
using System.Net.Sockets;

namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 02 - Practical

            Cinema cinema = new Cinema("Galaxy Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            Console.WriteLine("\n========== All Tickets ==========");
            cinema.PrintAllTickets();

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            cinema.CloseCinema();

            #endregion
        }

        #region Part 01 - Theoretical Questions

        /*
        Q1 Relationships:

        a) University → Departments
           Composition (departments die with university)

        b) Driver uses Car
           Association

        c) Dog is an Animal
           Inheritance

        d) Team has Players (players live after team deleted)
           Aggregation

        e) Method receives Logger as parameter
           Dependency
        */

        /*
        Q2 Access Modifiers & Sealed:

        a)
        Protected field:
        - Accessible in child class even in different assembly.
        - NOT accessible from outside through object instance.

        b)
        protected internal:
           Accessible in same assembly OR derived class.

        private protected:
           Accessible only in same assembly AND derived class.

        c)
        sealed class:
           Cannot be inherited.

        sealed method:
           Cannot be overridden further.

        d)
        Yes, you can create object from sealed class.
        sealed only prevents inheritance, not instantiation.
        */

        #endregion
    }
}