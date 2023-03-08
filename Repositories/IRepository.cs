using LUI.Booking;

namespace LUI.Repositories;

public interface IRepository
{
    //public Task<Booking.Booking> Book(Booking.Booking client);
    //public Task<Treatments> GetTypeOfTreatmentById(int treatId);

    // public Task<List<DBTreatment>> GetTreats();
    public Task<List<DBTreatmentType>> GetTreatType();
    public Task<AppointmentDto> BookAppointment(AppointmentDto appointment);
    public Task<List<TreatmentDto>> GetTreatments();
    public Task<List<TreatmentTypeDto>> GetTreatmentType();



    //public Task<Treatment> GetCost(int id); 
}