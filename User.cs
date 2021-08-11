using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class User
    {
        public User(int id,String Name)
        {
            this.UserId = id;
            this.UserName = Name;
        }
        private int UserId { get; set; }
        private string UserName { get; set; }

    //    public Ticket UseralocattedTicket { get; set; }

       /* public void ShowUserTicketDetails()
        {
            Console.WriteLine("User Id: " + UserId + " and " + UserName);
            Console.WriteLine("User ticket details ");
            if (UseralocattedTicket != null)
            {
            }
          
        }*/


    }
}