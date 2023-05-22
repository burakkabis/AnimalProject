using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AnimalValidator:AbstractValidator<Animal>
    {

     
            public AnimalValidator()
            {
                RuleFor(a => a.AnimalName).NotEmpty();
                RuleFor(a => a.AnimalName).MinimumLength(2);
                RuleFor(a => a.AnimalPrice).NotEmpty();
                RuleFor(a => a.AnimalPrice).GreaterThan(0);
                RuleFor(a => a.AnimalPrice).GreaterThanOrEqualTo(10).When(p => p.ColorId == 1);
                RuleFor(a => a.AnimalName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

            }

            private bool StartWithA(string arg)
            {
                return arg.StartsWith("A");
            }
        }
    }