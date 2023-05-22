using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAnimalDal : IAnimalDal
    {
        List<Animal> _animals;
        public InMemoryAnimalDal()
        {
            _animals = new List<Animal> {
                new Animal{AnimalId=1,ColorId=1,AnimalName="Tavsan",AnimalAge=2,AnimalPrice=300,UnitsInStock=12,Description="Beyaz Tavsan" },
                new Animal{AnimalId=2,ColorId=2,AnimalName="Kopek",AnimalAge=3,AnimalPrice=400,UnitsInStock=2,Description="K9" }



        };

        }

        public void Add(Animal animal)
        {
            _animals.Add(animal);
        }

        public void Delete(Animal animal)
        {
            Animal animalToDelete=_animals.SingleOrDefault(a=>animal.AnimalId==a.AnimalId);
            _animals.Remove(animalToDelete);
        }

        public Animal Get(Expression<Func<Animal, bool>> filter)
        {
            throw new NotImplementedException();
        }

     
        public List<Animal> GetAll(Expression<Func<Animal, bool>> filter = null)
        {
            return _animals;
        }

        public List<AnimalDetailDto> GetAnimalDeatils()
        {
            throw new NotImplementedException();
        }

        public void Update(Animal animal)
        {
            Animal animalToUpdate = _animals.SingleOrDefault(a => animal.AnimalId == a.AnimalId);
            animal.AnimalName = animalToUpdate.AnimalName;
            animal.AnimalAge = animalToUpdate.AnimalAge;
            animal.AnimalPrice = animalToUpdate.AnimalPrice;
            animal.UnitsInStock = animalToUpdate.UnitsInStock;
            animal.ColorId = animalToUpdate.ColorId;
            animal.Description = animalToUpdate.Description;
        }
    }
}
