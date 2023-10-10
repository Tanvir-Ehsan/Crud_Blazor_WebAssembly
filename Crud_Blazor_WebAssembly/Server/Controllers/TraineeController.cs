using Crud_Blazor_WebAssembly.Server.Interfaces;
using Crud_Blazor_WebAssembly.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Blazor_WebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITrainee _itrainee;

        public TraineeController(ITrainee itrainee)
        {
            _itrainee = itrainee;
        }

        [HttpGet]
        public async Task<List<Trainee>> Get()
        {
            return await Task.FromResult(_itrainee.GetTraineeDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Trainee trainee = _itrainee.GetTrainee(id);
            if (trainee != null)
            {
                return Ok(trainee);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Trainee trainee)
        {
            _itrainee.AddTrainee(trainee);
        }
        [HttpPut]
        public void Put(Trainee trainee)
        {
            _itrainee.UpdateTraineeDetails(trainee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _itrainee.DeleteTrainee(id);
            return Ok();
        }


    }
}
