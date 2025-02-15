﻿using Microsoft.AspNetCore.Mvc;
using Calendars.Interfaces;
using Calendars.Models;

namespace Calendars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly ILogger<MemberController> _logger; 
        private readonly IMember_member;

        public MemberController(ILogger<MemberController> logger, IMember member) 
        { 
            _logger = logger; 
            _member = member; 
        }

        [HttpGet] 
        public async Task<IActionResult> GetAllMembers() 
        { 
            try 
            { 
                var members = await _member.GetAllMembers(); 
                return Ok(new 
                { 
                    Success = true, 
                    Message = "All Members Returned.", 
                    members 
                });
            } 
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            } 
        }
    }
}
