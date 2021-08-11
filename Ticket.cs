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
        private int TicketID { get; set; }

        private string TicketDetails { get; set; }

        public bool IsAvailable { get; set; }

      /*  public void showTicketDetails()
        {
            Console.WriteLine("Show user ticket details" + TicketID);
        }
      */
    }
}
