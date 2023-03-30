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
    public class BangDiemController : ControllerBase
    {
        public IBangDiemService _bangDiemService;
        public readonly IMapper _mapper;
        public BangDiemController(IBangDiemService bangDiemService, IMapper mapper)
        {
            _bangDiemService= bangDiemService;  
            _mapper=mapper;
        }

        [HttpGet("GetAllBangDIem")]
        public async Task<IActionResult> GetAllBangDiem()
            => Ok(await _bangDiemService.GetAll());

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _bangDiemService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost("AddMH")]
        public async Task<IActionResult> AddHV(BangDiemVM_Input input)
        {
            if (await _bangDiemService.Add(_mapper.Map<BangDiem>(input)))
            {
                return Ok("Add Successfully!!!");
            }
            return BadRequest();
        }

        [HttpGet("GetBangDiemTheoLopNam")]
        public async Task<IActionResult> Get(string lop, int nam)
        {
            return Ok(await _bangDiemService.GetByCondition(lop, nam));
        }
    }
}
