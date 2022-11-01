using ApiDotenet.Robusta.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotenet.Robusta.Application.Validations
{
    public class PersonDTOValidator : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidator()
        {
            RuleFor(x => x.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("Documento deve ser informado!");
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("o nome deve ser informado");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull()
                .WithMessage("o telefone deve ser informado");
        }
    }
}
