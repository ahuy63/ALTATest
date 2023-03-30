using ALTATest.Core.IServices;
using ALTATest.Core.Services;
using ALTATest.Models;
using ALTATest.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ALTATest.Controllers.School
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        public IMonHocSerVice _monHocService;
        public readonly IMapper _mapper;
        public MonHocController(IMonHocSerVice monHocService, IMapper mapper)
        {
            _monHocService = monHocService;
            _mapper = mapper;
        }

        [HttpGet("GetAllMonHoc")]
        public async Task<IActionResult> GetAllMonHoc()
            => Ok(await _monHocService.GetAll());

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _monHocService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost("AddMH")]
        public async Task<IActionResult> AddHV(MonHocVM_Input input)
        {
            if (await _monHocService.Add(_mapper.Map<MonHoc>(input)))
            {
                return Ok("Add Successfully!!!");
            }
            return BadRequest();
        }
    }
}
