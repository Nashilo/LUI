using LUI.Booking;

namespace LUI.Mappers;

public static class TreatmentDtoToDBTreatment
{
    public static async Task<TreatmentDto> ToTreatmentDto(this DBTreatment dbTreatment)
    {
        return new TreatmentDto()
        {
            Id = dbTreatment.Id,
            Name = dbTreatment.Name,
            Cost = dbTreatment.Cost,
            TreatmentTypeId = dbTreatment.TreatmentTypeId
        };
    }
}