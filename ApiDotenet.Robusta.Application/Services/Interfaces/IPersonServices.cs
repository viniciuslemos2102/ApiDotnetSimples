using ApiDotenet.Robusta.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotenet.Robusta.Application.Services.Interfaces
{
    public interface IPersonServices
    {
        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
    }
}
