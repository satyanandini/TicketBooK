using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class User
    {
        public User()
        {

        }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public Ticket Ticket { get; set; }

        public void ShowUserDetails()
        {
            Console.WriteLine("User Id: " + UserId + " and " + UserName);
            Console.WriteLine("User ticket details ");
            Ticket.showTicketDetails();
        }


    }
}