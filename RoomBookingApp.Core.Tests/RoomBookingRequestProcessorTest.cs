using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;

namespace RoomBookingApp.Core;

public class RoomBookingRequestProcessorTest
{
    
    [Fact]
    public void should_return_room_booking_response_with_request_details()
    {
        
        var bookingRequest = new RoomBookingRequest
        {
            FullName = "Joey Bloggs",
            Email = "joey@example.com",
            Date = new DateTime(2021, 1, 1, 10, 0, 0),
        };
        // Arrange
        var processor = new  RoomBookingRequestProcessor();
        
        // Act
        RoomBookingResult result = processor.BookRoom(bookingRequest);
        
        // Assert
        Assert.NotNull(result);
        result.ShouldNotBeNull("Result was null");
        result.FullName.ShouldBe(bookingRequest.FullName);
        result.Email.ShouldBe(bookingRequest.Email);
        result.Date.ShouldBe(bookingRequest.Date);
    }
    
}