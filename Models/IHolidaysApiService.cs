using System;
namespace Lab4.Models
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }
}

