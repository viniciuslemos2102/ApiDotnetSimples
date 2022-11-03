using ApiDotenet.Robusta.Application.DTOs;
using ApiDotenet.Robusta.Application.Services.Interfaces;
using ApiDotenet.Robusta.Application.Validations;
using AutoMapper;

namespace ApiDotenet.Robusta.Application.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPersonServices _personRepository;
        private readonly IMapper _mapper;
        public PersonServices(IPersonServices personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            if (personDTO == null)
                return ResultService.Fail<PersonDTO>("Objeto dever ser informado");  

            var result = new PersonDTOValidator().Validate(personDTO);
            if (!result.IsValid)
                return ResultService.RequestError<PersonDTO>("Problemas de validade",result);

            var person = _mapper.Map<PersonDTO>(personDTO);

            var data = await _personRepository.CreateAsync(person);

            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }
    }
}
