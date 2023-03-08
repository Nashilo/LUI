using LUI.Booking;

namespace LUI.Mappers;

public static class TreatmentToTreatmentType
{
    public static  DBTreatment ToTreatmentDto(this TreatmentDto treatmentDto)
    {
        return new DBTreatment()
        {
            Id = treatmentDto.Id,
            Name = treatmentDto.Name,
            Cost = treatmentDto.Cost,
            TreatmentTypeId = treatmentDto.TreatmentTypeId
        };
    }
}