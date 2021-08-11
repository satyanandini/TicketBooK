using System;

namespace TicketBooK
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1,"Satya");
            User user2  = new User(2, "Nandini");

            BookingSystem bookingsys = new BookingSystem();
            bookingsys.BookTicket(user1,"Ticket for Robo");
            Console.WriteLine("Ticket booking inprogress user1");
            bookingsys.BookTicket(user2, "Ticket for Harry Poter");

            user1.ShowUserDetails();

            user2.ShowUserDetails();

            bookingsys.ShowBookedTickets();
            bookingsys.ShowRemaingTickets();

        }
    }
}
