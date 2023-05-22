using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnimalManager : IAnimalService
    {
        IAnimalDal _animalDal;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }

        [SecuredOperation("animal.add,admin")]

        [ValidationAspect(typeof(AnimalValidator))]
        public IResult Add(Animal animal)
        {
            IResult result = BusinessRules.Run(CheckIfAnimalCountOfColorCorrect(animal.ColorId));
            //ValidationTool.Validate(new AnimalValidator(), animal);
            if (result != null) //Kurala uymayan bir logic olusmussa

            {

                return result;
            }
            //Is kodlarinadn geciyorsa veri erisimi cagirmamz lazim.(_productdal)

            _animalDal.Add(animal);
            return new SuccessResult(Messages.AnimalCountOfColorError);
        }

        public IDataResult <List<Animal>> GetAll()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<Animal>>(Messages.MaintenanceTime);
            }
            //Is kodlarini gecerse veri erisimi cagiracak
            return new SuccessDataResult<List<Animal>>(_animalDal.GetAll(), Messages.AnimalsListed);
        }

        public IDataResult<List<AnimalDetailDto>> GetAnimalDeatils()
        {

            return new SuccessDataResult<List<AnimalDetailDto>>(_animalDal.GetAnimalDeatils());
        }

        public IDataResult<List<Animal>> GetByAnimalAge(int age)
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetAll(a => a.AnimalAge== age));
        }

        public IDataResult<List<Animal>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetAll(a => a.ColorId == id));
        }

        public IDataResult<List<Animal>> GetByUnitPrice(int price)
        {
            return new SuccessDataResult<List<Animal>> (_animalDal.GetAll(a => a.AnimalPrice == price));

            
        }




        private IResult CheckIfAnimalCountOfColorCorrect(int colorId)
        {
            var result = _animalDal.GetAll(p => p.ColorId == colorId).Count;

            if (result >= 15)
            {
                return new ErrorResult(Messages.AnimalCountOfColorError);

            }
            return new SuccessResult();

        }

    }
}


