using Automations.DTOs.CRUDDTOs;
using Automations.Services.CRUDServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Automations.Controllers
{
    [Route("automation/crud")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private readonly ICRUDService _crudService;

        public CRUDController(ICRUDService crudService)
        {
            _crudService = crudService;
        }
        [HttpPost]
        public void RunMundane(Content content)
        {
            _crudService.IServiceCreator(content);
        }
    }
}
