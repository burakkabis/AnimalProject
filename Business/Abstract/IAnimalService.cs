using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnimalService
    {
        IDataResult<List<Animal>> GetAll();
        IDataResult<List <Animal> >GetByColorId(int id);
        IDataResult<List<Animal> >GetByUnitPrice(int price);
        IDataResult<List<Animal>> GetByAnimalAge(int age);
        IResult Add(Animal animal);
        IDataResult<List<AnimalDetailDto>> GetAnimalDeatils();


    }
}
