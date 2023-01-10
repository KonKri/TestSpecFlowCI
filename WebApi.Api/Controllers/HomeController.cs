﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("hello");
        }
    }
}
