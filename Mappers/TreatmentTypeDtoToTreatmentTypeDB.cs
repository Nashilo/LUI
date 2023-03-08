using LUI.Booking;

namespace LUI.Mappers;

public static class TreatmentTypeDtoToDBTreatmentType
{
    public static async Task<TreatmentTypeDto> ToTreatmentTypeDto(this DBTreatmentType dbTreatmentType)
    {
        return new TreatmentTypeDto()
        {
            Id = dbTreatmentType.Id,
            Name = dbTreatmentType.Name
        };


    }
}