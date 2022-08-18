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
            
            var request = new DeskBookingRequest
            {
                FirstName = "Thomas",
                LastName = "Huber",
                Email = "brecinos@gmail.com",
                Date = new DateTime(2020, 1, 28)

            };


            var processor = new DeskBookingRequestProcessor();

            //Act
            DeskBookingResult result  = processor.BookDesk(request);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }

    }
}
