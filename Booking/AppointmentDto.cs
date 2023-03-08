using Dapper;
using LUI.Models;

namespace LUI.Booking;

[Table("Appointment")]
public class AppointmentDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Phone { get; set; }
    // public int TreatmentId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public decimal Cost { get; set; }
    
    public TreatmentType? TreatmentType { get; set; }
    public Treatment? Treatment { get; set; }

}

