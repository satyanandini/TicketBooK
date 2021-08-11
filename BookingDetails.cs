using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooK
{
    public class BookingDetails
    {
        public User UserInfo { get; set; }

        public Ticket TicketInfo { get; set; }

        public DateTime BookingDateTime { get; set; }
    }
}
