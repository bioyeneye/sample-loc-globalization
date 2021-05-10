using APILocalization.API.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILocalization.API.Controllers
{
    [ApiController]
    public class BaseApiController: ControllerBase
    {
        protected LocService locService;
        public BaseApiController(LocService service)
        {
            this.locService = service;
        }
    }
}
