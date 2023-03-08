using LUI.Booking;

namespace LUI.Mappers;

public static class DBAppointmentToAppointmentDto
{
    public static DBAppointment ToAppointmentDto(this AppointmentDto app)
    {
        return new DBAppointment()
        {
            Name = app.Name,
            Phone = app.Phone,
            AppointmentDate = app.AppointmentDate,
            Treatment = app.Treatment,
            TreatmentType = app.TreatmentType
            
        };
    }
}