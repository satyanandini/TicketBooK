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

        string BookingDetail { get; set; }
        public void BookTicket(User user,string TicketDetails)
        {
            user.UseralocattedTicket = CreateTicket(ticketid, TicketDetails);
            TotalBookTickets = Ticketlist.Count;
            TotalRemaingTickets = TotalTickets - TotalBookTickets;
        }

        private Ticket CreateTicket(int id,string details)
        {
            Ticket ticket = new Ticket(ticketid, details);
            Ticketlist.Add(ticket);
            ticketid++;
            Console.WriteLine("Ticket created");
            return ticket;
        }

        public void ShowRemaingTicket()
        {
            Console.WriteLine("Remaining Tickets "+ TotalRemaingTickets);
        }
    }
}
