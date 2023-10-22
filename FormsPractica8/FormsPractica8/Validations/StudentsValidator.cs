using CommonLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPractica8.Validations
{
    public class StudentsValidator :AbstractValidator<Students>
    {
        public StudentsValidator()
        {
            RuleFor(student => student.nombreEstudiante).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El nombre no puede estar vacio")
                    .MinimumLength(2).WithMessage("El nombre debe tener minimo 2 letras");

            RuleFor(student => student.apellidoEstudiante).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El apellido no puede estar vacio")
                    .MinimumLength(2).WithMessage("El aapellido debe tener minimo 2 letras");

            RuleFor(student => student.telefonoEstudiante).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El numero de telefono no puede estar vacio")
                    .MinimumLength(7).WithMessage("El numero de telefono debe tener minimo 7 numeros");

            RuleFor(student => student.ciudadEstudiante).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("La ciudad no puede estar vacio")
                    .MinimumLength(2).WithMessage("La ciudad debe tener minimo 2 letras");
        }
    }
}
