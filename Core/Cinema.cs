using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_03_OOP.Models;

namespace Assignment_03_OOP.Core
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector;

        public string CinemaName { get; set; }

        public Cinema(string name)
        {
            CinemaName = name;
            projector = new Projector(); // Composition
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            projector.Stop();
        }
    }
}