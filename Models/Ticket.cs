using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Models
{
    public class Ticket
    {
        private static int counter = 0;

        private decimal price;

        public int TicketId { get; }
        public string MovieName { get; set; }

        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;

            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets()
        {
            return counter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}
