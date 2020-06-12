using Cw11.DTOs.Requests;
using Cw11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers {
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase {
        private readonly IDbService _service;

        public DoctorController(IDbService service) {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetDoctors() {
            return Ok(_service.GetDoctors());
        }

        [HttpPost]
        public IActionResult CreateDoctor(CreateDoctorRequest request) {
            _service.CreateDoctor(request);
            return Created(nameof(request), request);
        }

        [HttpPut]
        public IActionResult UpdateDoctor(CreateDoctorRequest request) {
            _service.UpdateDoctor(request);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(int id) {
            _service.DeleteDoctor(id);
            return Ok();
        }
    }
}