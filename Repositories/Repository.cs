using System.Data;
using System.Data.SqlClient;
using Dapper;
using LUI.Booking;
using LUI.Mappers;
using LUI.Models;

namespace LUI.Repositories;

public class Repository : IRepository
{
    private readonly IDbConnection _connection;

    public Repository()
    {
        _connection =
            new SqlConnection(
                $"Server=127.0.0.1,49697;Database=LuiSpa;User Id=sa;Password=280603;MultipleActiveResultSets=True;TrustServerCertificate=True");

    }



    // public async Task<List<TreatmentDto>> GetTreats()
    // {
    //     _connection.Open();
    //     var sql = "SELECT * From Treatment";
    //     var treats = (List<TreatmentDto>)await _connection.QueryAsync<DBTreatment>(sql);
    //     _connection.Close();
    //     return treats;
    // }

    public async Task<List<DBTreatmentType>> GetTreatType()
    {
        _connection.Open();
        var sql = "SELECT * From TreatmentType";
        var type = (List<DBTreatmentType>)await _connection.QueryAsync<DBTreatmentType>(sql);
        _connection.Close();
        return type;
    }

    public async Task<Treatment> GetTreatById(int id)
    {
        _connection.Open();
        var sql = "SELECT * From Treatment WHERE TreatmentTypeId = @TreatmentTypeId";
        var treats = await _connection.QuerySingleAsync<Treatment>(sql, new { TypeId = id });
        _connection.Close();
        return treats;
    }

    //Book Appointment
    public async Task<AppointmentDto> BookAppointment(AppointmentDto appointment)
    {
        _connection.Open();
        var mappedAppointment = appointment.ToAppointmentDto();
        var result = await _connection.InsertAsync(mappedAppointment);
        Console.WriteLine(result);
        _connection.Close();
        return appointment;
    }

    public async Task<List<TreatmentDto>> GetTreatments()
    {
        _connection.Open();
        var sql = "SELECT * FROM Treatment";
        var Treat = await _connection.QueryAsync<DBTreatment>(sql);
        var treats = new List<TreatmentDto>();

        foreach (var treat in Treat)
        {
            treats.Add(await treat.ToTreatmentDto());
        }
        _connection.Close();
        return treats.ToList();
    }
  public async Task<List<TreatmentTypeDto>> GetTreatmentType()
    {
        _connection.Open();
        var sql = "SELECT * FROM TreatmentType";
        var Type = await _connection.QueryAsync<DBTreatmentType>(sql);
        var types = new List<TreatmentTypeDto>();

        foreach (var type in Type)
        {
            types.Add(await type.ToTreatmentTypeDto());
        }
        _connection.Close();
        return types.ToList();
    }



}
   