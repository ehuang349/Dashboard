using Microsoft.AspNetCore.Mvc;
using dashboard.server.Helpers;
using dashboard.server.Models;
using Dashboard.Server.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dashboard.Server.Controllers
{
    [ApiController]
    [Route("api")]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardContext _context;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger, DashboardContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        [Route("generate_api_key")]
        public async Task<IActionResult> FetchOrStoreApiKey(string user, string type)
        {
            if (String.IsNullOrEmpty(user))
            {
                return BadRequest("User parameter is required");
            }

            var exists = await _context.ApiAccesses.Where(a => a.User == user && a.IsActive).FirstOrDefaultAsync();

            if (exists != null)
            {
                return BadRequest("User already has an existing api-key");
            }
            else
            {
                var apiKey = GlobalHelpers.GenerateApiKey();

                ApiAccess apiAccess = new ApiAccess
                {
                    CreatedAt = DateTime.Now,
                    ApiKey = apiKey,
                    User = user,
                    Type = "TOKENSTRING",
                    IsActive = true
                };

                _context.ApiAccesses.Add(apiAccess);
                await _context.SaveChangesAsync();
                return Ok(new { message = $"Api Access record was created!", apiKey = apiAccess.ApiKey });
            }
        }

        [HttpGet]
        [Route("get_all_weather_records")]
        public async Task<IActionResult> GetWeatherRecords()
        {
            return Ok(await _context.WeatherRecords.ToListAsync());
        }

        [HttpGet]
        [Route("get_weather")]
        public async Task<IActionResult> GetWeatherByCity(string city)
        {
            WeatherRecord records = await _context.WeatherRecords.Where(w => w.City == city).FirstOrDefaultAsync();
            if (records == null)
            {
                return NotFound(new { message = "Weather record not found." });
            }
            return Ok(records);
        }
    }
}
