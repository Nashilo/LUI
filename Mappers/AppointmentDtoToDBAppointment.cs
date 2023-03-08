using LUI.Booking;

namespace LUI.Mappers;

public static class AppointmentToBooking
{
    public static DBAppointment ToBooking(this AppointmentDto book)
    {
        return new DBAppointment()
        {
            Name = book.Name,
            AppointmentDate = book.AppointmentDate,
            Phone = book.Phone
        };
    }
    public static async Task<AppointmentDto> ToBooking(this DBAppointment book)
    {
        return new AppointmentDto()
        {
            Name = book.Name,
            AppointmentDate = book.AppointmentDate,
            Phone = book.Phone
        };
    }
}