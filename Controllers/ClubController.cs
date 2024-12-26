using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc.Data;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Controllers
{
    [Route("[controller]")]
    public class ClubController : Controller
    {
        // private readonly ILogger<ClubController> _logger;

        // public ClubController(ILogger<ClubController> logger)
        // {
        //     _logger = logger;
        // }

        // private readonly ApplicationDBContext _context;
        //that's how controller connect with database and connect it to the view

        // adding repository to the controller
        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            // var clubs = _context.Clubs.ToList();        //get all clubs from database
            IEnumerable<Club> clubs = await _clubRepository.GetAlls();
            return View(clubs);
        }
        [HttpGet("detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            //get the club with the same id from the club table
            //include == join in database
            // Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}