using DeskBooker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRquestProcessorTests
    {
        private readonly DeskBookingRequest _request;
        private readonly DeskBookingRequestProcessor _processor;


        public DeskBookingRquestProcessorTests()
        {
            
            _request = new DeskBookingRequest
            {
                FirstName = "Thomas",
                LastName = "Huber",
                Email = "brecinos@gmail.com",
                Date = new DateTime(2020, 1, 28)

            };
            _processor = new DeskBookingRequestProcessor();
        }


        [Fact]
        public void ShoudReturnDeskBookingResultwithRequestValues()
        {
           


            var processor = new DeskBookingRequestProcessor();

            //Act
            DeskBookingResult result  = processor.BookDesk(_request);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(_request.FirstName, result.FirstName);
            Assert.Equal(_request.LastName, result.LastName);
            Assert.Equal(_request.Email, result.Email);
            Assert.Equal(_request.Date, result.Date);
        }



        [Fact]
        public void ShouldSsaveDeskBooking() 
        {
            _processor.BookDesk(_request);
        }



    }
}
