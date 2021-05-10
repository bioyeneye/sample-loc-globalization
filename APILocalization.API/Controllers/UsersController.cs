using APILocalization.API.Resources;
using BanklyServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILocalization.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseApiController
    {
        public UsersController(LocService service) : base(service)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                note = locService.GetLocalizedString(LocalConstants.welcome, "Welcome to bankly").Value
            });
        }
    }
}
