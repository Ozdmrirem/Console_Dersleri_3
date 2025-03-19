using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("Üye adı boş geçilemez");
            RuleFor(x => x.MemberSurname).NotEmpty().WithMessage("Üye soyadı boş geçilemez");
            RuleFor(x => x.MemberName).MinimumLength(3).WithMessage("Üye adı en az 3 karakter olmalıdır");
            RuleFor(x => x.MemberSurname).MinimumLength(2).WithMessage("Üye soyadı en az 2 karakter olmalıdır");
            RuleFor(x => x.MemberName).MaximumLength(20).WithMessage("Üye adı en fazla 20 karakter olmalıdır");
        }
    }
}
