
using AutoMapper;
using Examen.Models.Evenimente;
using Examen.Models.Evenimente.Dto;
using Examen.Service.EvenimenteService;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EvenimenteController : ControllerBase
{
    private readonly IEvenimenteService _evenimenteService;
    private readonly IMapper _mapper;

    public EvenimenteController(IEvenimenteService evenimenteService, IMapper mapper)
    {
        _evenimenteService = evenimenteService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EvenimenteResponseDto>>> GetAllEvenimente()
    {
        var evenimente = await _evenimenteService.GetAllEvenimente();
        var evenimenteResponseDto = _mapper.Map<IEnumerable<EvenimenteResponseDto>>(evenimente);
        return Ok(evenimenteResponseDto);
    }

    [HttpPost]
    public async Task<ActionResult<EvenimenteResponseDto>> CreateStudent(EvenimenteRequestDto evenimenteRequestDto)
    {
        var evenimente = _mapper.Map<Evenimente>(evenimenteRequestDto);
        var evenimenteCreated = await _evenimenteService.CreateEvenimente(evenimente);
        var evenimenteResponseDto = _mapper.Map<EvenimenteResponseDto>(evenimenteCreated);
        return Ok(evenimenteResponseDto);
    }


}
