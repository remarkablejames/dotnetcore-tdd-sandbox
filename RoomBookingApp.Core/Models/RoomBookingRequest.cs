namespace RoomBookingApp.Core;

public class RoomBookingRequest
{
    public string FullName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public DateTime Date { get; set; }
}