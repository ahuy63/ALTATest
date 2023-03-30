using ALTATest.Core.IServices;
using ALTATest.Models;
using ALTATest.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ALTATest.Controllers.School
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController : ControllerBase
    {
        public IHocVienService _hocVienService;
        public readonly IMapper _mapper;
        public HocVienController(IHocVienService hocVienService, IMapper mapper)
        {
            _hocVienService = hocVienService;
            _mapper = mapper;
        }

        [HttpGet("GetAllHocVien")]
        public async Task<IActionResult> GetAllHocVien()
            => Ok(await _hocVienService.GetAll());

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _hocVienService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost("AddHV")]
        public async Task<IActionResult> AddHV(HocVienVM_Input input)
        {
            if (await _hocVienService.Add(_mapper.Map<HocVien>(input)))
            {
                return Ok("Add Successfully!!!");
            }
            return BadRequest();
        }


    }
}
