﻿using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers;

public class HomeController : Controller
{
    private readonly IHolidaysApiService _holidaysApiService;
    public HomeController(IHolidaysApiService holidaysApiService)
    {
        _holidaysApiService = holidaysApiService;
    }
    public async Task<IActionResult> Index(string countryCode, int year)
    {
        List<HolidayModel> holidays = new List<HolidayModel>();

        if (!string.IsNullOrEmpty(countryCode) && year > 0)
        {
            holidays = await _holidaysApiService.GetHolidays(countryCode, year);
        }

        return View(holidays);
    }
}

