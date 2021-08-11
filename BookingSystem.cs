using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class BookingSystem
    {
        public int TotalTickets { get; set; }

        public int TotalBookTickets;

        public int TotalRemaingTickets { get; set; }

        List<Ticket> Ticketlist = new List<Ticket>();
        static int ticketid;

        string BookingDetail { get; set; };
        public void BookTicket(User user,)
        {
            CreateTicket(ticketid,);
            user.Ticketid = 
            TotalBookTickets = Ticketlist.Count;
        }

        private Ticket CreateTicket()
        {
            Ticketlist.Add(new Ticket(1, "ticketforRAKI"));
            Console.WriteLine("Ticket created");
            Ticketlist.
        }
    }
}
