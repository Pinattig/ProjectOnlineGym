using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService service; 
    }
}
