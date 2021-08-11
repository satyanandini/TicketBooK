using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class Ticket
    {
        public Ticket(int tick,string Details)
        {
            this.TicketID = tick;
            this.TicketDetails = Details;
        }
        public int TicketID { get; set; }

        string TicketDetails { get; set; }

        public void showTicketDetails()
        {
            Console.WriteLine("Show user ticket details" + TicketID);
        }
    }
}
