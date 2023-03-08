using LUI.Booking;

namespace LUI.Mappers;

public static class DBTreatmentTypeToTreatmentDto
{
    public static DBTreatmentType ToTreatmentTypeDto(this TreatmentTypeDto treatmentTypeDto)
    {
        return new DBTreatmentType()
        {
            Id = treatmentTypeDto.Id,
            Name = treatmentTypeDto.Name,
            
        };
    }
}