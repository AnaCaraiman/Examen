using AutoMapper;
using Examen.Models;
using Examen.Models.Participanti;
using Examen.Models.Participanti.Dto;
using Examen.Service.ParticipantiService;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipantiController : ControllerBase
    {
       

        private readonly IParticipantiService _participantiService;
        private readonly IMapper _mapper;
      

        public ParticipantiController(IParticipantiService participantiService, IMapper mapper)
        {
            _participantiService = participantiService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParticipantiResponseDto>>> GetAllParticipanti()
        {
            var participanti = await _participantiService.GetAllParticipanti();
            var participantiResponseDto = _mapper.Map<IEnumerable<ParticipantiResponseDto>>(participanti);
            return Ok(participantiResponseDto);
        }

        [HttpPost]
        public async Task<ActionResult<ParticipantiResponseDto>> CreateStudent(ParticipantiRequestDto participantiRequestDto)
        {
            var participanti = _mapper.Map<Participanti>(participantiRequestDto);
            var participantiCreated = await _participantiService.CreateParticipanti(participanti);
            var participantiResponseDto = _mapper.Map<ParticipantiResponseDto>(participantiCreated);
            return Ok(participantiResponseDto);
        }

    }
}
