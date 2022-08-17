using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRquestProcessorTests
    {
        [Fact]
        public void ShoudReturnDeskBookingResultwithRequestValues()
        {
            var request = new DeskBookingRquest
            {
                FirstName = "Thomas",
                LastName = "Huber",
                Email = "brecinos@gmail.com",
                Date = new DateTime(2020, 1, 28)
            };


            var processor = new DeskBookingRequestProcessor();
            processor.BookDesk(request);
        }

    }
}
