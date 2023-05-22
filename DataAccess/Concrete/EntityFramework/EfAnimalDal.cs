using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalDal : EfEntityRepositoryBase<Animal, AnimalContext>, IAnimalDal
    {
        public List<AnimalDetailDto> GetAnimalDeatils()
        {
            using (AnimalContext context = new AnimalContext())
            {
                var result = from a in context.Animals
                             join c in context.Colors
                             on a.ColorId equals c.ColorId
                             select new AnimalDetailDto
                             {
                                 AnimalId = a.AnimalId,
                                 AnimalName = a.AnimalName,
                                 ColorName = c.ColorName,
                                 UnitsInStock = a.UnitsInStock
                             };
                return result.ToList();

            }
        }
    }
}
