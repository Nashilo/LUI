namespace LUI.Models;

public class Treatment
{
    public int Id { get; set; }
    
    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
}