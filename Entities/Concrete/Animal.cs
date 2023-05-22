using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Animal:IEntity
    {
        public int AnimalId { get; set; }
        public int ColorId { get; set; }
        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public int AnimalPrice { get; set; }

        public int UnitsInStock { get; set; }
        public string Description { get; set; }

    }
}
