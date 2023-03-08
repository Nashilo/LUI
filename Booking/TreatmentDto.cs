namespace LUI.Booking;

public class TreatmentDto
{
    public int Id { get; set; }
    
    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
}