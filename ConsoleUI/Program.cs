using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AnimalGetByColorId();

            //ColorGetAll();
            //GetColorById();

            //ColorAdd();

            //AnimalAdd();

            //GetAnimalDetails();

        }

        //private static void GetAnimalDetails()
        //{
        //    AnimalManager animalManager = new AnimalManager(new EfAnimalDal());

        //    foreach (var animal in animalManager.GetAnimalDeatils())
        //    {
        //        Console.WriteLine(animal.AnimalName + "/" + animal.ColorName);

        //    }
        //}

        private static void AnimalAdd()
        {
            AnimalManager animalManager = new AnimalManager(new EfAnimalDal());
            Animal animal1 = new Animal();
            animal1.AnimalName = "Keci";
            animal1.AnimalPrice = 500;
            animal1.AnimalAge = 4;
            animal1.ColorId = 2;
            animal1.Description = "Siyah Keci";
            animalManager.Add(animal1);
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color();
            color1.ColorName = "Eflatun";
            colorManager.Add(color1);
        }

        private static void GetColorById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetColor(1);
            Console.WriteLine(result.ColorName);
        }

        //private static void AnimaloloGetByCrId()
        //{
        //    AnimalManager animalManager = new AnimalManager(new EfAnimalDal());

        //    foreach (var animal in animalManager.GetByColorId(2))
        //    {
        //        Console.WriteLine(animal.AnimalName);

        //    }
        //}

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);

            }
        }
    }
}
