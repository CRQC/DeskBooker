﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeskBooker.Core.Domain
{
    public class DeskBookingRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }


    }
}
