using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class BookingSystem
    {
        public BookingSystem()
        {
            this.TotalTicketsCount = 60;

            //populate total tickets
            //write methods call create ticket and add to totalticket list

            
        }
        private readonly int TotalTicketsCount;

        private List<BookingDetails> bookingHistory = new List<BookingDetails>();

        private List<Ticket> TotalTickets = new List<Ticket>();

        public int AvailableTicketsCount
        {
            get { return TotalTickets.Where((Ticket) => Ticket.IsAvailable == true).Count(); }
        }

      
        public async Task<BookingDetails> BookTicket(User user)
        {
            // Check the tickects availabity
            // assign a ticket to particular user  (update ticket availabilty as false)
            // Add to Booking History
            // return BookingDetails;
           
        }

        private async Task<Ticket> CreateTicket(int id,string details)
        {
            Ticket ticket = new Ticket(ticketid, details);
            Ticketlist.Add(ticket);
            ticketid++;
            Console.WriteLine("Ticket created");
           return await Task.Run( )
           // return ticket;
        }

        public void ShowRemaingTickets()
        {
            Console.WriteLine("Remaining Tickets "+ TotalRemaingTickets);
        }

        public void ShowBookedTickets()
        {
            Console.WriteLine("Remaining Tickets " + TotalBookTickets);
        }
    }
}
